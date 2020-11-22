using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BindConversion.Data
{
    public class MyData : INotifyPropertyChanged
    {
        private DateTime _theDate;

        public MyData()
        {
            _theDate = DateTime.Now;
        }

        public DateTime TheDate
        {
            get { return _theDate; }
            set
            {
                _theDate = value;
                OnPropertyChanged("TheDate");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
