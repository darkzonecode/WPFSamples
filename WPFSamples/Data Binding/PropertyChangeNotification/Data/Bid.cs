using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PropertyChangeNotification.Data
{
    public class Bid : INotifyPropertyChanged
    {
        private string _bidItemName;
        private decimal _bidItemPrice;

        public Bid(string newBidItemName, decimal newBidItemPrice)
        {
            _bidItemName = newBidItemName;
            _bidItemPrice = newBidItemPrice;
        }


        public string BidItemName
        {
            get { return _bidItemName; }
            set 
            {
                if (_bidItemName.Equals(value) == false)
                {
                    _bidItemName = value;
                    // Call OnPropertyChanged whenever the property is updated
                    NotifyPropertyChanged();
                }
            }
        }


        public decimal BidItemPrice
        {
            get { return _bidItemPrice; }
            set
            {
                if(_bidItemPrice.Equals(value) == false)
                {
                    _bidItemPrice = value;
                    NotifyPropertyChanged();
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
