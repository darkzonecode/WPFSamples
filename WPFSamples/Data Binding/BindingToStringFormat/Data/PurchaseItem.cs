using System;
using System.Collections.Generic;
using System.Text;

namespace BindingToStringFormat.Data
{
    public class PurchaseItem
    {
        public PurchaseItem()
        {

        }

        public PurchaseItem(string desc, double price, DateTime endDate)
        {
            Description = desc;
            Price = price;
            OfferExpires = endDate;
        }

        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime OfferExpires { get; set; }


        public override string ToString()
        {
            return $"{Description}, {Price}, {OfferExpires:D}";
        }

    }
}
