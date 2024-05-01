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
    /// Interaction logic for ItemControlsDemo.xaml
    /// </summary>
    public partial class ItemControlsDemo : Window
    {
        int index = 0;
        public ItemControlsDemo()
        {
            InitializeComponent();
            this.DataContext = Employee.GetEmployees();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Button)sender).Content?.ToString());
          //  MessageBox.Show(this.btnItemContrainerItem.Background.ToString());
        }

        private void BtnItemContrainerItem_Click(object sender, RoutedEventArgs e)
        {
            index += 1;
           DependencyObject listItem= EmployeeList.ItemContainerGenerator.ContainerFromIndex(index);
            var objEmployee = (Employee)((ContentPresenter)(listItem)).Content;
            lblFname.Content = objEmployee.FirstName;
            lblLname.Content = objEmployee.LastName;
            lblage.Content = objEmployee.age;
            lblphone.Content = objEmployee.phone;
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
        public string phone { get; set; }
        public int DeptId { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> lst = new List<Employee>();
            for(int i = 0; i < 100; i++)
            {
                lst.Add(new Employee { age = 10 + i, DeptId = i % 2 == 0 ? 2 : 1, FirstName = "FName" + i, LastName = "LName" + i, phone = "9333666999" });
            }
            return lst;
        }
    }
}
