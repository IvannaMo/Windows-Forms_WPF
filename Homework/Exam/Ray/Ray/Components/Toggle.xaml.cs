using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Ray.Components
{
    /// <summary>
    /// Interaction logic for Toggle.xaml
    /// </summary>
    public partial class Toggle : UserControl
    {
        public event Action<bool> Checked;

        public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register(
            "IsChecked", typeof(bool), typeof(Toggle),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
            IsCheckedPropertyChanged, null, false, UpdateSourceTrigger.PropertyChanged)
        );

        public bool IsChecked
        {
            get
            {
                return (bool)GetValue(IsCheckedProperty);
            }
            set
            {
                SetValue(IsCheckedProperty, value);
            }
        }


        private static void IsCheckedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Toggle toggle)
            {
                toggle.UpdateIsChecked();
            }
        }


        public Toggle()
        {
            InitializeComponent();

            IsChecked = false;
        }


        private void CheckedChanged(object sender, MouseButtonEventArgs e)
        {
            IsChecked = !IsChecked;

            //Thread mythread = new Thread(() => MessageBox.Show(IsChecked.ToString())); //Initialize a new Thread to show our MessageBox within 
            //mythread.Start();

            if (Checked != null)
            {
                Checked(IsChecked);
            }
        }


        private void UpdateIsChecked()
        {
            if (IsChecked)
            {
                ellipse.HorizontalAlignment = HorizontalAlignment.Right;
            }
            else
            {
                ellipse.HorizontalAlignment = HorizontalAlignment.Left;
            }
        }
    }
}
