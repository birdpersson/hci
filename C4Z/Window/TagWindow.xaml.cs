using C4Z.Model;
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
        private Tag tag;

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
            this.tag = tag;
            Etiketa = new Tag { Oznaka = tag.Oznaka, Boja = tag.Boja, Opis = tag.Opis };
            edit = true;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            if (!edit)
                MainWindow.Data.Tags.Add(Etiketa);
            else
            {
                tag.Oznaka = Etiketa.Oznaka;
                tag.Boja = Etiketa.Boja;
                tag.Opis = Etiketa.Opis;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.MainWindow.Show();
        }
    }
}
