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
using static System.Net.Mime.MediaTypeNames;

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


            imagePaths = new List<string>() { "/Images/Programming.jpg", "/Images/Internet.jpg", "/Images/GameDev.jpg", "/Images/Thinking.jpg" };


            Random random = new Random();
            List<int> randomList = new List<int>();

            int i = 0;
            while (i < imagePaths.Count())
            {
                int num = random.Next(0, imagePaths.Count());
                if (!randomList.Contains(num))
                {
                    randomList.Add(num);
                    i++;
                }
            }


            tabItemImg1.Source = new BitmapImage(new Uri(imagePaths[randomList[0]], UriKind.Relative));
            tabItemHdr1.Text = imagePaths[randomList[0]].Replace("/Images/", "");

            tabItemImg3.Source = new BitmapImage(new Uri(imagePaths[randomList[1]], UriKind.Relative));
            tabItemHdr3.Text = imagePaths[randomList[1]].Replace("/Images/", "");

            tabItemImg4.Source = new BitmapImage(new Uri(imagePaths[randomList[2]], UriKind.Relative));
            tabItemHdr4.Text = imagePaths[randomList[2]].Replace("/Images/", "");

            tabItemImg5.Source = new BitmapImage(new Uri(imagePaths[randomList[3]], UriKind.Relative));
            tabItemHdr5.Text = imagePaths[randomList[3]].Replace("/Images/", "");

            tabItemHdr2.Text = tabItemImg2.Source.ToString().Replace("../../../Images/", "");
        }
    }
}
