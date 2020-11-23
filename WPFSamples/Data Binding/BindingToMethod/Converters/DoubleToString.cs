using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BindingToMethod.Converters
{
    public class DoubleToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            CultureInfo culture) => value?.ToString();

        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            var strValue = value as string;
            if (strValue != null)
            {
                double result;
                var converted = double.TryParse(strValue, out result);
                if (converted)
                {
                    return result;
                }
            }
            return null;
        }
    }
}
