using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMICalculator.Utils
{
    public class MessageBoxUtils
    {

        public static void showDefaultMessageBox(DefaultMessageBoxArguments defaultMessageBoxArguments)
        {
            string messageBoxText = defaultMessageBoxArguments.messageBoxText;
            string caption = defaultMessageBoxArguments.caption;
            MessageBoxButton button = defaultMessageBoxArguments.button;
            MessageBoxImage messageBoxImage = defaultMessageBoxArguments.image;
            MessageBox.Show(messageBoxText, caption, button, messageBoxImage);
        }
    }
    public class DefaultMessageBoxArguments
    {
        public string messageBoxText;
        public string caption;
        public MessageBoxButton button;
        public MessageBoxImage image;
        public DefaultMessageBoxArguments(string messageBoxText,string caption,MessageBoxButton button,MessageBoxImage image)
        {
            this.messageBoxText = messageBoxText;
            this.caption = caption;
            this.button = button;
            this.image = image;
        }
        

    }
}
