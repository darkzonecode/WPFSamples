using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ValidateItemSample.Data
{
    public class PurchaseItem : INotifyPropertyChanged, IEditableObject
    {
        private ItemData _copyData = ItemData.NewItem();
        private ItemData _currentData = ItemData.NewItem();

        public PurchaseItem()
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
            get { return _currentData.OfferExpires; }
            set
            {
                if (value != _currentData.OfferExpires)
                {
                    _currentData.OfferExpires = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public override string ToString() => $"{Description}, {Price:c}, {OfferExpires:D}";

        private struct ItemData
        {
            internal string Description;
            internal DateTime OfferExpires;
            internal double Price;

            internal static ItemData NewItem()
            {
                var data = new ItemData
                {
                    Description = "New item",
                    Price = 0,
                    OfferExpires = DateTime.Now + new TimeSpan(7, 0, 0, 0)
                };

                return data;
            }
        }

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
            NotifyPropertyChanged();
        }

        public void EndEdit()
        {
            _copyData = ItemData.NewItem();
        }

        #endregion
    }
}
