using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateItemsInItemsControl.Data
{
    public class Customer
    {
        public string Name { get; set; }

        public ServiceRep ServiceRepresentative { get; set; }

        public Region Location { get; set; }

    }
}
