using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingAppearanceOfItems.Data
{
    public class Division
    {
        public Division(string name)
        {
            Name = name;
            Teams = new List<Team>();
        }


        public string Name { get; }

        public List<Team> Teams { get; }

    }
}
