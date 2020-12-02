using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace SimpleBinding.Data
{
    public class Person : INotifyPropertyChanged
    {


        private string _name;

        public Person()
        {
        }

        public Person(string value)
        {
            _name = value;
        }

        public string PersonName
        {
            get { return _name; }
            set
            {
                _name = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("PersonName");
            }
        }

        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

            //var handler = PropertyChanged;
            //handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
