using C4Z.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
        public Dictionary<string, int> Events
        {
            get;
            set;
        }

        public Dictionary<string, int> Types
        {
            get;
            set;
        }

        public Dictionary<string, int> Tags
        {
            get;
            set;
        }

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
            ChartTypes();
            ChartTags();
        }

        #region Search
        private void SearchEvent_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = tbSearchEvent.Text.ToLower();
            ObservableCollection<Event> events = new ObservableCollection<Event>();
            List<Event> list = Data.Events.Where(Event =>
                    Event.Oznaka.ToLower().Contains(text) ||
                    Event.Naziv.ToLower().Contains(text) ||
                    Event.Opis.ToLower().Contains(text)
                ).ToList();
            foreach (Event dog in list)
                events.Add(dog);
            dgEvents.ItemsSource = events;
        }

        private void CancelSearchEvent_Click(object sender, RoutedEventArgs e)
        {
            dgEvents.ItemsSource = Data.Events;
            tbSearchEvent.Text = "";
            tbOznakaEvent.Text = "";
            tbNazivEvent.Text = "";
            tbOpisEvent.Text = "";
            tbDrzavaEvent.Text = "";
            tbGradEvent.Text = "";
            tbMestoEvent.Text = "";
        }

        private void SearchEvent_Click(object sender, RoutedEventArgs e)
        {
            string oznaka = tbOznakaEvent.Text.ToLower();
            string naziv = tbNazivEvent.Text.ToLower();
            string opis = tbOpisEvent.Text.ToLower();
            string drzava = tbDrzavaEvent.Text.ToLower();
            string grad = tbGradEvent.Text.ToLower();
            string mesto = tbMestoEvent.Text.ToLower();
            ObservableCollection<Event> events = new ObservableCollection<Event>();
            List<Event> list = Data.Events.Where(Event =>
                    Event.Oznaka.ToLower().Contains(oznaka) &&
                    Event.Naziv.ToLower().Contains(naziv) &&
                    Event.Opis.ToLower().Contains(opis) &&
                    Event.Drzava.ToLower().Contains(drzava) &&
                    Event.Grad.ToLower().Contains(grad) &&
                    Event.Mesto.ToLower().Contains(mesto)
                ).ToList();
            foreach (Event dog in list)
                events.Add(dog);
            dgEvents.ItemsSource = events;

        }

        private void SearchType_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = tbSearchType.Text.ToLower();
            ObservableCollection<Tvpe> types = new ObservableCollection<Tvpe>();
            List<Tvpe> list = Data.Types.Where(Tip =>
                    Tip.Oznaka.ToLower().Contains(text) ||
                    Tip.Naziv.ToLower().Contains(text) ||
                    Tip.Opis.ToLower().Contains(text)
                ).ToList();
            foreach (Tvpe tip in list)
                types.Add(tip);
            dgTypes.ItemsSource = types;
        }

        private void CancelSearchType_Click(object sender, RoutedEventArgs e)
        {
            dgTypes.ItemsSource = Data.Types;
            tbSearchType.Text = "";
            tbOznakaType.Text = "";
            tbNazivType.Text = "";
            tbOpisType.Text = "";
        }

        private void SearchType_Click(object sender, RoutedEventArgs e)
        {
            string oznaka = tbOznakaType.Text.ToLower();
            string naziv = tbNazivType.Text.ToLower();
            string opis = tbOpisType.Text.ToLower();
            ObservableCollection<Tvpe> types = new ObservableCollection<Tvpe>();
            List<Tvpe> list = Data.Types.Where(Tip =>
                    Tip.Oznaka.ToLower().Contains(oznaka) &&
                    Tip.Naziv.ToLower().Contains(naziv) &&
                    Tip.Opis.ToLower().Contains(opis)
                ).ToList();
            foreach (Tvpe tip in list)
                types.Add(tip);
            dgTypes.ItemsSource = types;
        }

        private void SearchTag_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = tbSearchTag.Text.ToLower();
            ObservableCollection<Tag> tags = new ObservableCollection<Tag>();
            List<Tag> list = Data.Tags.Where(Tag =>
                    Tag.Oznaka.ToLower().Contains(text) ||
                    Tag.Opis.ToLower().Contains(text)
                ).ToList();
            foreach (Tag tag in list)
                tags.Add(tag);
            dgTags.ItemsSource = tags;
        }

        private void CancelSearchTag_Click(object sender, RoutedEventArgs e)
        {
            dgTags.ItemsSource = Data.Tags;
            tbSearchTag.Text = "";
            tbOznakaTag.Text = "";
            tbOpisTag.Text = "";
        }

        private void SearchTag_Click(object sender, RoutedEventArgs e)
        {
            string oznaka = tbOznakaTag.Text.ToLower();
            string opis = tbOpisTag.Text.ToLower();
            ObservableCollection<Tag> tags = new ObservableCollection<Tag>();
            List<Tag> list = Data.Tags.Where(Tag =>
                    Tag.Oznaka.ToLower().Contains(oznaka) &&
                    Tag.Opis.ToLower().Contains(opis)
                ).ToList();
            foreach (Tag tag in list)
                tags.Add(tag);
            dgTags.ItemsSource = tags;
        }
        #endregion

        #region Delete
        private void DeleteEvent_Click(object sender, RoutedEventArgs e)
        {
            Event dog = (Event)dgEvents.SelectedValue;
            Data.ListEvents.Remove(dog);
            Data.MapEvents.Remove(dog);
            Data.Events.Remove(dog);
            ChartTypes();
            ChartTags();
        }

        private void DeleteType_Click(object sender, RoutedEventArgs e)
        {
            Tvpe tip = (Tvpe)dgTypes.SelectedValue;
            Data.Types.Remove(tip);
            /*
            foreach (Event dog in Data.ListEvents)
                if (dog.Tip == tip)
                    Data.ListEvents.Remove(dog);

            foreach (Event dog in Data.MapEvents)
                if (dog.Tip == tip)
                    Data.MapEvents.Remove(dog);

            foreach (Event dog in Data.Events)
                if (dog.Tip == tip)
                    Data.Events.Remove(dog);
            */
            ChartTypes();
            ChartTags();
        }

        private void DeleteTag_Click(object sender, RoutedEventArgs e)
        {
            Tag tag = (Tag)dgTags.SelectedValue;
            Data.Tags.Remove(tag);

            foreach (Event dog in Data.Events)
                dog.Tags.Remove(tag);

            ChartTags();
        }
        #endregion

        #region Edit
        private void EditTag_Click(object sender, RoutedEventArgs e)
        {
            if (dgTags.SelectedValue != null)
            {
                Tag tag = (Tag)dgTags.SelectedValue;
                var s = new TagWindow(tag);
                s.ShowDialog();
                ChartTags();
            }
        }

        private void EditType_Click(object sender, RoutedEventArgs e)
        {
            if (dgTypes.SelectedValue != null)
            {
                Tvpe tip = (Tvpe)dgTypes.SelectedValue;
                var s = new TypeWindow(tip);
                s.ShowDialog();
                ChartTypes();
            }
        }

        private void EditEvent_Click(object sender, RoutedEventArgs e)
        {
            if (dgEvents.SelectedValue != null)
            {
                Event dog = (Event)dgEvents.SelectedValue;
                var s = new EventWindow(dog);
                s.ShowDialog();
                ChartTypes();
                ChartTags();
            }
        }
        #endregion

        #region Chart
        private void ChartTags()
        {
            System.Windows.Controls.DataVisualization.ResourceDictionaryCollection pieSeriesPalette = new System.Windows.Controls.DataVisualization.ResourceDictionaryCollection();
            Tags = new Dictionary<string, int>();

            foreach (Tag t in Data.Tags)
            {
                Tags.Add(t.Oznaka, 0);
                Brush currentBrush = new BrushConverter().ConvertFromString(t.Boja) as SolidColorBrush;

                ResourceDictionary pieDataPointStyles = new ResourceDictionary();
                Style stylePie = new Style(typeof(PieDataPoint));
                stylePie.Setters.Add(new Setter(PieDataPoint.BackgroundProperty, currentBrush));
                pieDataPointStyles.Add("DataPointStyle", stylePie);
                pieSeriesPalette.Add(pieDataPointStyles);
            }
            dvcTag.Palette = pieSeriesPalette;

            foreach (Event e in Data.Events)
                foreach (Tag t in e.Tags)
                    if (Tags.ContainsKey(t.Oznaka))
                        Tags[t.Oznaka]++;
        }

        private void ChartTypes()
        {
            Types = new Dictionary<string, int>();

            foreach (Tvpe t in Data.Types)
                Types.Add(t.Oznaka, 0);

            foreach (Event e in Data.Events)
                if (Types.ContainsKey(e.Tip.Oznaka))
                    Types[e.Tip.Oznaka]++;
        }
        #endregion
    }
}
