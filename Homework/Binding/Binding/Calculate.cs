using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Binding
{
    internal class Calculate : INotifyPropertyChanged
    {
        private double number1;
        private double number2;
        private double result;

        public double Number1 { get => number1; set { number1 = value; Result = number1 + number2; } }
        public double Number2 { get => number2; set { number2 = value; Result = number1 + number2; } }
        public double Result { get => result; set { result = value; OnPropertyChanged("Result"); } }


        public event PropertyChangedEventHandler? PropertyChanged;


        void OnPropertyChanged(params string[] propertyNames)
        {
            PropertyChangedEventHandler? handler = PropertyChanged;

            if (handler != null)
            {
                foreach (var propertyName in propertyNames)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }


        public override string ToString()
        {
            return result.ToString();
        }
    }
}
