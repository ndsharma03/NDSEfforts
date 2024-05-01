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
    /// <summary>
    /// Interaction logic for ChangingTemplateatRuntime.xaml
    /// </summary>
    public partial class ChangingTemplateatRuntime : Window
    {
        public ChangingTemplateatRuntime()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Actual Width of brown lable=" + lblBrown.ActualWidth +" AtackPanle's ActualWidth="+ stackPanel.ActualWidth);
        }
    }
}
