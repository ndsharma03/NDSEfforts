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
    /// Interaction logic for StyleTriggerTest.xaml
    /// </summary>
    public partial class StyleTriggerTest : Window
    {
        public StyleTriggerTest()
        {
            InitializeComponent();
        }

        private void BtnTestTrigger_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Button)sender).IsPressed.ToString());
        }
    }
}
