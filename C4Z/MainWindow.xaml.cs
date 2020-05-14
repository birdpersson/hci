using C4Z.Model;
using System;
using System.Collections.Generic;
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
			s.Show();
		}

		private void AddType_Click(object sender, RoutedEventArgs e)
		{
			var s = new TypeWindow();
			s.Show();
		}

		private void AddTag_Click(object sender, RoutedEventArgs e)
		{
			var s = new TagWindow();
			s.Show();
		}

		private void Table_Click(object sender, RoutedEventArgs e)
		{
			var s = new TableWindow();
			s.Show();
		}
	}
}
