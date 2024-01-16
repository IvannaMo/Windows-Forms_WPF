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
using System.Drawing;
using Ray.ViewModels;
using Ray.Models;

using Application = System.Windows.Application;
using MessageBox = System.Windows.MessageBox;
using Point = System.Drawing.Point;


namespace Ray.Views
{
    public partial class SignInWindow : Window
    {
        private Rect ScreenWorkArea;


        public Rect GetCurrentScreenWorkArea(Window window)
        {
            Screen screen = Screen.FromPoint(new Point((int)window.Left, (int)window.Top));
            DpiScale dpiScale = VisualTreeHelper.GetDpi(window);

            return new Rect { Width = screen.WorkingArea.Width / dpiScale.DpiScaleX, Height = screen.WorkingArea.Height / dpiScale.DpiScaleY };
        }


        public SignInWindow()
        {
            InitializeComponent();

            SignInViewModel signInViewModel = new SignInViewModel();
            DataContext = signInViewModel;


            Application.Current.MainWindow = this;
            ScreenWorkArea = GetCurrentScreenWorkArea(Application.Current.MainWindow);
        }


        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            signInImage.Width = (int)(ScreenWorkArea.Width * 14.74 / 100);

            //windowBorderRow.Height = new GridLength((int)(signInGrid.ActualHeight * 10.44 / 100), GridUnitType.Pixel);
            //signInGridBottomRow.Height = new GridLength((int)(signInGrid.ActualHeight * 11.90 / 100), GridUnitType.Pixel);


            signInGrid.Width = (int)(ScreenWorkArea.Width * 26.09 / 100);

            signInGridLeftColumn.Width = new GridLength((int)(signInGrid.ActualWidth * 7.39 / 100), GridUnitType.Pixel);
            signInGridRightColumn.Width = new GridLength((int)(signInGrid.ActualWidth * 11.98 / 100), GridUnitType.Pixel);


            minimizeButton.Height = (int)(signInGrid.ActualHeight * 4.8 / 100);
            minimizeButton.Width = minimizeButton.Height;

            closeButton.Height = (int)(signInGrid.ActualHeight * 4.8 / 100);
            closeButton.Width = minimizeButton.Height;


            Resources["authnHeaderTextFontSize"] = (double)(signInGrid.ActualHeight * 9.6 / 100);

            Resources["authnMainTextFontSize"] = (double)(signInGrid.ActualHeight * 4.8 / 100);
            Resources["authnButtonFontSize"] = (double)(signInGrid.ActualHeight * 4.8 / 100);


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
