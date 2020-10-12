using C4Z.Model;
using C4Z.Validation;
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
        public static Event doge;

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

        public static Data Data
        {
            get;
            set;
        }

        public EventWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Data = MainWindow.Data;
            Types = MainWindow.Data.Types;
            Tags = new ObservableCollection<Tag>();
            foreach (Tag t in MainWindow.Data.Tags)
                Tags.Add(t);
            Event = new Event();
            Event.Tip = Types[0];
        }

        public EventWindow(Event dog)
        {
            InitializeComponent();
            this.DataContext = this;
            doge = dog;
            edit = true;
            iconChanged = true;
            Types = MainWindow.Data.Types;
            Tags = new ObservableCollection<Tag>();
            foreach (Tag t in MainWindow.Data.Tags)
                Tags.Add(t);
            foreach (Tag t in dog.Tags)
                Tags.Remove(t);
            Event = new Event { Oznaka = dog.Oznaka, Naziv = dog.Naziv, Opis = dog.Opis, Tip = dog.Tip, Ikonica = dog.Ikonica, Tags = dog.Tags, Posecenost = dog.Posecenost, Humanitarna = dog.Humanitarna, Cena = dog.Cena, Drzava = dog.Drzava, Grad = dog.Grad, Mesto = dog.Mesto, Dates = dog.Dates, Datum = dog.Datum };
            TextBox_TextChanged(null, null);
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
                Event.Ikonica = doge.Ikonica;
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
            {
                MainWindow.Data.ListEvents.Add(Event);
                MainWindow.Data.Events.Add(Event);
            }
            else
            {
                doge.Oznaka = Event.Oznaka;
                doge.Naziv = Event.Naziv;
                doge.Opis = Event.Opis;
                doge.Tip = Event.Tip;
                doge.Tags = Event.Tags;
                doge.Ikonica = Event.Ikonica;
                doge.Posecenost = Event.Posecenost;
                doge.Humanitarna = Event.Humanitarna;
                doge.Cena = Event.Cena;
                doge.Drzava = Event.Drzava;
                doge.Grad = Event.Grad;
                doge.Mesto = Event.Mesto;
                doge.Dates = Event.Dates;
                doge.Datum = Event.Datum;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            EventIDValidationRule ev = new EventIDValidationRule();
            NameValidationRule nv = new NameValidationRule();
            if (ev.Validate(tbID.Text, null).IsValid == true &&
                nv.Validate(tbName.Text, null).IsValid == true &&
                nv.Validate(tbDrzava.Text, null).IsValid == true &&
                nv.Validate(tbGrad.Text, null).IsValid == true &&
                nv.Validate(tbMesto.Text, null).IsValid == true)
                btnOK.IsEnabled = true;
            else
                btnOK.IsEnabled = false;
        }

        private void AddDate_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = cbDates.GetBindingExpression(ComboBox.TextProperty);
            binding.UpdateSource();
            cbDates.Text = "";
        }

        private void RemoveDate_Click(object sender, RoutedEventArgs e)
        {
            Event.Dates.Remove(Event.Date);
            cbDates.Text = "";
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpViewer help = new HelpViewer("event", null);
            help.Show();
        }

    }
}
