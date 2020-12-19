using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SortFilter.Data
{
    public class Order : INotifyPropertyChanged
    {
        private int _customer;
        private DateTime _datefilled;
        private string _filled;
        private int _id;
        private string _name;
        private int _order;
        private DateTime _orderdate;

        public Order(int order, int customer, string name, int id, string filled, DateTime orderdate,
            DateTime datefilled)
        {
            OrderItem = order;
            Customer = customer;
            Name = name;
            Id = id;
            Filled = filled;
            OrderDate = orderdate;
            DateFilled = datefilled;
        }

        public Order(int order, int customer, string name, int id, string filled, DateTime orderdate)
        {
            OrderItem = order;
            Customer = customer;
            Name = name;
            Id = id;
            Filled = filled;
            OrderDate = orderdate;

        }

        public int OrderItem
        {
            get { return _order; }
            set
            {
                _order = value;
                NotifyPropertyChanged();
            }
        }

        public int Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                NotifyPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged();
            }
        }

        public string Filled
        {
            get { return _filled; }
            set
            {
                _filled = value;
                NotifyPropertyChanged();
            }
        }

        public DateTime OrderDate
        {
            get { return _orderdate; }
            set
            {
                _orderdate = value;
                NotifyPropertyChanged();
            }
        }

        public DateTime DateFilled
        {
            get { return _datefilled; }
            set
            {
                _datefilled = value;
                NotifyPropertyChanged();
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
