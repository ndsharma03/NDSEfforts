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

namespace GuruWPF.DataTemplate
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Student> GetStudents()
        {
            List<Student> lstStudent = new List<Student>() { new Student { Name = "Niranjan", Age = 38 }, new Student { Name = "Raj", Age = 30 } };

            return lstStudent;
        }
    }
    /// <summary>
    /// Interaction logic for ChaningTemplateAtRuntime.xaml
    /// </summary>
    public partial class ChaningTemplateAtRuntime : Window
    {
        public ChaningTemplateAtRuntime()
        {
            InitializeComponent();
            //itemcontrol.ItemsSource = new Student().GetStudents();
            //lst1.ItemsSource = new Student().GetStudents();

           //Console.Out.WriteLine("WindowDispatcher="+ this.Dispatcher.GetHashCode()+ " TextBox Dispatcher="+dispatcherText.Dispatcher.GetHashCode());
        }
    }
}
