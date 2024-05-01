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
    /// Interaction logic for RoutedEventTest.xaml
    /// </summary>
    public partial class RoutedEventTest : Window
    {
        private   int _labdaopTestVar = 5;
        public int LambdaOpTest => _labdaopTestVar; // it's equivalent to get{return _labdaopTestVar}

        public RoutedEventTest()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;   //    click event will not bubble up as we have set 'handled=true"
            MessageBox.Show("Button Click " + "LambdaOpTest ="+LambdaOpTest);
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e) //  ***  will not fire as 'Handled=true'  ***
        {
            MessageBox.Show("Stack Panel handling button Click _ "+e.OriginalSource);
        }

        private void Grid_Click(object sender, RoutedEventArgs e)//  ***  will not fire as 'Handled=true'  ***
        {
            MessageBox.Show("Grid  handling button Click _ "+e.OriginalSource);
        }
    }
}
