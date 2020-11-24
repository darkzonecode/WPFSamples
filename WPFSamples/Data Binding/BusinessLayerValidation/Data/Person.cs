using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BusinessLayerValidation.Data
{
    public class Person : IDataErrorInfo
    {
        public int Age { get; set; }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                string result = null;
                if (columnName == "Age")
                {
                    if (Age < 0 || Age > 150)
                    {
                        result = "Age must not be less than 0 or greater than 150.";
                    }
                }

                return result;
            }
        }


    }
}
