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

namespace Buttons_Program
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


        private void menuItem1Bttn_MouseEnter(object sender, MouseEventArgs e)
        {
            menuItem1Ppp.IsOpen = true;
        }

        private void menuItem2Bttn_MouseEnter(object sender, MouseEventArgs e)
        {
            menuItem2Ppp.IsOpen = true;
        }

        private void menuItem3Bttn_MouseEnter(object sender, MouseEventArgs e)
        {
            menuItem3Ppp.IsOpen = true;
        }


        private void menuItem1PppBttn_Click(object sender, RoutedEventArgs e)
        {
            menuItem1Ppp.IsOpen = false;
        }

        private void menuItem2PppBttn_Click(object sender, RoutedEventArgs e)
        {
            menuItem2Ppp.IsOpen = false;
        }

        private void menuItem3PppBttn_Click(object sender, RoutedEventArgs e)
        {
            menuItem3Ppp.IsOpen = false;
        }
    }
}
