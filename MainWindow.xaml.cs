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

namespace Inheritance
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Получение данных от пользователя
            //
            double a1 = double.Parse(A1.Text);
            double b1 = double.Parse(B1.Text);
            //
            double a2 = double.Parse(A2.Text);
            double b2 = double.Parse(B2.Text);

            //Создание объектa класса
            Complex_number2 num2 = new Complex_number2(a1, b1, a2, b2);
            //Создание результирующей переменной и вызов метода
            double result = num2.multiplication(a1, b1, a2, b2);

            //Вывод результата
            OUTPUT.Text += "Произведение двух комплексных чисел равно: " + result + Environment.NewLine;
        }
    }
}
