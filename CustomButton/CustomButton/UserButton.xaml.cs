using System;
using System.Collections.Generic;
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

namespace CustomButton
{
    /// <summary>
    /// Логика взаимодействия для UserButton.xaml
    /// </summary>
    public partial class UserButton : UserControl
    {
        public UserButton()
        {
            InitializeComponent();

            /*BackgroundButton = new SolidColorBrush(Colors.White);
            ForegroundButton = new SolidColorBrush(Colors.Black);
            TextButton = "Text";*/
        }

        /*private Brush backgroundButton;
        public Brush BackgroundButton
        {
            get { return backgroundButton; }

            set {
                backgroundButton = value; 
                border.Background = backgroundButton;
            }
        }

        private Brush foregroundButton;
        public Brush ForegroundButton
        {
            get { return foregroundButton; }

            set
            {
                foregroundButton = value;
                text.Foreground = foregroundButton;
            }
        }

        private string textButton;
        public string TextButton
        {
            get { return textButton; }

            set
            {
                textButton = value;
                text.Text = textButton;
            }
        }*/
    }
}
