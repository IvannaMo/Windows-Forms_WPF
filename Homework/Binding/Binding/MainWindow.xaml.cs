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

namespace Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculate calculate;


        public MainWindow()
        {
            InitializeComponent();

            calculate = new Calculate();
            this.DataContext = calculate;
        }


        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((!Int32.TryParse(e.Text, out _) && e.Text!=".")
               || (((TextBox)sender).Text == "0" && e.Text != "."))
            {
                e.Handled = true;
            }
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

    }
}
