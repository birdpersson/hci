using C4Z.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace C4Z
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Data Data
        {
            get;
            set;
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Data = new Data();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(Data));
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas());
                    Data = (Data)dataContractSerializer.ReadObject(reader);
                    stream.Close();
                }

                if (lvEvents != null)
                    lvEvents.ItemsSource = Data.ListEvents;
                if (lvMapEvents != null)
                    lvMapEvents.ItemsSource = Data.MapEvents;
                if (mniAdd != null)
                {
                    Binding b = new Binding { Source = Data.Types.Count, Path = new PropertyPath("IsEnabled") };
                    b.Mode = BindingMode.OneWay;
                    mniAdd.SetBinding(IsEnabledProperty, b);
                }
                if (tbtAdd != null)
                {
                    Binding b = new Binding { Source = Data.Types.Count, Path = new PropertyPath("IsEnabled") };
                    b.Mode = BindingMode.OneWay;
                    tbtAdd.SetBinding(IsEnabledProperty, b);
                }

            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    var serializer = new DataContractSerializer(Data.GetType());
                    serializer.WriteObject(stream, Data);
                    stream.Close();
                }
            }
        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            var s = new EventWindow();
            s.ShowDialog();
        }

        private void AddType_Click(object sender, RoutedEventArgs e)
        {
            var s = new TypeWindow();
            s.ShowDialog();
        }

        private void AddTag_Click(object sender, RoutedEventArgs e)
        {
            var s = new TagWindow();
            s.ShowDialog();
        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {
            var s = new TableWindow();
            s.Show();
        }

        #region Drag&Drop
        private Point startPoint = new Point();

        private void ListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void ListView_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                // Get the dragged ListViewItem
                ListView listView = sender as ListView;
                ListViewItem listViewItem =
                    FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);

                if (listViewItem == null) return;

                // Find the data behind the ListViewItem
                Event selectedItem = (Event)listView.ItemContainerGenerator.
                    ItemFromContainer(listViewItem);

                // Initialize the drag & drop operation
                DataObject dragData = new DataObject("myFormat", selectedItem);
                DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
            }
        }

        private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        private void ListView_DragOver(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("myFormat") || e.Source == sender)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void MapView_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                Event ev = e.Data.GetData("myFormat") as Event;
                ev.Point = e.GetPosition(lvMapEvents);
                if (Data.MapEvents.Contains(ev) == false)
                {
                    Data.ListEvents.Remove(ev);
                    Data.MapEvents.Add(ev);
                }
            }
        }

        private void EventsView_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                Event ev = e.Data.GetData("myFormat") as Event;
                if (ev.Point.X != -1)
                {
                    ev.Point = new Point(-1, -1);
                    Data.MapEvents.Remove(ev);
                    Data.ListEvents.Add(ev);
                }
            }
        }
        #endregion

        private void SearchEvent_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = tbSearchEvent.Text.ToLower();
            ObservableCollection<Event> events = new ObservableCollection<Event>();
            List<Event> list = Data.MapEvents.Where(Event => Event.Naziv.ToLower().Contains(text)).ToList();
            foreach (Event dog in list)
                events.Add(dog);
            lvMapEvents.ItemsSource = events;
        }

        private void CancelSearchEvent_Click(object sender, RoutedEventArgs e)
        {
            lvMapEvents.ItemsSource = Data.MapEvents;
            tbSearchEvent.Text = "";
        }

        private void EditEvent_Click(object sender, RoutedEventArgs e)
        {
            if (lvEvents.SelectedValue != null)
            {
                Event dog = (Event)lvEvents.SelectedValue;
                EventWindow s = new EventWindow(dog);
                s.ShowDialog();
            }
        }

        private void EditEvent_MouseClick(object sender, MouseButtonEventArgs e)
        {
            if (lvEvents.SelectedValue != null)
            {
                Event dog = (Event)lvEvents.SelectedValue;
                EventWindow s = new EventWindow(dog);
                s.ShowDialog();
            }
        }

        private void EditMapEvent_MouseClick(object sender, MouseButtonEventArgs e)
        {
            if (lvMapEvents.SelectedValue != null)
            {
                Event dog = (Event)lvMapEvents.SelectedValue;
                EventWindow s = new EventWindow(dog);
                s.ShowDialog();
            }
        }

        private void DeleteEvent_Click(object sender, RoutedEventArgs e)
        {
            Event dog = (Event)lvMapEvents.SelectedValue;
            if (lvMapEvents.SelectedValue != null)
            {
                dog.Point = new Point(-1, -1);
                Data.MapEvents.Remove(dog);
                Data.ListEvents.Add(dog);
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            HelpViewer help = new HelpViewer("index", this);
            help.Show();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            IInputElement focusedControl = FocusManager.GetFocusedElement(Application.Current.Windows[0]);
            if (focusedControl is DependencyObject)
            {
                string str = HelpProvider.GetHelpKey((DependencyObject)focusedControl);
                HelpProvider.ShowHelp(str, this);
            }
        }

    }
}
