using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace C4Z.Validation
{
    class NameValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var s = value as string;
            s = s.Trim();
            if (s.Equals("") == true)
                return new ValidationResult(false, "Input must not be empty");

            return new ValidationResult(true, null);
        }
    }
}
