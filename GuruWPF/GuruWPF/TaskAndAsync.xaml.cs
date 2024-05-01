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
namespace GuruWPF
{
    /// <summary>
    /// Interaction logic for TaskAndAsync.xaml
    /// https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/threading-model
    /// </summary>
    public partial class TaskAndAsync : Window
    {
        public TaskAndAsync()
        {
            InitializeComponent();
            label.Content= this.Dispatcher.GetHashCode();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = label.Content +button.Dispatcher.GetHashCode().ToString();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

               // below 2 lines will show dispatcher associated with New window will be same as old.
                //NewWindowsDispatcher obj = new NewWindowsDispatcher();
                //obj.Show(); //--- by default dispatcher of caller window and new will be same.
           

            // by default new windows will be shown same dispatcher.
            // To associate a separate dispacher to new window need below code 

            Thread t= new Thread(() =>
            {
                //NewWindowsDispatcher obj = new NewWindowsDispatcher();
                //obj.Show(); //--- by default dispatcher of caller window and new will be same.
                System.Windows.Threading.Dispatcher.Run();
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }
    }
}
