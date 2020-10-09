using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Circle;

namespace Circumference
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadiusTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = _isTextNumeric(e.Text);
        }

        public static bool _isTextNumeric(string str)
        {
            Regex reg = new Regex("[^0-9,]");
            return reg.IsMatch(str);
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(radiusTb.Text))
                resultLbl.Content = "Введите радиус!";
            else
            {
                double radius = Convert.ToDouble(radiusTb.Text);
                resultLbl.Content = Circle.Circle.GetLengthOfCircle(radius);
            }
        }
    }
}
