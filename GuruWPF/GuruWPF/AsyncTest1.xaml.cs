using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AsyncTest1.xaml
    /// </summary>
    public partial class AsyncTest1 : Window
    {
        private void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = GetDataSet();
        }

        public ArrayList GetDataSet()
        {
            ArrayList items = new ArrayList();
            for (var count = 0; count < 10000; ++count)
            {
                items.Add(string.Format("Item {0}", count));
            }
            return items;
        }
    
    public AsyncTest1()
        {
            InitializeComponent();
        }

        private async void  BtnStart_Click(object sender, RoutedEventArgs e)
        {
            lblStepstaken.Content += " Button click  ";
            //string result = LongRunningTask();
            LongRunningTaskvoid2();//LongRunningTaskvoid();// 
           // lbl1.Content = result;
            lblStepstaken.Content += "  Again back in Main windows - (After Async method call) ";
        }
        public Task LongRunningTaskvoid()
        {
            lblStepstaken.Content += "   inside long runnning starting thread...";
            return  Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
               // return "Hello";
            });
           
          //  lblStepstaken.Content += "   After finfishing thread ";
        }

        public async void LongRunningTaskvoid2()
        {
           
            await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                // return "Hello";
            });
            //lblStepstaken.Content += "   inside long runnning starting thread...";
            lblStepstaken.Content += "   After finfishing thread ";
        }
        public  Task<string> LongRunningTask()
        {
            lblStepstaken.Content += "   inside long runnning starting thread...";
            return Task.Factory.StartNew(() =>
             {
                 Thread.Sleep(5000);
                 return "Hello";
             });

            //lblStepstaken.Content += "   After finfishing thread ";
        }
    }
}
