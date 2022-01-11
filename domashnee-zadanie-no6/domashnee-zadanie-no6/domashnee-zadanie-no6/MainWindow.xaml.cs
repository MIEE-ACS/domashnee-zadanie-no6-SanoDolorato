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

namespace domashnee_zadanie_no6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public class Human
    {
        string FIO;
        string age;
        string sex;
        float average_income;
        float average_consumption;

        public Human(string FIO_k, string age_k, string sex_k, float average_income_k, float average_consumption_k)
        {
            FIO = FIO_k;
            age = age_k;
            sex = sex_k;
            average_income = average_income_k;
            average_consumption = average_consumption_k;
        }
        public override string ToString()
        {
            return $"ФИО: {FIO}, возраст: {age}, пол: {sex}, средний доход: {average_income}, средний расход: {average_consumption}";
        }



    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
