using System;
using System.Collections.Generic;
using System.Dynamic;
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
    /// Interaction logic for HowTo_DragDrop.xaml
    /// </summary>
    /// 
     
    public partial class HowTo_DragDrop : Window
    {
        public HowTo_DragDrop()
        {
            InitializeComponent();
            DependencyObject parent = leftGrid.Parent;
            while (parent != null)
            {
                System.Diagnostics.Debug.WriteLine(parent);
                parent = ((FrameworkElement)parent)?.Parent;
            }
        }

        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
                        
                
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var ellipse = (Ellipse)sender;
          
           
            Tuple<Brush, double, double> ellipsedetails = new Tuple<Brush, double, double>(ellipse.Fill, ellipse.Width, ellipse.Height);

            DataObject data = new DataObject(typeof(Tuple<Brush, double, double>), ellipsedetails);
            //this.RemoveLogicalChild(ellipse);
       
            DragDrop.DoDragDrop(ellipse, data, DragDropEffects.Move);


            System.Diagnostics.Debug.WriteLine(ellipse.Parent.ToString());
        }

        private void UniformGrid_Drop(object sender, DragEventArgs e)
        {

            System.Windows.Controls.Primitives.UniformGrid uniform = (System.Windows.Controls.Primitives.UniformGrid)sender;

           var data= e.Data.GetData(typeof(Tuple<Brush, double, double>)) as Tuple<Brush, double, double>;

            Ellipse ee = new Ellipse();
            ee.Fill = data.Item1;
            ee.Width = data.Item2;
            ee.Height = data.Item3;
            uniform.Children.Add(ee); 
            
        }
    }
}
