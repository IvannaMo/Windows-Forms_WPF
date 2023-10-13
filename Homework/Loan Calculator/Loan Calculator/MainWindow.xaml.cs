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

namespace Loan_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void salaryTxtBx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Int32.TryParse(e.Text, out _))
            {
                e.Handled = true;
            }
        }

        private void salaryTxtBx_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void salaryTxtBx_TextChanged(object sender, TextChangedEventArgs e)
        {
            loanSldr.Value = loanSldr.Maximum = customControl.Data;
        }


        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (String.IsNullOrEmpty(salaryTxtBx.Text))
            {
                loanSldr.Value = 0;
            }
            else
            {
                loan.Text = ((int)(loanSldr.Value * 2)).ToString();
            }
        }
    }
}
