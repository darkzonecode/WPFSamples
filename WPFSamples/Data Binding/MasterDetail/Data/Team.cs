using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Data
{
    public class Team
    {
        public Team(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override string ToString() => Name;
        
    }
}
