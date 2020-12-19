﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SortFilter.Data
{
    public class Orders : ObservableCollection<Order>
    {
        public Order O1 = new Order(1001, 5682, "Blue Sweater", 44, "Yes", new DateTime(2003, 1, 23),
           new DateTime(2003, 2, 4));

        public Order O2 = new Order(1002, 2211, "Gray Jacket Long", 181, "No", new DateTime(2003, 2, 14));

        public Order O3 = new Order(1003, 5682, "Brown Pant W", 02, "Yes", new DateTime(2002, 12, 20),
            new DateTime(2003, 1, 13));

        public Order O4 = new Order(1004, 3143, "Orange T-shirt", 205, "No", new DateTime(2003, 1, 28));

        public Orders()
        {
            Add(O1);
            Add(O2);
            Add(O3);
            Add(O4);
        }
    }
    
}
