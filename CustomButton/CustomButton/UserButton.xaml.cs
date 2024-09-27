using System.Windows.Media;
using System.Windows.Controls;

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

            DataContext = this;

            StaticBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDDDDDD"));
            StaticBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF707070"));
            StaticForeground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));

            MouseOverBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBEE6FD"));
            MouseOverBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3C7FB1"));

            PressedBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC4E5F6"));
            PressedBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2C628B"));

            DisabledBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF4F4F4"));
            DisabledBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFADB2B5"));
            DisabledForeground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF838383"));

            Text = "Text";
        }
        // Static 
        public SolidColorBrush StaticBackground { get; set; }
        public SolidColorBrush StaticBorder { get; set; }
        public SolidColorBrush StaticForeground { get; set; }

        // MouseOver 
        public SolidColorBrush MouseOverBackground { get; set; }
        public SolidColorBrush MouseOverBorder { get; set; }

        // Pressed 
        public SolidColorBrush PressedBackground { get; set; }
        public SolidColorBrush PressedBorder { get; set; }

        // Disabled 
        public SolidColorBrush DisabledBackground { get; set; }
        public SolidColorBrush DisabledBorder { get; set; }
        public SolidColorBrush DisabledForeground { get; set; }

        public int BorderRadius { get; set; }
        public string Text { get; set; }
    }
}
