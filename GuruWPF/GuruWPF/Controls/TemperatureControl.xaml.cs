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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GuruWPF.Controls
{
    /// <summary>
    /// Interaction logic for TemperatureControl.xaml
    /// </summary>
    public partial class TemperatureControl : UserControl
    {

        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Value { get; set; }
        public TemperatureControl()
        {
            Value = 80;
            InitializeComponent();

            for (int i = 0; i < Value; i++)
            {
                // Line line = new Line() { Fill = Brushes.Green, Stretch = Stretch.Fill, Width = container.Width, Height = 2 };

                SolidColorBrush brush= Brushes.Green; 
                if (i >= 70) { brush = Brushes.Red; }
                else if (i >= 40) { brush = Brushes.Orange; }
                else if (i > 0) { brush=Brushes.Green; }
                
                Label line = new Label { Background = brush, Width = 2 , Margin=new Thickness(2)};
                container.Children.Add(line);
               
            }

        }
    }
}
