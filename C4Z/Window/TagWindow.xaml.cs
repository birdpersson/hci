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
    /// Interaction logic for AddTag.xaml
    /// </summary>
    public partial class TagWindow : Window
    {
        private bool edit = false;
        public static Tag tage;

        public Tag Etiketa
        {
            get;
            set;
        }

        public TagWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Etiketa = new Tag();
        }

        public TagWindow(Tag tag)
        {
            InitializeComponent();
            this.DataContext = this;
            tage = tag;
            Etiketa = new Tag { Oznaka = tag.Oznaka, Boja = tag.Boja, Opis = tag.Opis };
            edit = true;
            ID_TextChanged(null, null);
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            if (!edit)
                MainWindow.Data.Tags.Add(Etiketa);
            else
            {
                tage.Oznaka = Etiketa.Oznaka;
                tage.Boja = Etiketa.Boja;
                tage.Opis = Etiketa.Opis;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.MainWindow.Show();
        }

        private void ID_TextChanged(object sender, TextChangedEventArgs e)
        {
            TagIDValidationRule ev = new TagIDValidationRule();
            if (ev.Validate(tbID.Text, null).IsValid == true)
                btnOK.IsEnabled = true;
            else
                btnOK.IsEnabled = false;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpViewer help = new HelpViewer("tag", null);
            help.Show();
        }

    }
}
