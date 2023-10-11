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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Windows.Controls.Image;

namespace Puzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int choice;

        private List<string> puzzlePaths;
        private List<CroppedBitmap> puzzlePiecesBmp;


        public MainWindow()
        {
            InitializeComponent();


            choice = 1;

            puzzlePaths = new List<string>() { "/Images/Puzzle 1.jpg", "/Images/Puzzle 2.jpg", "/Images/Puzzle 3.jpg" };
            puzzlePiecesBmp = new List<CroppedBitmap>();

            CreatePuzzle();
        }


        private void CreatePuzzle()
        {
            BitmapImage imageBmp = new BitmapImage(new Uri(puzzlePaths[choice - 1], UriKind.Relative));
            imageBmp.BaseUri = BaseUriHelper.GetBaseUri(this);


            puzzlePiecesBmp.Clear();
            puzzlePiecesBmp.Add(new CroppedBitmap(imageBmp, new Int32Rect(0, 0, imageBmp.PixelWidth / 3, imageBmp.PixelHeight / 2)));
            puzzlePiecesBmp.Add(new CroppedBitmap(imageBmp, new Int32Rect(imageBmp.PixelWidth / 3, 0, imageBmp.PixelWidth / 3, imageBmp.PixelHeight / 2)));
            puzzlePiecesBmp.Add(new CroppedBitmap(imageBmp, new Int32Rect(imageBmp.PixelWidth / 3 * 2, 0, imageBmp.PixelWidth / 3, imageBmp.PixelHeight / 2)));
            puzzlePiecesBmp.Add(new CroppedBitmap(imageBmp, new Int32Rect(0, imageBmp.PixelHeight / 2, imageBmp.PixelWidth / 3, imageBmp.PixelHeight / 2)));
            puzzlePiecesBmp.Add(new CroppedBitmap(imageBmp, new Int32Rect(imageBmp.PixelWidth / 3, imageBmp.PixelHeight / 2, imageBmp.PixelWidth / 3, imageBmp.PixelHeight / 2)));
            puzzlePiecesBmp.Add(new CroppedBitmap(imageBmp, new Int32Rect(imageBmp.PixelWidth / 3 * 2, imageBmp.PixelHeight / 2, imageBmp.PixelWidth / 3, imageBmp.PixelHeight / 2)));


            Random random = new Random();
            List<int> randomList = new List<int>();

            int i = 0;
            while (i < puzzlePiecesBmp.Count())
            {
                int num = random.Next(0, puzzlePiecesBmp.Count());
                if (!randomList.Contains(num))
                {
                    randomList.Add(num);
                    i++;
                }
            }


            puzzlePieceImg1.Source = puzzlePiecesBmp[randomList[0]];
            puzzlePieceImg2.Source = puzzlePiecesBmp[randomList[1]];
            puzzlePieceImg3.Source = puzzlePiecesBmp[randomList[2]];
            puzzlePieceImg4.Source = puzzlePiecesBmp[randomList[3]];
            puzzlePieceImg5.Source = puzzlePiecesBmp[randomList[4]];
            puzzlePieceImg6.Source = puzzlePiecesBmp[randomList[5]];


            mainPuzzleImg1.Source = null;
            puzzleImg2.Source = null;
            puzzleImg3.Source = null;
            puzzleImg4.Source = null;
            puzzleImg5.Source = null;
            puzzleImg6.Source = null;
        }


        private void puzzleChoice1_Click(object sender, RoutedEventArgs e)
        {
            choice = 1;
            CreatePuzzle();
        }

        private void puzzleChoice2_Click(object sender, RoutedEventArgs e)
        {
            choice = 2;
            CreatePuzzle();
        }

        private void puzzleChoice3_Click(object sender, RoutedEventArgs e)
        {
            choice = 3;
            CreatePuzzle();
        }


        private void puzzlePieceImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image puzzlePiece = (Image)sender;
            DragDrop.DoDragDrop(puzzlePiece, new DataObject(typeof(ImageSource), puzzlePiece.Source), DragDropEffects.Move);
        }

        private void puzzlePieceImg_Drop(object sender, DragEventArgs e)
        {
            Border border = (Border)sender;
            Image puzzleImage = (Image)border.Child;

            puzzleImage.Source = (ImageSource)e.Data.GetData(typeof(ImageSource));
        }


        private void mainPuzzleImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image mainPuzzle = (Image)sender;
            DragDrop.DoDragDrop(mainPuzzle, new DataObject(typeof(ImageSource), mainPuzzle.Source), DragDropEffects.Move);
        }

        private void mainPuzzleImg_Drop(object sender, DragEventArgs e)
        {
            Border border = (Border)sender;
            Image mainPuzzleImg = (Image)border.Child;

            mainPuzzleImg.Source = (ImageSource)e.Data.GetData(typeof(ImageSource));
        }
    }
}
