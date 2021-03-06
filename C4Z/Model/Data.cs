﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace C4Z.Model
{
    [DataContract]
    public class Data
    {
        public Data()
        {
            ListEvents = new ObservableCollection<Event>();
            MapEvents = new ObservableCollection<Event>();
            Events = new ObservableCollection<Event>();
            Types = new ObservableCollection<Tvpe>();
            Tags = new ObservableCollection<Tag>();
        }

        [DataMember]
        public ObservableCollection<Event> ListEvents
        {
            get;
            set;
        }

        [DataMember]
        public ObservableCollection<Event> MapEvents
        {
            get;
            set;
        }

        [DataMember]
        public ObservableCollection<Event> Events
        {
            get;
            set;
        }

        [DataMember]
        public ObservableCollection<Tvpe> Types
        {
            get;
            set;
        }

        [DataMember]
        public ObservableCollection<Tag> Tags
        {
            get;
            set;
        }
    }
}
