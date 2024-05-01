using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace GuruWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.logger.Logs.Add("Adding log from mainWindow Constructor");
        }

        #region Dependency Property
        public static  DependencyProperty ColorNameProperty = DependencyProperty.Register("ColorName", typeof(string), typeof(MainWindow), new FrameworkPropertyMetadata("Jai shri Ganesh!!"));
        public string ColorName
        {
            get { return (string)GetValue(ColorNameProperty); }
            set { this.SetValue(ColorNameProperty, value); }
        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //  MessageBox.Show("Jai Shri Ganesh!!!");
            MessageBox.Show(ColorName);
        }
    }

    public class Person
    {
        public string FirstName { get; set; } = "Niranjan";
        public string LastName { get; set; } = "Sharma";
        public string ConstructorStatus { get; set; }
        public Person()
        {
            ConstructorStatus = "Constructor called";
        }
    }

    public class StringValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "Hello :" + (String)value +" Coverter has appended Hello before your name";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class TextLenghtConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)(((string)value).Length *25);
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    
}
