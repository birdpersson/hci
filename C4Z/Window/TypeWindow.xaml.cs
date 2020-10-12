using C4Z.Model;
using C4Z.Validation;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddType.xaml
    /// </summary>
    public partial class TypeWindow : Window
    {
        private bool edit = false;
        public static Tvpe tipe;

        public Tvpe Tip
        {
            get;
            set;
        }

        public TypeWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Tip = new Tvpe { Ikonica = "/Images/basic_signs.png" };
        }

        public TypeWindow(Tvpe tip)
        {
            InitializeComponent();
            this.DataContext = this;
            tipe = tip;
            Tip = new Tvpe { Oznaka = tip.Oznaka, Naziv = tip.Naziv, Ikonica = tip.Ikonica, Opis = tip.Opis };
            edit = true;
            TextBox_TextChanged(null, null);
        }

        private void Choose_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Tip.Ikonica = openFileDialog.FileName;
            }

        }

        private void Discard_Click(object sender, RoutedEventArgs e)
        {
            if (!edit)
                Tip.Ikonica = "/Images/basic_signs.png";
            else
                Tip.Ikonica = tipe.Ikonica;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            if (!edit)
                MainWindow.Data.Types.Add(Tip);
            else
            {
                tipe.Oznaka = Tip.Oznaka;
                tipe.Naziv = Tip.Naziv;
                tipe.Ikonica = Tip.Ikonica;
                tipe.Opis = Tip.Opis;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.MainWindow.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TypeIDValidationRule ev = new TypeIDValidationRule();
            NameValidationRule nv = new NameValidationRule();
            if (ev.Validate(tbID.Text, null).IsValid == true && nv.Validate(tbName.Text, null).IsValid == true)
                btnOK.IsEnabled = true;
            else
                btnOK.IsEnabled = false;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpViewer help = new HelpViewer("type", null);
            help.Show();
        }

    }
}
