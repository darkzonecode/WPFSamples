using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Data
{
    public class League
    {
        public League(string name)
        {
            Name = name;
            Divisions = new DivisionList();
        }

        public string Name { get; }
        public DivisionList Divisions { get; }

        public override string ToString() => Name;
    }
}
