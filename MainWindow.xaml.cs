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

namespace TKVar1
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
            Calculate(Task1.Text, Task2.Text, Task3.Text, Task4.Text);
        }
        public bool Calculate(String task1, String task2, String task3, String task4)
        {
            if (string.IsNullOrEmpty(task1) || string.IsNullOrEmpty(task2) || string.IsNullOrEmpty(task3) || string.IsNullOrEmpty(task4))
            {
                MessageBox.Show("Введите все баллы");
                return false;
            }
            if(!double.TryParse(task1, out double result1) || !double.TryParse(task2, out double result2) || !double.TryParse(task3, out double result3) || !double.TryParse(task4, out double result4)) 
            {
                MessageBox.Show("Введите числовое значение");
                return false;
            }
            if(result1 < 0 || result1 > 10 || result2 < 0 || result2 > 50 || result3 < 0 || result3 > 30 || result4 < 0 || result1 > 10)
            {
                MessageBox.Show("Введите числа в верном диапазоне");
                return false;
            }
            double resBall = result1 + result2 + result3 + result4;
            SumBallov.Text = resBall.ToString();
            string grade = GetGrade(resBall);
            Grade.Text = grade;
            MessageBox.Show("Успех! Взгляните на свой результат");
            return true;
        }
        private string GetGrade(double totalScore)
        {
            if (totalScore >= 70 && totalScore <= 100)
            {
                return "5";
            }
            else if (totalScore >= 40 && totalScore < 70)
            {
                return "4";
            }
            else if (totalScore >= 20 && totalScore < 40)
            {
                return "3";
            }
            else
            {
                return "2";
            }
        }
    }
}
