using BMICalculator.Enums;
using BMICalculator.Exceptions;
using BMICalculator.Models;
using BMICalculator.Services;
using BMICalculator.Services.Implementation;
using BMICalculator.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMICalculator
{
    public partial class MainWindow : Window
    {
        private BMIServices bmiServices;

        public MainWindow()
        {
            InitializeComponent();
            bmiServices = new BMIServicesImplementation();
        }

        private void getBMI(object sender, RoutedEventArgs e)
        {
            try
            {
                List<double> userWeightHeight = getUserWeightHeight();
                double bmi = bmiServices.calculateBMI(userWeightHeight);
                BMIStatus bmiStatus = bmiServices.calculateBMIStatus(bmi);
                BMIResult bmiResult = new BMIResult(bmi, bmiStatus);
                setBMIResult(bmiResult);
            }
            catch (InvalidNumberFormatException)
            {
                MessageBox.Show("Invalid number format. Please try again.", "Warning",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            HeightTextbox.Clear();
            WeightTextbox.Clear();
            ResultLabel.Content = "Pending...";
            StatusLabel.Content = "Pending...";
            setResultLabelColor(Colors.Black, Colors.White);

        }

        private List<double> getUserWeightHeight()
        {
            string heightRawValue = HeightTextbox.Text.ToString();
            string weightRawValue = WeightTextbox.Text.ToString();

            if (!ValidationUtils.isNumeric(heightRawValue) ||
                !ValidationUtils.isNumeric(weightRawValue))
            {
                throw new InvalidNumberFormatException();

            }

            double height = double.Parse(heightRawValue);
            double weight = double.Parse(weightRawValue);

            return new List<double> { height, weight };
        }

        private void setBMIResult(BMIResult bmiResult)
        {
            double bmi = bmiResult.bmi;
            BMIStatus bmiStatus = bmiResult.bmiStatus;
            ResultLabel.Content = bmi.ToString();
            StatusLabel.Content = bmiStatus.ToString();
            setResultLabelColorByBMIStatus(bmiStatus);
        }


        private void setResultLabelColorByBMIStatus(BMIStatus bmiStatus)
        {
            switch (bmiStatus)
            {
                case BMIStatus.UNDERWEIGHT:
                case BMIStatus.OVERWEIGHT:
                    setResultLabelColor(Colors.White, Colors.Red);
                    break;
                case BMIStatus.NORMAL:
                    setResultLabelColor(Colors.White, Colors.Green);
                    break;
            }
        }

        private void setResultLabelColor(Color foreground, Color background)
        {
            ResultLabel.Foreground = new SolidColorBrush(foreground);
            ResultLabel.Background = new SolidColorBrush(background);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


    }

}
