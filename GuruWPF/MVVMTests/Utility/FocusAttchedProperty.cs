using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMTests.Utility
{
    class FocusAttched:DependencyObject
    {
        int counter = 1;
        public FocusAttched()
        {
            Console.Out.WriteLine("No of instance=" + counter++);
        }
        public static DependencyProperty IsFocusedProperty = 
            DependencyProperty.RegisterAttached("IsFocused", typeof(bool), typeof(FocusAttched), 
                new UIPropertyMetadata(false, OnIsFocusedChanged));

        public static bool GetIsFocused(DependencyObject dependencyObject)
        {
            return (bool)dependencyObject.GetValue(IsFocusedProperty);
        }

        public static void SetIsFocused(DependencyObject dependencyObject, bool value)
        {
            dependencyObject.SetValue(IsFocusedProperty, value);
        }

        public static void OnIsFocusedChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            ((FrameworkElement)dependencyObject).Focus(); //My Code-Niranjan

            Console.Out.WriteLine("***********"+((System.Windows.Controls.Control)dependencyObject).Name);
            // Removing hard coding
            //TextBox textBox = dependencyObject as TextBox;
            //bool newValue = (bool)dependencyPropertyChangedEventArgs.NewValue;
            //bool oldValue = (bool)dependencyPropertyChangedEventArgs.OldValue;
            //if (newValue && !oldValue && !textBox.IsFocused) textBox.Focus();
        }
    }
}
