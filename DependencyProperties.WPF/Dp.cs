using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependencyProperties.WPF
{
    internal class Dp : Window
    {


        public int Prop
        {
            get { return (int)GetValue(PropProperty); }
            set { SetValue(PropProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Prop.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PropProperty =
            DependencyProperty.Register("Prop", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(OnPropChanged)));


        private static void OnPropChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        private static void OnPropChanged(DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        // attached property
        public static int GetMyProperty(DependencyObject obj)
        {
            return (int)obj.GetValue(MyPropertyProperty);
        }

        public static void SetMyProperty(DependencyObject obj, int value)
        {
            obj.SetValue(MyPropertyProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.RegisterAttached("MyProperty", typeof(int), typeof(Window), new PropertyMetadata(0));
    }
}
