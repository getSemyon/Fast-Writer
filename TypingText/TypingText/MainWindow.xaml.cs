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

using System.Windows.Media.TextFormatting;

namespace TypingText
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
     

    public partial class MainWindow : Window
    {
        byte CurentSimvol = 0;
        public MainWindow()
        {
            InitializeComponent();
            byte cooutSimvolInWindow = (byte)Math.Round(this.Width / (Text.FontSize / 1.66));

            CurentSimvol = (byte)Math.Round(
                Math.Round(this.Width / (Text.FontSize / 1.66)) / 2, 
                MidpointRounding.AwayFromZero);
        }

        private void Window_TextInput(object sender, TextCompositionEventArgs e)
        {
            char inputSimvol = e.Text[0];

            if (Text.Content.ToString()[0] == inputSimvol)
            {
                char temp = Text.Content.ToString()[0];
                Text.Content = Text.Content.ToString().Substring(1);

                if(TextTaping.Content.ToString().Length == CurentSimvol - 1) TextTaping.Content = TextTaping.Content.ToString().Substring(1);
                TextTaping.Content += "" + temp;
            }
        }
    }
}
