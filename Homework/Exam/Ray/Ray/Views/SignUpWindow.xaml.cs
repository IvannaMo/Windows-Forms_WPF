using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

using Point = System.Drawing.Point;

using Ray.ViewModels;
using Application = System.Windows.Application;
using System.Drawing;
using Ray.Models;
using MessageBox = System.Windows.MessageBox;


namespace Ray.Views
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        private Rect ScreenWorkArea;


        public Rect GetCurrentScreenWorkArea(Window window)
        {
            Screen screen = Screen.FromPoint(new Point((int)window.Left, (int)window.Top));
            DpiScale dpiScale = VisualTreeHelper.GetDpi(window);

            return new Rect { Width = screen.WorkingArea.Width / dpiScale.DpiScaleX, Height = screen.WorkingArea.Height / dpiScale.DpiScaleY };
        }


        public SignUpWindow()
        {
            InitializeComponent();

            SignUpViewModel signUpViewModel = new SignUpViewModel();
            DataContext = signUpViewModel;


            Application.Current.MainWindow = this;
            ScreenWorkArea = GetCurrentScreenWorkArea(Application.Current.MainWindow);
        }


        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            signUpImage.Width = (int)(ScreenWorkArea.Width * 14.74 / 100);

            //windowBorderRow.Height = new GridLength((int)(signUpGrid.ActualHeight * 10.44 / 100), GridUnitType.Pixel);
            //signUpGridBottomRow.Height = new GridLength((int)(signUpGrid.ActualHeight * 11.90 / 100), GridUnitType.Pixel);


            signUpGrid.Width = (int)(ScreenWorkArea.Width * 26.09 / 100);

            signUpGridLeftColumn.Width = new GridLength((int)(signUpGrid.ActualWidth * 7.39 / 100), GridUnitType.Pixel);
            signUpGridRightColumn.Width = new GridLength((int)(signUpGrid.ActualWidth * 11.98 / 100), GridUnitType.Pixel);


            minimizeButton.Height = (int)(signUpGrid.ActualHeight * 4.8 / 100);
            minimizeButton.Width = minimizeButton.Height;

            closeButton.Height = (int)(signUpGrid.ActualHeight * 4.8 / 100);
            closeButton.Width = minimizeButton.Height;


            Resources["authnHeaderTextFontSize"] = (double)(signUpGrid.ActualHeight * 9.6 / 100);

            Resources["authnMainTextFontSize"] = (double)(signUpGrid.ActualHeight * 4.8 / 100);
            Resources["authnButtonFontSize"] = (double)(signUpGrid.ActualHeight * 4.8 / 100);


            if (DataContext is ICloseable viewModel)
            {
                viewModel.Close += () =>
                {
                    Close();
                };
            }
        }


        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
    }
}
