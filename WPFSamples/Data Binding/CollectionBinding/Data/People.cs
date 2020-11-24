using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace CollectionBinding.Data
{
    public class People : ObservableCollection<Person>
    {
        public People()
        {
            Add(new Person("Michael", "Alexander", "Bellevue"));
            Add(new Person("Jeff", "Hay", "Redmond"));
            Add(new Person("Christina", "Lee", "Kirkland"));
            Add(new Person("Samantha", "Smith", "Seattle"));
        }
    }
}
