using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBinding.Data
{
    public class PersonName
    {
        public PersonName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
