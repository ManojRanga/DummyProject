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

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Employee> employees = new List<Employee>();
            employees.Add(
            new Employee
            {
                SNo = 1,
                Name = "Manoj",
                Age = 23
            });
            employees.Add(
            new Employee
            {
                SNo = 2,
                Name = "Mahesh",
                Age = 23
            });
            employees.Add(
            new Employee
            {
                SNo = 3,
                Name = "Suresh",
                Age = 23
            });
            EmpGrid.ItemsSource= employees;
        }
    }
}
