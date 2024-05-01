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
using System.ComponentModel;

namespace GuruWPF
{
    /// <summary>
    /// Interaction logic for BackgroundWorkerTest.xaml
    /// </summary>
    public partial class BackgroundWorkerTest : Window
    {
        BackgroundWorker bgWorker = new BackgroundWorker();

        public BackgroundWorkerTest()
        {
            InitializeComponent();
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.WorkerSupportsCancellation = true;
        }
        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblpercentage.Content = e.ProgressPercentage + " Completed !!!";
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblCounter.Content = e.Result.ToString();
        }
        int _MaxLimit = 0;
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < _MaxLimit; i++)
            {
                if (bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Thread.Sleep(100);
                bgWorker.WorkerReportsProgress = true;
                bgWorker.ReportProgress(i);
                e.Result = " This program has displayed 1/10 part of a second";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _MaxLimit = Convert.ToInt32(textBox1.Text); //We can assgine and use value for UI in DO_Work() in this way not directly access TextBox in DOWork.
            bgWorker.RunWorkerAsync();
        }

        public void IncrementCounter()
        {
           
        }
        /// <summary>
        /// Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            bgWorker.CancelAsync();
        }
    }
}
