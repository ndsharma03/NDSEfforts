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

namespace Test2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          //  this.DataContext = Student.GetStudents();
            ctnControl.Content = Student.GetStudents();
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }
        public static List<Student> GetStudents()
        {
            List<Student> lstStudent = new List<Student>() { new Student { Name = "Niranjan", Age = 38 }, new Student { Name = "Raj", Age = 30 } };
            return lstStudent;
        }
    }
}
