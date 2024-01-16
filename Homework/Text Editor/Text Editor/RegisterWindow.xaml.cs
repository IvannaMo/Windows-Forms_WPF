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
using System.Windows.Shapes;


namespace Text_Editor
{
    public partial class RegisterWindow : Window
    {
        private string[] _keys;

        public string KeyValue
        {
            get { return textBox.Text; }
        }


        public RegisterWindow()
        {
            InitializeComponent();

            _keys = new string[] { "none", "trial", "pro" };
        }


        private void RegisterButtonClick(object sender, RoutedEventArgs e)
        {
            string key = textBox.Text;

            if ((key == _keys[0]) || (key == _keys[1]) || (key == _keys[2]))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Wrong key!");
            }
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void textBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                registerButton.IsEnabled = true;
            }
            else
            {
                registerButton.IsEnabled = false;
            }
        }
    }
}
