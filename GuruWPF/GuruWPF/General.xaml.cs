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
    /// Interaction logic for General.xaml
    /// </summary>
    public partial class General : Window
    {
        public General()
        {
            App.logger.Logs.Add("From form General");
            InitializeComponent();
            btnEventTester.Click += (sender, e) => { MessageBox.Show("Implemented click handler using Async lambda" +"Sender="+sender); };
        }

        private void Control_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Double click on 'Control Base element'");
        }

        
    }
    public static class StaticMarkupTest
    {
        public static string Name { get; set; } = "Niranjan";
    }
}
