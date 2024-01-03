using BMICalculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.Services
{
    public interface BMIServices
    {
        double calculateBMI(List<double> userWeightHeight);
        BMIStatus calculateBMIStatus(double bmi);
    }
}
