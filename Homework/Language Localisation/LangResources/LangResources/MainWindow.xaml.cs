using LangResources.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace LangResources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CultureInfo cultureInfoEN;
        private CultureInfo cultureInfoUK;


        public MainWindow()
        {
            InitializeComponent();


            cultureInfoEN = new CultureInfo("en");
            cultureInfoUK = new CultureInfo("uk");
        }


        private void UpdateUI()
        {
            nameTxtBlck.Text = lang.NameTxtBlck;
            surnameTxtBlck.Text = lang.SurnameTxtBlck;
            phoneTxtBlck.Text = lang.PhoneTxtBlck;
            okBttn.Content = lang.OkBttn;
            cancelBttn.Content = lang.CancelBttn;
            changeLangBttn.Content = lang.ChangeLangBttn;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Thread.CurrentThread.CurrentUICulture == cultureInfoUK)
            {
                Thread.CurrentThread.CurrentUICulture = cultureInfoEN;
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = cultureInfoUK;
            }

            UpdateUI();
        }
    }
}
