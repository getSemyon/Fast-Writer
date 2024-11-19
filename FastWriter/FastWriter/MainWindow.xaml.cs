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

namespace FastWriter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum StateWrite
        {
            Start,
            Write,
            Pouse,
            Finish
        }

        StateWrite state;

        byte countSimvolInWindow = 0;
        public MainWindow()
        {
            InitializeComponent();

            countSimvolInWindow = (byte)Math.Round(this.Width / (TextTaping.FontSize / 1.66));

            state = StateWrite.Start;
            StartText();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnMaximazi_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_TextInput(object sender, TextCompositionEventArgs e)
        {
            if(state == StateWrite.Write)
            {
                char inputSimvol = e.Text[0];

                if (TextTaping.Content.ToString()[0] == inputSimvol)
                {
                    TextTaping.Content = TextTaping.Content.ToString().Substring(1);

                    if (PresedText.Content.ToString().Length >= countSimvolInWindow / 2)
                        PresedText.Content = PresedText.Content.ToString().Substring(1);

                    PresedText.Content += e.Text;
                }

                if (TextTaping.Content.ToString().Length == 0)
                    StartText();
            }
            else
            {
                if (e.Text == " ")
                    WritetingText();
            }
        }

        private void WritetingText()
        {
            TextTaping.Content = GenerateText(10);
            PresedText.Content = "";
            state = StateWrite.Write;
        }

        byte minCountSimvolInWolrd = 3;
        byte maxCountSimvolInWolrd = 5;

        private string GenerateText(int countSimvol)
        {
            Random rnd = new Random();

            string textGenerate = "";
            byte countSimvolInWorld = (byte)rnd.Next(minCountSimvolInWolrd, maxCountSimvolInWolrd);

            while (countSimvol > 0)
            {
                textGenerate += (char)rnd.Next('а', 'я');


                countSimvolInWorld--;
                if(countSimvolInWorld == 0 && countSimvol > maxCountSimvolInWolrd)
                {
                    textGenerate += " ";
                    countSimvolInWorld = (byte)rnd.Next(3,5);
                    countSimvol--;
                }

                countSimvol--;
            }

            return textGenerate;
        }

        private void StartText()
        {
            TextTaping.Content = "ЧТОБЫ НАЧАТЬ НАЖМИТЕ SPACE";
            PresedText.Content = "";
            state = StateWrite.Start;
        }
    }
}
