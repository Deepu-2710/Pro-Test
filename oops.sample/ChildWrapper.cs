using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace oops.sample
{
    public class ChildWrapper : DependencyObject
    {
        private static readonly DependencyProperty valueProperty = DependencyProperty.Register("ValueSring", typeof(string), typeof(ChildWrapper), new PropertyMetadata());

        public string ValueSring
        {
            get
            {
                return (string)GetValue(valueProperty);
            }
            set
            {
                SetValue(valueProperty, value);
            }
        }
    }
}
