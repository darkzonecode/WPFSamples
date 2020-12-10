using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Data
{
    public class Division
    {
        public Division(string name)
        {
            Name = name;
            Teams = new TeamList();
        }

        public string Name { get; }
        public TeamList Teams { get; }

        public override string ToString() => Name;
    }
}
