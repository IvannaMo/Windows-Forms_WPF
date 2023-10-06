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

namespace Photo_Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> imagePaths;


        public MainWindow()
        {
            InitializeComponent();


            imagePaths = new List<string>() { "/Images/Programming.jpg", "/Images/Internet.jpg", "/Images/GameDev.jpg", "/Images/Thinking.jpg", "/Images/Animation.gif" };


            Random random = new Random();

            List<int> randomList = new List<int>();
            for (int i = 0; i < imagePaths.Count(); i++)
            {   
                int num = random.Next(0, imagePaths.Count() - 1);
                if (!randomList.Contains(num))
                {
                    randomList.Add(num);
                }
            }
            

            tabItemImg1.Source = new BitmapImage(new Uri(imagePaths[randomList[0]], UriKind.Relative));
            tabItemImg2.Source = new BitmapImage(new Uri(imagePaths[randomList[1]], UriKind.Relative));
            tabItemImg3.Source = new BitmapImage(new Uri(imagePaths[randomList[2]], UriKind.Relative));
            //tabItemImg4.Source = new BitmapImage(new Uri(imagePaths[randomList[3]], UriKind.Relative));
            //tabItemImg5.Source = new BitmapImage(new Uri(imagePaths[randomList[4]], UriKind.Relative));
        }
    }
}
