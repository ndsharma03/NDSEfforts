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
    /// Interaction logic for AsyncNawait.xaml
    /// </summary>
    public partial class AsyncNawait : Window
    {
        public AsyncNawait()
        {
            InitializeComponent();
        }

        private async void btnResult_Click(object sender, RoutedEventArgs e)
        {
           
            double dd = await DivisionAsync(Convert.ToDouble(txtFirst.Text), Convert.ToDouble(txtSecond.Text));
            lblResult.Content = dd.ToString();
            //this.Dispatcher.BeginInvoke(
            //    new Action(() => { lblResult.Content = dd.ToString(); })

            //    );
        }
        //private async void btnResult_Click(object sender, RoutedEventArgs e)
        //{
        //    Task<double> task = Task.Run<double>(() => Division(5, 7));
        //    double r = await task;
        //    lblResult.Content = r.ToString(); 
      
        //}
        public async Task<Double> DivisionAsync(double a, double b)
        {
            double r = 0;
            try
            {
                r = await Task.Run<double>(() => Division(a, b));//.ConfigureAwait(continueOnCapturedContext: false); ;
              
                //Task<double> task = Task.Factory.StartNew(() => Division(a, b));
                //r = await task; 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return r;
        }

        public double Division(double a, double b)
        {
            Thread.Sleep(5000);
            double res = a / b;
            return res;
        }
    }
}
