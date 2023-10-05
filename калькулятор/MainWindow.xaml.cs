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
using System.Data;


namespace калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        public static string delite(string str,int a)
        {
            if(str.Length<a)
            {
                return string.Empty;

            }
            return str.Remove(str.Length - a);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
                calculator.Text = "";
            else if (str == "=")
            {
                string value = new DataTable().Compute(calculator.Text, null).ToString();
                calculator.Text = value;
            }
            else
                calculator.Text += str;
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string text = calculator.Text;
            text = delite(text, 1);
            calculator.Text = text;
        }
    }
}
