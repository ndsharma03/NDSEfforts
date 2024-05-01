using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Guru_c_sharp
{
    /// <summary>
    /// Interaction logic for ThreadsInUIApp.xaml
    /// </summary>
    public partial class ThreadsInUIApp : Window
    {
        Thread t;
        public ThreadsInUIApp()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
             t= new Thread(LongOperation);
            t.Start();
        }

        int i;
        private void LongOperation()
        {
            for (i = 0; i < 10; i++) {
                Thread.Sleep(1000);
                i++;
            }
            this.Dispatcher.BeginInvoke(new Action<string>(setLable), i.ToString());
              
              
        }
        private void setLable(string s)
        {
            
            textbox1.Text = s;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            t.Abort();
            this.Dispatcher.Invoke(new Action<string>(setLable), i.ToString());
        }
    }
}
