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
    /// Interaction logic for AsyncTest2.xaml
    /// </summary>
    public partial class AsyncTest2 : Window
    {
        public AsyncTest2()
        {
            InitializeComponent();
        }

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Console.Out.WriteLine("Before Async");
             LongRunningWrapper();
            Console.Out.WriteLine("after Async");
        }

        public async void LongRunningWrapper()
        {
            Console.Out.WriteLine("LongRunningWrapper before");
            try
            {
                string result = await LongRunningTask();
                Console.Out.WriteLine("LongRunningWrapper after");
                label.Content = result;
            }
            catch (AggregateException ex)
            {
                Console.Out.Write(" Divide by Zero Exception " +ex.InnerExceptions[0].Source);
            }
            catch (Exception ex) { }
        }
        
        private  Task<string> LongRunningTask()
        {
             return Task.Run<string>(() =>
             {
                
                     Thread.Sleep(5000);
                     Console.Out.WriteLine("REturning from task...");
                     int a = 1, b = 0;
                     //var d = a / b;
                
                 return "Shri Ganesh";
             });

          
        }
       
    }
}
