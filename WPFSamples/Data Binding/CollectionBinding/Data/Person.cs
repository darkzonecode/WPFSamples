using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CollectionBinding.Data
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstname;
        private string _hometown;
        private string _lastname;

        public Person()
        {
        }

        public Person(string first, string last, string town)
        {
            _firstname = first;
            _lastname = last;
            _hometown = town;
        }

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged("LastName");
            }
        }

        public string HomeTown
        {
            get { return _hometown; }
            set
            {
                _hometown = value;
                OnPropertyChanged("HomeTown");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString() => _firstname;

        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
