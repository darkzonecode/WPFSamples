﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using ValidateItemsInItemsControl.Data;

namespace ValidateItemsInItemsControl.ValidationRules
{
    public class AreasMatch : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var bg = value as BindingGroup;
            var cust = bg.Items[0] as Customer;

            if (cust == null)
            {
                return new ValidationResult(false, "Customer is not the source object");
            }

            var region = (Region)bg.GetValue(cust, "Location");
            var rep = bg.GetValue(cust, "ServiceRepresentative") as ServiceRep;
            var customerName = bg.GetValue(cust, "Name") as string;

            if (region == rep.Area)
            {
                return ValidationResult.ValidResult;
            }
            var sb = new StringBuilder();
            sb.AppendFormat("{0} must be assigned a sales representative that serves the {1} region. \n ",
                customerName, region);
            return new ValidationResult(false, sb.ToString());
        }
    }
}
