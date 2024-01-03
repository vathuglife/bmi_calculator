using BMICalculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.Models
{
    public class BMIResult
    {        
        public double bmi { get; set; }
        public BMIStatus bmiStatus { get; set; }
        public BMIResult(double bmi, BMIStatus bmiStatus)
        {
            this.bmi = bmi;
            this.bmiStatus = bmiStatus;
        }
        
    }
}
