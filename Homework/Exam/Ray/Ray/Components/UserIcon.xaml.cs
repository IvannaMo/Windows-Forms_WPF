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

namespace Ray.Components
{
    /// <summary>
    /// Interaction logic for UserIcon.xaml
    /// </summary>
    public partial class UserIcon : UserControl
    {
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(
            "Source", typeof(ImageSource), typeof(UserIcon),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
            SourcePropertyChanged, null, false, UpdateSourceTrigger.PropertyChanged)
        );

        public ImageSource Source
        {
            get
            {
                return (ImageSource)GetValue(SourceProperty);
            }
            set
            {
                SetValue(SourceProperty, value);
            }
        }


        private static void SourcePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UserIcon image)
            {
                image.UpdateSource();
            }
        }


        public UserIcon()
        {
            InitializeComponent();
        }


        private void ImageSourceChanged(object sender, RoutedEventArgs e)
        {
            Source = image.Source;
        }

        private void UpdateSource()
        {
            image.Source = Source;
        }
    }
}
