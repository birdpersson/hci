using C4Z.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for AddEvent.xaml
    /// </summary>
    public partial class EventWindow : Window
    {
        private bool iconChanged = false;
        private bool edit = false;
        private Event dog;

        public ObservableCollection<Tvpe> Types
        {
            get;
            set;
        }

        public ObservableCollection<Tag> Tags
        {
            get;
            set;
        }

        public Event Event
        {
            get;
            set;
        }

        public EventWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Event = new Event();
            Types = MainWindow.Data.Types;
            Tags = new ObservableCollection<Tag>();
            foreach (Tag t in MainWindow.Data.Tags)
                Tags.Add(t);
        }

        public EventWindow(Event dog)
        {
            InitializeComponent();
            this.DataContext = this;
            this.dog = dog;
            edit = true;
            iconChanged = true;
            Event = new Event { Oznaka = dog.Oznaka, Naziv = dog.Naziv, Opis = dog.Opis, Tip = dog.Tip, Ikonica = dog.Ikonica, Tags = dog.Tags, Posecenost = dog.Posecenost, Humanitarna = dog.Humanitarna, Cena = dog.Cena, Drzava = dog.Drzava, Grad = dog.Grad, Mesto = dog.Mesto, Istorija = dog.Istorija, Datum = dog.Datum };
            Types = MainWindow.Data.Types;
            Tags = new ObservableCollection<Tag>();
            foreach (Tag t in MainWindow.Data.Tags)
                Tags.Add(t);
            foreach (Tag t in dog.Tags)
                Tags.Remove(t);
        }

        private void AddTag_Click(object sender, RoutedEventArgs e)
        {
            if (UnchosenTags.SelectedValue != null)
            {
                List<Tag> t = new List<Tag>();
                foreach (Tag i in UnchosenTags.SelectedItems)
                {
                    t.Add(i);
                }

                foreach (Tag i in t)
                {
                    Event.Tags.Add(i);
                    Tags.Remove(i);
                }
            }
        }

        private void RemoveTag_Click(object sender, RoutedEventArgs e)
        {
            if (ChosenTags.SelectedValue != null)
            {
                List<Tag> t = new List<Tag>();
                foreach (Tag i in ChosenTags.SelectedItems)
                {
                    t.Add(i);
                }

                foreach (Tag i in t)
                {
                    Event.Tags.Remove(i);
                    Tags.Add(i);
                }
            }
        }

        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!iconChanged)
            {
                Tvpe t = (Tvpe)cbType.SelectedValue;
                Event.Ikonica = t.Ikonica;
            }
        }

        private void Choose_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Event.Ikonica = openFileDialog.FileName;
                iconChanged = true;
            }
        }

        private void Discard_Click(object sender, RoutedEventArgs e)
        {
            if (edit)
                Event.Ikonica = dog.Ikonica;
            else
            {
                Tvpe t = (Tvpe)cbType.SelectedValue;
                Event.Ikonica = t.Ikonica;
                iconChanged = false;
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.MainWindow.Show();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            if (!edit)
                MainWindow.Data.Events.Add(Event);
            else
            {
                dog.Oznaka = Event.Oznaka;
                dog.Naziv = Event.Naziv;
                dog.Opis = Event.Opis;
                dog.Tip = Event.Tip;
                dog.Tags = Event.Tags;
                dog.Ikonica = Event.Ikonica;
                dog.Posecenost = Event.Posecenost;
                dog.Humanitarna = Event.Humanitarna;
                dog.Cena = Event.Cena;
                dog.Drzava = Event.Drzava;
                dog.Grad = Event.Grad;
                dog.Mesto = Event.Mesto;
                dog.Istorija = Event.Istorija;
                dog.Datum = Event.Datum;
            }
        }
    }
}
