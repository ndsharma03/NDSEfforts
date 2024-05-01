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
using ClassLibrary1; 
namespace GuruWPF
{
    /// <summary>
    /// Interaction logic for QuickTest.xaml
    /// </summary>
    public partial class QuickTest : Window
    {
        QuickRevisionEntities entities;
        public QuickTest()
        {
            InitializeComponent();
            entities = new QuickRevisionEntities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var lstEmployee = entities.Employees.ToList();
            listBox1.DataContext = lstEmployee;
        }
    }
}
