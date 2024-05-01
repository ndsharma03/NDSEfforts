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
    /// Interaction logic for ShowLogs.xaml
    /// </summary>
    public partial class ShowLogs : Window
    {
        /// <summary>
        ///  Idea is that instead of adding log directly to data base System will maintain a list of logs and then it will be added to data base via background thread.
        /// </summary>
        public ShowLogs()
        {
            InitializeComponent();
            App.logger.Logs.Add("After Showing Logs below...I will clear log list");
            listBox.ItemsSource = App.logger.Logs;

            Task.Factory.StartNew(() => {
                while (true)
                {
                    if (App.logger.Logs.Count > 0)
                    { App.logger.Logs.RemoveAt(0); }
                    System.Threading.Thread.Sleep(1000);
                }
            });
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ClearLog" + App.logger.Logs.Count);
            
            
            
        }
    }
}
