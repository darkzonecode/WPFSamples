using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateItemsInItemsControl.Data
{
    public class Customers : ObservableCollection<Customer>
    {
        public Customers()
        {
            Add(new Customer());
        }
    }

    // Check whether the customer and service representative are in the
    // same area.
}
