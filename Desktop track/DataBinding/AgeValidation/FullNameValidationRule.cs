﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AgeValidation
{
    class FullNameValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string pattern = @"\A\w+ \w+\Z";
            if (Regex.IsMatch((string)value, pattern))
            {
                return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false,
                    "Full name should be in format '<FirstName> <LastName>'");
            }
        }
    }
}
