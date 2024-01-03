using BMICalculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.Services.Implementation
{
    public class BMIServicesImplementation:BMIServices
    {      
        public double calculateBMI(List<double> userWeightHeight)
        {
            double height = userWeightHeight[0] / 100;
            double weight = userWeightHeight[1];
            double result = Math.Round(weight / Math.Pow(height, 2), 1);
            return result;
        }
        public BMIStatus calculateBMIStatus(double bmi)
        {
            if (bmi < 18.5) return BMIStatus.UNDERWEIGHT;
            else if (bmi >= 18.5 && bmi <= 24.9) return BMIStatus.NORMAL;
            return BMIStatus.OVERWEIGHT;
        }

    }
}
