using CV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CV.ViewModels
{
    internal class DisplayCVViewModel : ViewModelBase
    {
        private static readonly DependencyProperty CVProperty;

        public string CV
        {
            get
            {
                return (string)GetValue(CVProperty);
            }
            set
            {
                SetValue(CVProperty, value);
            }
        }


        static DisplayCVViewModel()
        {
            CVProperty = DependencyProperty.Register("FullName", typeof(string), typeof(DisplayCVViewModel));
        }

        public DisplayCVViewModel(CVPersonInfo cVPersonInfo)
        {
            CV = Information(cVPersonInfo);
        }


        private string Information(CVPersonInfo cVPersonInfo)
        {
            return $"Full name: {cVPersonInfo.FullName}\nAge: {cVPersonInfo.Age}\n" +
                   $"Marital Status: {cVPersonInfo.MaritalStatus}\nAddress: {cVPersonInfo.Address}\nEmail: {cVPersonInfo.Email}" +
                   $"Engish: {cVPersonInfo.Engish}\nC++: {cVPersonInfo.CPlusPlus}\nC#: {cVPersonInfo.CSharp}\nJavaScript: {cVPersonInfo.JavaScript}";
        }
    }
}
