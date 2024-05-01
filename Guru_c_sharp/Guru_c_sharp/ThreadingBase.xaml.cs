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
using System.Threading;
namespace Guru_c_sharp
{
    /// <summary>
    /// This Program will create a thread
    /// </summary>
    public partial class ThreadingBase : Window
    {
        Thread thread1;
        public ThreadingBase()
        {
            InitializeComponent();
        }

        private void btnLongRunningTask_Click(object sender, RoutedEventArgs e)
        {
            thread1 = new Thread(LongRunningOperation);
            thread1.Start();
            
        }

        /// <summary>
        /// Long running task and it will access Label from UI thread.
        /// It also contains try catch block to handle exception which will occur if user cancel thread by Abort() method.
        /// </summary>
        public void LongRunningOperation()
        {
            try
            {
                Thread.Sleep(10000);
                this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        lblResult.Content = "Hello";
                    }), null);

            }
            catch (ThreadAbortException  ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// To cancel thread operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (thread1.IsAlive)
            {
                thread1.Abort();
            }
        }
    }
}
