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

            ButtonStaticBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDDDDDD"));
            ButtonStaticBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF707070"));
            ButtonStaticForeground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));

            ButtonMouseOverBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBEE6FD"));
            ButtonMouseOverBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3C7FB1"));

            ButtonPressedBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC4E5F6"));
            ButtonPressedBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2C628B"));

            ButtonDisabledBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF4F4F4"));
            ButtonDisabledBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFADB2B5"));
            ButtonDisabledForeground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF838383"));

            Text = "Text";
        }
        // Static 
        public SolidColorBrush ButtonStaticBackground { get; set; }
        public SolidColorBrush ButtonStaticBorder { get; set; }
        public SolidColorBrush ButtonStaticForeground { get; set; }

        // MouseOver 
        public SolidColorBrush ButtonMouseOverBackground { get; set; }
        public SolidColorBrush ButtonMouseOverBorder { get; set; }

        // Pressed 
        public SolidColorBrush ButtonPressedBackground { get; set; }
        public SolidColorBrush ButtonPressedBorder { get; set; }

        // Disabled 
        public SolidColorBrush ButtonDisabledBackground { get; set; }
        public SolidColorBrush ButtonDisabledBorder { get; set; }
        public SolidColorBrush ButtonDisabledForeground { get; set; }

        public int BorderRadius { get; set; }
        public string Text { get; set; }
    }
}
