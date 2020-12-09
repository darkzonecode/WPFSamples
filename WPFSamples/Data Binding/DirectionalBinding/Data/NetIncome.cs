using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DirectionalBinding.Data
{
    public class NetIncome : INotifyPropertyChanged
    {
        private int _food;
        private int _misc;
        private int _rent = 2000;
        private int _savings;
        private int _totalIncome = 5000;

        public NetIncome()
        {
            _savings = _totalIncome - (_rent + _food + _misc);
        }

        public int TotalIncome
        {
            get { return _totalIncome; }
            set
            {
                if (TotalIncome != value)
                {
                    _totalIncome = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Rent
        {
            get { return _rent; }
            set
            {
                if (Rent != value)
                {
                    _rent = value;
                    NotifyPropertyChanged();
                    UpdateSavings();
                }
            }
        }

        public int Food
        {
            get { return _food; }
            set
            {
                if (Food != value)
                {
                    _food = value;
                    NotifyPropertyChanged();
                    UpdateSavings();
                }
            }
        }

        public int Misc
        {
            get { return _misc; }
            set
            {
                if (Misc != value)
                {
                    _misc = value;
                    NotifyPropertyChanged();
                    UpdateSavings();
                }
            }
        }

        public int Savings
        {
            get { return _savings; }
            set
            {
                if (Savings != value)
                {
                    _savings = value;
                    NotifyPropertyChanged();
                    UpdateSavings();
                }
            }
        }


        private void UpdateSavings()
        {
            Savings = TotalIncome - (Rent + Misc + Food);
            if (Savings < 0)
            {
            }
            else if (Savings >= 0)
            {
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
