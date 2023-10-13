using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Loan_Calculator
{
    internal class Control : FrameworkElement
    {
        public static DependencyProperty DataProperty;


        static Control()
        {
            DataProperty = DependencyProperty.Register("Data", typeof(int), typeof(Control));
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
