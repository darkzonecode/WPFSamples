using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EditingCollections.Data
{
    public class PurchaseItem : INotifyPropertyChanged, IEditableObject
    {
        private ItemData _copyData;
        private ItemData _currentData;

        public PurchaseItem()
            : this("New Item", 0, DateTime.Now)
        {
        }

        public PurchaseItem(string desc, double price, DateTime endDate)
        {
            Description = desc;
            Price = price;
            OfferExpires = endDate;
        }

        public string Description
        {
            get { return _currentData.Description; }
            set
            {
                if (_currentData.Description != value)
                {
                    _currentData.Description = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public double Price
        {
            get { return _currentData.Price; }
            set
            {
                if (_currentData.Price != value)
                {
                    _currentData.Price = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public DateTime OfferExpires
        {
            get { return _currentData.OfferExpire; }
            set
            {
                if (_currentData.OfferExpire != value)
                {
                    _currentData.OfferExpire = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public override string ToString() => $"{Description}, {Price:c}, {OfferExpires:D}";

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region IEditableObject Members

        public void BeginEdit()
        {
            _copyData = _currentData;
        }

        public void CancelEdit()
        {
            _currentData = _copyData;
            NotifyPropertyChanged("");
        }

        public void EndEdit()
        {
            _copyData = new ItemData();
        }

        #endregion

        private struct ItemData
        {
            internal string Description;
            internal DateTime OfferExpire;
            internal double Price;
        }
    }



}
