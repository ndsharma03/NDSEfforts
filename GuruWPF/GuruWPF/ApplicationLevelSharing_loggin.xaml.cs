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
    /// Interaction logic for ApplicationLevelSharing_loggin.xaml
    /// </summary>
    public partial class ApplicationLevelSharing_loggin : Window
    {
        public ApplicationLevelSharing_loggin()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            General general = new General();
            general.Show();

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ShowLogs showlogsscreen = new ShowLogs();
            showlogsscreen.Show();
        }
    }
}
