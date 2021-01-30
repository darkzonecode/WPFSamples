using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingAppearanceOfItems.Data
{
    public class League
    {

        public League(string name)
        {
            Name = name;
            Divisions = new List<Division>();
        }

        public string Name { get; }

        public List<Division> Divisions { get; }

    }
}
