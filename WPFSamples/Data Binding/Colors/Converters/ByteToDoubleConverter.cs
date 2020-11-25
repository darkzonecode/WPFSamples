using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Colors.Converters
{
    public class ByteToDoubleConverter : IValueConverter
    {
        object IValueConverter.Convert(object o, Type type, object parameter, CultureInfo culture) 
        {
             return Convert.ChangeType(o, typeof(double));
        }
            

        object IValueConverter.ConvertBack(object o, Type type, object parameter, CultureInfo culture)
        {
            var d = (double)o;
            return (d < 0.0)
                ? (byte)0
                : (d > 255.0)
                    ? (byte)255
                    : Convert.ChangeType(o, typeof(byte));
        }
    }
}
