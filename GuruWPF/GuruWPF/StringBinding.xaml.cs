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

namespace GuruWPF
{
    /// <summary>
    /// Interaction logic for StringBinding.xaml
    /// </summary>
    public partial class StringBinding : Window
    {
        public StringBinding()
        {
            lststrings.DataContext = GetData();
            InitializeComponent();
           
        }

         List<string> GetData(){

            return new List<string>
            {
                "abc",
                "bcd",
                "this is first assignment to check weather string directly bindable or not"
            };
        }
    }
}
