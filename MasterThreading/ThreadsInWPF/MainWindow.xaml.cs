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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ThreadsInWPF
{
    /// <summary>
    /// Main window, Window1 and Window2 will display same Thread ID i.e. all windows are running in same thread.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label1.Content= Thread.CurrentThread.ManagedThreadId.ToString();
            //Window1 win = new Window1();
            //win.Show();
            //Window2 win2 = new Window2();
            //win2.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2();
            win.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RoutedEvent1 routedEventWindow = new RoutedEvent1();
            routedEventWindow.Show();
           
        }
    }
}
