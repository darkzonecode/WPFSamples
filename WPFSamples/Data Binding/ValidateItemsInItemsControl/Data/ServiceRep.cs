using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateItemsInItemsControl.Data
{
    public class ServiceRep
    {
        public ServiceRep()
        {
        }

        public ServiceRep(string name, Region area)
        {
            Name = name;
            Area = area;
        }

        public string Name { get; set; }
        public Region Area { get; set; }

        public override string ToString() => Name + " - " + Area;
    }
}
