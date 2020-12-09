using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UpdateSource.Data
{
    public class UserProfile : INotifyPropertyChanged
    {
        private string _bidPrice = "";
        private string _itemName = "";

        public string ItemName 
        {
            get { return _itemName; }
            set
            {
                _itemName = value;
                NotifyPropertyChanged();
            }
        }

        public string BidPrice 
        {
            get { return _bidPrice; }
            set
            {
                _bidPrice = value;
                NotifyPropertyChanged();
            } 
        }



        // Declare Event.
        public event PropertyChangedEventHandler PropertyChanged;


        // OnPropertyChanged event handler to update value in binding 
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
