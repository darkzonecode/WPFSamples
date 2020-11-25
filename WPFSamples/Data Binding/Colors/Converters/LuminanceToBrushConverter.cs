using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Colors.Converters
{
    public class LuminanceToBrushConverter : IValueConverter
    {
        object IValueConverter.Convert(object o, Type type, object parameter, CultureInfo culture)
        {
            var luminance = (double)o;
            return (luminance < 0.5) ? Brushes.White : Brushes.Black;
        }

        object IValueConverter.ConvertBack(object o, Type type, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
