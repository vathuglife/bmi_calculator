using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BMICalculator.Utils
{
    public class ValidationUtils
    {
        public static bool isNumeric(string input)
        {
            var pattern = @"^-?[0-9]+(?:\.[0-9]+)?$";
            var regex = new Regex(pattern);
            return regex.IsMatch(input);

        }
    }
}
