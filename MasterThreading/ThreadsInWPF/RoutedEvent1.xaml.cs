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

namespace ThreadsInWPF
{
    /// <summary>
    /// Interaction logic for RoutedEvent1.xaml
    /// </summary>
    public partial class RoutedEvent1 : Window
    {
        public RoutedEvent1()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
          
            MessageBox.Show("Grid's mouseLeft Buttton Event  also fired!! \n to stop event bubbling to Grid ..use e.handled=true on lable");
        }

        private void Label_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Label's mouseLeft Buttton Event fired!!");
            e.Handled = true; // if this line is not present then event will bubble up and Grid's MouseLeftButtonDown will also fire.
        }
    }
}
