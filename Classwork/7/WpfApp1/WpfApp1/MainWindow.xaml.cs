using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private int language;
        private string[] languages;


        public MainWindow()
        {
            InitializeComponent();

            languages = new string[] { "English", "Ukranian" };
            language = 0;
        }


        private void ChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            language++;
            if (language == languages.Length)
            {
                language = 0;
            }

            if (language == 0)
            {
                File.Content = "File";
                Edit.Content = "Edit";
                View.Content = "View";
                Project.Content = "Project";
                Build.Content = "Build";

                ChangeLanguage.Text = "Change language";
                LanguageImage.Source = new BitmapImage(new Uri("/Images/Flag-United-States-of-America.png", UriKind.Relative));
            }
            else if (language == 1)
            {
                File.Content = "Файл";
                Edit.Content = "Редагувати";
                View.Content = "Вид";
                Project.Content = "Проект";
                Build.Content = "Збірка";

                ChangeLanguage.Text = "Змінити мову";
                LanguageImage.Source = new BitmapImage(new Uri("/Images/Flag-Ukraine.png", UriKind.Relative));
            }
        }
    }
}
