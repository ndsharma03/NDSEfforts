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

namespace GuruWPF
{
    /// <summary>
    /// Interaction logic for AsyncWithWPF.xaml
    /// </summary>
    public partial class AsyncWithWPF : Window
    {

        string strGlobalVariable = "";
        public AsyncWithWPF()
        {
            InitializeComponent();
        }
       
        private async void BtnAsyncReturnVoid1_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "";
            lblResult.Content += " Starting..  ";
            await LongRunningTaskReturnvoid1();
            lblResult.Content += "Finished LongRunningTaskReturnvoid1() " + strGlobalVariable;
        }
        public Task LongRunningTaskReturnvoid1()
        {
            lblResult.Content += "   inside LongRunningTaskReturnvoid1() ";
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                strGlobalVariable += " Async Task has finished ";
            });
        }
        private  void BtnAsyncReturnVoid2_Click(object sender, RoutedEventArgs e)
        {
           
                lblResult.Content = "";
                lblResult.Content += " Starting..  ";
                LongRunningTaskReturnvoid2();
            
            lblResult.Content += "after LongRunningTaskReturnvoid2() call";
        }
        public async void LongRunningTaskReturnvoid2()
        {
          
                await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
               

            });
                lblResult.Content += "  finished LongRunningTaskReturnvoid2()";
            
        }
        private async void BtnAsyncReturn1_Click(object sender, RoutedEventArgs e)
         {
            string result = "";
            lblResult.Content = "";
            lblResult.Content += " Starting..  ";
            try
            {
                result = await LongRunningTask();//.ContinueWith(     //Handling exception
                  //   x=> { MessageBox.Show(x.Exception.InnerExceptions[0].Message); return ""; }
                  //   ,TaskContinuationOptions.OnlyOnFaulted);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Handled");
            }
            lblResult.Content += result +" Finished LongRunningTaskvoid()";
           
        }
        public Task<string> LongRunningTask()
        {
            lblResult.Content += "   inside LongRunningTask() ";
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000); throw new Exception("test");
                return "Hello";
            });

        }
       
        private void BtnTestResponsiveness_Click(object sender, RoutedEventArgs e)
        {
            //ExceptionUnwrappingTest();
            MessageBox.Show("Hello");
        }
     
    }
}
