using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValidateItemSample.ValidationRules
{
    public class PriceIsAPositiveNumber : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var price = Convert.ToDouble(value);

                if (price < 0)
                {
                    return new ValidationResult(false, "Price must be positive.");
                }
                return ValidationResult.ValidResult;
            }
            catch (Exception)
            {
                // Exception thrown by Conversion - value is not a number.
                return new ValidationResult(false, "Price must be a number.");
            }
        }
    }
}
