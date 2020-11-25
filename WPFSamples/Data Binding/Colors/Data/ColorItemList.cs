using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Colors.Data
{
    public class ColorItemList : ObservableCollection<ColorItem>
    {
        public ColorItemList()
        {
            var type = typeof(System.Windows.Media.Brushes);
            foreach (var propertyInfo in type.GetProperties(BindingFlags.Public | BindingFlags.Static))
            {
                if (propertyInfo.PropertyType == typeof(SolidColorBrush))
                    Add(new ColorItem(propertyInfo.Name, (SolidColorBrush)propertyInfo.GetValue(null, null)));
            }
        }
    }
}
