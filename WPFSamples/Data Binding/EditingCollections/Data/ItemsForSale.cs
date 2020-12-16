﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditingCollections.Data
{
    public class ItemsForSale : ObservableCollection<PurchaseItem>
    {
        public ItemsForSale()
        {
            Add((new PurchaseItem("Snowboard and bindings", 120, new DateTime(2009, 1, 1))));
            Add((new PurchaseItem("Inside C#, second edition", 10, new DateTime(2009, 2, 2))));
            Add((new PurchaseItem("Laptop - only 1 year old", 499.99, new DateTime(2009, 2, 28))));
            Add((new PurchaseItem("Set of 6 chairs", 120, new DateTime(2009, 2, 28))));
            Add((new PurchaseItem("My DVD Collection", 15, new DateTime(2009, 1, 1))));
            Add((new PurchaseItem("TV Drama Series", 39.985, new DateTime(2009, 1, 1))));
            Add((new PurchaseItem("Squash racket", 60, new DateTime(2009, 2, 28))));
        }
    }
}
