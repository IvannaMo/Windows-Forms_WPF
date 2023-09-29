using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Safe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        public string FormTitle
        {
            get
            {
                return Title;
            }
            set
            {
                Title = value;
            }
        }

        public string InputPassword
        {
            get 
            {
                return outputBox.Text; 
            }
            set
            {
                outputBox.Text = value;
            }
        }


        public event EventHandler<EventArgs> NumEvent;
        public event EventHandler<EventArgs> CEvent;
        public event EventHandler<EventArgs> OkEvent;


        public MainWindow()
        {
            InitializeComponent();
        }


        private void numBttn_Click(object sender, RoutedEventArgs e)
        {
            NumEvent?.Invoke(this, EventArgs.Empty);
        }

        private void cBttn_Click(object sender, RoutedEventArgs e)
        {
            CEvent?.Invoke(this, EventArgs.Empty);
        }

        private void okBttn_Click(object sender, RoutedEventArgs e)
        {
            OkEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
