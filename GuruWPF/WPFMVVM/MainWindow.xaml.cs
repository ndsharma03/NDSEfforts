using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly DependencyProperty CountDependecyProperty = 
                               DependencyProperty.Register("Count", typeof(int), typeof(MainWindow), new FrameworkPropertyMetadata(5));
        public int Count
        {
            get{  return (int)GetValue(CountDependecyProperty); }
            set { SetValue(CountDependecyProperty, value); }
        }

        public MainWindow()
        {
           
            InitializeComponent();
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddArticle objAddArticle = new AddArticle();
            objAddArticle.Show();
        }
    }
}
