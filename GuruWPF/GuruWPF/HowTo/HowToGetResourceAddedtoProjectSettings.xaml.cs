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

namespace GuruWPF.HowTo
{
    /// <summary>
    /// Interaction logic for HowToGetResourceAddedtoProjectSettings.xaml
    /// </summary>
    public partial class HowToGetResourceAddedtoProjectSettings : Window
    {
        public HowToGetResourceAddedtoProjectSettings()
        {
            InitializeComponent();
            
            label.Content = GuruWPF.Properties.Resources.TestResource;
        }
    }
}
