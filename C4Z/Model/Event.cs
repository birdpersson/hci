using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace C4Z.Model
{
	[DataContract]
	public class Event : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string name)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(name));
			}
		}

		public enum PosecenostDogadjaja { DO_1000, DO_5000, DO_10000, PREKO_10000 }

		[NonSerialized]
		private string _oznaka;
		private string _naziv;
		private string _opis;
		private Tvpe _tip;
		private PosecenostDogadjaja _posecenost;
		private string _ikonica;
		private bool _humanitarna;
		private string _cena;
		private string _drzava;
		private string _grad;
		private string _mesto;
		private string _istorija;
		private DateTime _datum = DateTime.Now;

		[DataMember]
		public ObservableCollection<Tag> Tags { get; set; } = new ObservableCollection<Tag>();

		[DataMember]
		public string Oznaka
		{
			get
			{
				return _oznaka;
			}
			set
			{
				if (value != _oznaka)
				{
					_oznaka = value;
					OnPropertyChanged("Oznaka");
				}
			}
		}

		[DataMember]
		public string Naziv
		{
			get
			{
				return _naziv;
			}
			set
			{
				if (value != _naziv)
				{
					_naziv = value;
					OnPropertyChanged("Naziv");
				}
			}
		}

		[DataMember]
		public string Opis
		{
			get
			{
				return _opis;
			}
			set
			{
				if (value != _opis)
				{
					_opis = value;
					OnPropertyChanged("Opis");
				}
			}
		}

		[DataMember]
		public Tvpe Tip
		{
			get
			{
				return _tip;
			}
			set
			{
				if (value != _tip)
				{
					_tip = value;
					OnPropertyChanged("Tip");
				}
			}
		}

		[DataMember]
		public int Posecenost
		{
			get
			{
				return (int)_posecenost;
			}
			set
			{
				if (value != (int)_posecenost)
				{
					_posecenost = (PosecenostDogadjaja)value;
					OnPropertyChanged("Posecenost");
				}
			}
		}

		[DataMember]
		public string Ikonica
		{
			get
			{
				return _ikonica;
			}
			set
			{
				if (value != _ikonica)
				{
					_ikonica = value;
					OnPropertyChanged("Ikonica");
				}
			}
		}

		[DataMember]
		public bool Humanitarna
		{
			get
			{
				return _humanitarna;
			}
			set
			{
				if (value != _humanitarna)
				{
					_humanitarna = value;
					OnPropertyChanged("Humanitarna");
				}
			}
		}

		[DataMember]
		public string Cena
		{
			get
			{
				return _cena;
			}
			set
			{
				if (value != _cena)
				{
					_cena = value;
					OnPropertyChanged("Cena");
				}
			}
		}

		[DataMember]
		public string Drzava
		{
			get
			{
				return _drzava;
			}
			set
			{
				if (value != _drzava)
				{
					_drzava = value;
					OnPropertyChanged("Drzava");
				}
			}
		}

		[DataMember]
		public string Grad
		{
			get
			{
				return _grad;
			}
			set
			{
				if (value != _grad)
				{
					_grad = value;
					OnPropertyChanged("Grad");
				}
			}
		}

		[DataMember]
		public string Mesto
		{
			get
			{
				return _mesto;
			}
			set
			{
				if (value != _mesto)
				{
					_mesto = value;
					OnPropertyChanged("Mesto");
				}
			}
		}

		[DataMember]
		public string Istorija
		{
			get
			{
				return _istorija;
			}
			set
			{
				if (value != _istorija)
				{
					_istorija = value;
					OnPropertyChanged("Istorija");
				}
			}
		}

		[DataMember]
		public DateTime Datum
		{
			get
			{
				return _datum;
			}
			set
			{
				if (!value.Equals(_datum))
				{
					_datum = value;
					OnPropertyChanged("Datum");
				}
			}
		}
	}
}
