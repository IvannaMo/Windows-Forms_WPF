using Ray.ViewModels;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Application = System.Windows.Application;
using Point = System.Drawing.Point;


namespace Ray.Views
{
    public partial class IntroWindow : Window
    {
        private Rect ScreenWorkArea;


        public Rect GetCurrentScreenWorkArea(Window window)
        {
            Screen screen = Screen.FromPoint(new Point((int)window.Left, (int)window.Top));
            DpiScale dpiScale = VisualTreeHelper.GetDpi(window);

            return new Rect { Width = screen.WorkingArea.Width / dpiScale.DpiScaleX, Height = screen.WorkingArea.Height / dpiScale.DpiScaleY };
        }


        public IntroWindow()
        {
            InitializeComponent();

            Application.Current.MainWindow = this;
            ScreenWorkArea = GetCurrentScreenWorkArea(Application.Current.MainWindow);
        }


        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            logoImage.Width = (int)(ScreenWorkArea.Width * 28.7 / 100);
            logoImage.Height = (int)(ScreenWorkArea.Width * 551 / 314);

            CloseIntro();
        }


        public async void CloseIntro()
        {
            await Task.Delay(2500);

            SignInWindow signInWindow = new SignInWindow();
            signInWindow.Show();
            Close();
        }
    }
}
