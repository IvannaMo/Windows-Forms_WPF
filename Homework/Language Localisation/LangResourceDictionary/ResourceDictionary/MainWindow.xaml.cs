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

namespace LangResourceDictionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ResourceDictionary enDictionary;
        private ResourceDictionary uaDictionary;


        public MainWindow()
        {
            InitializeComponent();


            enDictionary = new ResourceDictionary();
            enDictionary.Source = new Uri("Resources/Lang EN.xaml", UriKind.Relative);

            uaDictionary = new ResourceDictionary();
            uaDictionary.Source = new Uri("Resources/Lang UA.xaml", UriKind.Relative);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Resources.MergedDictionaries[0] == uaDictionary)
            {
                Application.Current.Resources.MergedDictionaries[0] = enDictionary;
            }
            else
            {
                Application.Current.Resources.MergedDictionaries[0] = uaDictionary;
            }
        }
    }
}
