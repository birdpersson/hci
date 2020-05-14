using C4Z.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace C4Z
{
    /// <summary>
    /// Interaction logic for Table.xaml
    /// </summary>
    public partial class TableWindow : Window
    {
        public static Data Data
        {
            get;
            set;
        }

        public TableWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Data = MainWindow.Data;
        }

        #region Search
        private void SearchEvent_Click(object sender, RoutedEventArgs e)
        {
            string text = tbSearchEvent.Text.ToLower();
            ObservableCollection<Event> events = new ObservableCollection<Event>();
            List<Event> list = Data.Events.Where(Event => Event.Oznaka.ToLower().Contains(text) || Event.Opis.ToLower().Contains(text)).ToList();
            foreach (Event dog in list)
                events.Add(dog);
            dgEvents.ItemsSource = events;
        }

        private void CancelSearchEvent_Click(object sender, RoutedEventArgs e)
        {
            dgEvents.ItemsSource = Data.Events;
            tbSearchEvent.Text = "";
        }

        private void SearchEvent_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FilterEvent.IsChecked == true)
                SearchEvent_Click(null, null);
        }

        private void SearchType_Click(object sender, RoutedEventArgs e)
        {
            string text = tbSearchType.Text.ToLower();
            ObservableCollection<Tvpe> types = new ObservableCollection<Tvpe>();
            List<Tvpe> list = Data.Types.Where(Tip => Tip.Oznaka.ToLower().Contains(text) || Tip.Opis.ToLower().Contains(text)).ToList();
            foreach (Tvpe tip in list)
                types.Add(tip);
            dgTypes.ItemsSource = types;
        }

        private void CancelSearchType_Click(object sender, RoutedEventArgs e)
        {
            dgTypes.ItemsSource = Data.Types;
            tbSearchType.Text = "";
        }

        private void SearchType_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FilterType.IsChecked == true)
                SearchType_Click(null, null);
        }

        private void SearchTag_Click(object sender, RoutedEventArgs e)
        {
            string text = tbSearchTag.Text.ToLower();
            ObservableCollection<Tag> tags = new ObservableCollection<Tag>();
            List<Tag> list = Data.Tags.Where(Tag => Tag.Oznaka.ToLower().Contains(text) || Tag.Opis.ToLower().Contains(text)).ToList();
            foreach (Tag tag in list)
                tags.Add(tag);
            dgTags.ItemsSource = tags;
        }

        private void CancelSearchTag_Click(object sender, RoutedEventArgs e)
        {
            dgTags.ItemsSource = Data.Tags;
            tbSearchTag.Text = "";
        }

        private void SearchTag_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FilterTag.IsChecked == true)
                SearchTag_Click(null, null);
        }
        #endregion

        #region Delete
        private void DeleteEvent_Click(object sender, RoutedEventArgs e)
        {
            Event dog = (Event)dgEvents.SelectedValue;
            Data.Events.Remove(dog);
        }

        private void DeleteType_Click(object sender, RoutedEventArgs e)
        {
            Tvpe tip = (Tvpe)dgTypes.SelectedValue;
            //	foreach (Event dog in Data.Events)
            //		if (dog.Tip == tip)
            //			Data.Events.Remove(dog);
            Data.Types.Remove(tip);
        }

        private void DeleteTag_Click(object sender, RoutedEventArgs e)
        {
            Tag tag = (Tag)dgTags.SelectedValue;
            Data.Tags.Remove(tag);
        }
        #endregion

        #region Edit
        private void EditTag_Click(object sender, RoutedEventArgs e)
        {
            if (dgTags.SelectedValue != null)
            {
                Tag tag = (Tag)dgTags.SelectedValue;
                var s = new TagWindow(tag);
                s.Show();
            }
        }

        private void EditType_Click(object sender, RoutedEventArgs e)
        {
            if (dgTypes.SelectedValue != null)
            {
                Tvpe tip = (Tvpe)dgTypes.SelectedValue;
                var s = new TypeWindow(tip);
                s.Show();
            }
        }

        private void EditEvent_Click(object sender, RoutedEventArgs e)
        {
            if (dgEvents.SelectedValue != null)
            {
                Event dog = (Event)dgEvents.SelectedValue;
                var s = new EventWindow(dog);
                s.Show();
            }
        }
        #endregion
    }
}
