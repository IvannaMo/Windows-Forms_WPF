using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Loan_Calculator
{
    internal class Property : FrameworkElement
    {
        public static DependencyProperty DataProperty;


        static Property()
        {
            DataProperty = DependencyProperty.Register("Data", typeof(int), typeof(Property));
        }


        public int Data
        {
            get
            {
                return (int)GetValue(DataProperty);
            }
            set
            {
                SetValue(DataProperty, value);
            }
        }
    }
}
