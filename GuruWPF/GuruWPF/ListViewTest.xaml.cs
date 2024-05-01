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
using System.Windows.Shapes;

namespace GuruWPF
{
    /// <summary>
    /// Interaction logic for ListViewTest.xaml
    /// </summary>
    public partial class ListViewTest : Window
    {
        List<Employee> employees = Employee.GetEmployees();
        public ListViewTest()
        {
            InitializeComponent();
            this.DataContext = employees;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LastNameCM_Click(object sender, RoutedEventArgs e)
        {
            if (((MenuItem)(e.Source)).Header.ToString() == "Ascending")
            {
                employees=employees.OrderBy(x => x.LastName).ToList<Employee>();
                this.DataContext = employees;
            }
            else
            {

                employees = employees.OrderByDescending(x => x.LastName).ToList<Employee>();
                this.DataContext = employees;
            }
        }
    }
}
