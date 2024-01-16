using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
using Newtonsoft.Json;
using Ray.Models;
using Ray.ViewModels;
using System.Data.Common;
using System.Drawing.Design;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;
using Ray.Components;

using Application = System.Windows.Application;
using Brushes = System.Windows.Media.Brushes;
using MessageBox = System.Windows.MessageBox;
using Button = System.Windows.Controls.Button;
using Cursors = System.Windows.Input.Cursors;
using User = Ray.Models.User;
using Point = System.Drawing.Point;
using Microsoft.VisualBasic.Devices;


namespace Ray.Views
{
    public partial class MainAppWindow : Window
    {
        private User myUser;

        private const string _ip = "127.0.0.1";
        private const int _port = 7007;

        private bool _settingsOpen;
        private bool _fullScreenOn;
        private bool _isStreaming;


        private Rect ScreenWorkArea;

        public Rect GetCurrentScreenWorkArea(Window window)
        {
            Screen screen = Screen.FromPoint(new Point((int)window.Left, (int)window.Top));
            DpiScale dpiScale = VisualTreeHelper.GetDpi(window);

            return new Rect { Width = screen.WorkingArea.Width / dpiScale.DpiScaleX, Height = screen.WorkingArea.Height / dpiScale.DpiScaleY };
        }


        public MainAppWindow(User user)
        {
            InitializeComponent();

            MainAppViewModel mainAppViewModel = new MainAppViewModel(user);
            DataContext = mainAppViewModel;


            myUser = user;

            Application.Current.MainWindow = this;
            ScreenWorkArea = GetCurrentScreenWorkArea(Application.Current.MainWindow);

            _settingsOpen = false;
            _fullScreenOn = false;
            _isStreaming = false;


            GetUsers();
        }


        private async void CloseApp()
        {
            Application.Current.Dispatcher.Invoke(new Action(async () =>
            {
                bool answer = false;


                EndPoint endPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);

                Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


                string usernameEdit = myUser.Username;
                usernameEdit = Regex.Replace(usernameEdit, " ", "<space>");

                string bioEdit = myUser.Bio;
                bioEdit = Regex.Replace(bioEdit, " ", "<space>");

                string message = $"logout {myUser.Id} {usernameEdit}";
                byte[] data = Encoding.UTF8.GetBytes(message);


                tcpSocket.Connect(endPoint);
                tcpSocket.Send(data);


                byte[] buffer = new byte[1024];
                int size = 0;
                StringBuilder answerData = new StringBuilder();
                do
                {
                    size = tcpSocket.Receive(buffer);
                    answerData.Append(Encoding.UTF8.GetString(buffer, 0, size));
                } while (tcpSocket.Available > 0);

                if (answerData.ToString() == "confirm")
                {
                    answer = true;
                }


                tcpSocket.Shutdown(SocketShutdown.Both);
                tcpSocket.Close();


                if (answer)
                {
                    Close();
                }
            }));
        }


        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            mainAppHeader.Height = (int)(ScreenWorkArea.Height * 6.76 / 100);
            mainAppHeader.Width = Width;


            mainAppUserIcon.Width = (int)(mainAppHeader.Width * 2.4 / 100);
            mainAppUserIcon.Height = mainAppUserIcon.Width;

            minimizeButton.Height = (int)(mainAppHeader.Height * 35 / 100);
            minimizeButton.Width = minimizeButton.Height;

            closeButton.Height = (int)(mainAppHeader.Height * 35 / 100);
            closeButton.Width = minimizeButton.Height;


            mainAppSettingsGrid.Width = (int)(mainAppGrid.ActualWidth * 21.67 / 100);

            mainAppSettingsUserPhoto.Width = (int)(mainAppSettingsGrid.Width * 18.51 / 100);
            mainAppSettingsUserPhoto.Height = mainAppSettingsUserPhoto.Width;


            int mainAppUserColorWidth = (int)(mainAppSettingsGrid.Width * 7.93 / 100);

            mainAppUserRedColor.Width = mainAppUserColorWidth;
            mainAppUserRedColor.Height = mainAppUserRedColor.Width;
            mainAppUserRedColor.CornerRadius = new CornerRadius(mainAppUserRedColor.Height);

            mainAppUserOrangeColor.Width = mainAppUserColorWidth;
            mainAppUserOrangeColor.Height = mainAppUserOrangeColor.Width;
            mainAppUserOrangeColor.CornerRadius = new CornerRadius(mainAppUserOrangeColor.Height);

            mainAppUserYellowColor.Width = mainAppUserColorWidth;
            mainAppUserYellowColor.Height = mainAppUserYellowColor.Width;
            mainAppUserYellowColor.CornerRadius = new CornerRadius(mainAppUserYellowColor.Height);

            mainAppUserGreenColor.Width = mainAppUserColorWidth;
            mainAppUserGreenColor.Height = mainAppUserGreenColor.Width;
            mainAppUserGreenColor.CornerRadius = new CornerRadius(mainAppUserGreenColor.Height);

            mainAppUserCyanColor.Width = mainAppUserColorWidth;
            mainAppUserCyanColor.Height = mainAppUserCyanColor.Width;
            mainAppUserCyanColor.CornerRadius = new CornerRadius(mainAppUserCyanColor.Height);


            mainAppUserBlueColor.Width = mainAppUserColorWidth;
            mainAppUserBlueColor.Height = mainAppUserBlueColor.Width;
            mainAppUserBlueColor.CornerRadius = new CornerRadius(mainAppUserBlueColor.Height);

            mainAppUserVioletColor.Width = mainAppUserColorWidth;
            mainAppUserVioletColor.Height = mainAppUserVioletColor.Width;
            mainAppUserVioletColor.CornerRadius = new CornerRadius(mainAppUserVioletColor.Height);

            mainAppUserPinkColor.Width = mainAppUserColorWidth;
            mainAppUserPinkColor.Height = mainAppUserPinkColor.Width;
            mainAppUserPinkColor.CornerRadius = new CornerRadius(mainAppUserPinkColor.Height);

            mainAppUserBrownColor.Width = mainAppUserColorWidth;
            mainAppUserBrownColor.Height = mainAppUserBrownColor.Width;
            mainAppUserBrownColor.CornerRadius = new CornerRadius(mainAppUserBrownColor.Height);

            mainAppUserDefaultColor.Width = mainAppUserColorWidth;
            mainAppUserDefaultColor.Height = mainAppUserDefaultColor.Width;
            mainAppUserDefaultColor.CornerRadius = new CornerRadius(mainAppUserDefaultColor.Height);


            mainAppThemesToggle.Width = (int)(mainAppSettingsGrid.Width * 11.54 / 100);
            mainAppThemesToggle.Height = (int)(mainAppThemesToggle.Width * 1 / 2);


            mainAppScreenFrame.Width = (int)(mainAppGrid.ActualWidth * 66.22 / 100);
            mainAppScreenFrame.Height = (int)(mainAppScreenFrame.Width * 187 / 315);

            mainAppScreen.Width = (int)(mainAppGrid.ActualWidth * 61.37 / 100);
            mainAppScreen.Height = (int)(mainAppScreen.Width * 9 / 16);

            mainAppFullScreenIcon.Height = (int)(ScreenWorkArea.Height * 2.87 / 100);
            mainAppFullScreenIcon.Width = (int)(mainAppFullScreenIcon.Height * 39 / 31);


            mainAppBorderStreamContainer.Width = mainAppScreenFrame.Width;
            
            mainAppStreamerUser.Width = (int)(mainAppBorderStreamContainer.Width * 6.06 / 100);
            mainAppStreamerUser.Height = mainAppStreamerUser.Width;


            mainAppBorderUsersContainer.Width = mainAppScreenFrame.Width;

            mainAppUsersList.Width = mainAppUsersStackPanel.Width;


            //Resources["mainAppTitleTextFontSize"] = (double)(mainAppBorderMainContainer.ActualWidth * 9.6 / 100);
            //Resources["mainAppSubtitleTextFontSize"] = (double)(mainAppBorderMainContainer.ActualWidth * 9.6 / 100);


            if (DataContext is ICloseable viewModel)
            {
                viewModel.Close += () =>
                {
                    CloseApp();
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


        private void ChangeUsernameColor(object sender, MouseButtonEventArgs e)
        {
            Border usernameColor = sender as Border;


        }


        private void OpenCloseSettings(object sender, MouseButtonEventArgs e)
        {
            if (!_fullScreenOn)
            {
                if (!_settingsOpen)
                {
                    mainAppSettingsColumn.Width = new GridLength(0, GridUnitType.Auto);
                    _settingsOpen = true;
                }
                else
                {
                    mainAppSettingsColumn.Width = new GridLength(0, GridUnitType.Pixel);
                    _settingsOpen = false;
                }
            }
        }


        private void ChangeScreenMode()
        {
            if (!_fullScreenOn)
            {
                if (_settingsOpen)
                {
                    mainAppSettingsColumn.Width = new GridLength(0, GridUnitType.Pixel);
                }

                mainAppBorderStreamContainer.Visibility = Visibility.Hidden;

                mainAppScreenFrame.Margin = new Thickness(0, 30, 0, 0);
                mainAppScreenFrame.Width = (int)(mainAppGrid.ActualWidth * 82.34 / 100);
                mainAppScreenFrame.Height = (int)(mainAppScreenFrame.Width * 53 / 93);

                mainAppScreen.Width = double.NaN;
                mainAppScreen.Height = double.NaN;
                mainAppScreen.CornerRadius = new CornerRadius(0);
                mainAppScreen.BorderBrush = Application.Current.Resources["additional"] as SolidColorBrush;
                mainAppScreen.BorderThickness = new Thickness(14);

                mainAppScrollViewer.SetValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);
                _fullScreenOn = true;
            }
            else
            {
                if (_settingsOpen)
                {
                    mainAppSettingsColumn.Width = new GridLength(0, GridUnitType.Auto);
                }

                mainAppBorderStreamContainer.Visibility = Visibility.Visible;

                mainAppScreenFrame.Margin = new Thickness(0, 50, 0, 56);
                mainAppScreenFrame.Width = (int)(mainAppGrid.ActualWidth * 66.22 / 100);
                mainAppScreenFrame.Height = (int)(mainAppScreenFrame.Width * 187 / 315);

                mainAppScreen.Width = (int)(mainAppGrid.ActualWidth * 61.37 / 100);
                mainAppScreen.Height = (int)(mainAppScreen.Width * 9 / 16);
                mainAppScreen.CornerRadius = new CornerRadius(44);
                mainAppScreen.BorderBrush = Brushes.Transparent;
                mainAppScreen.BorderThickness = new Thickness(0);

                mainAppScrollViewer.SetValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Hidden);
                _fullScreenOn = false;
            }
        }

        private void OpenCloseFullscreen(object sender, MouseButtonEventArgs e)
        {
            ChangeScreenMode();
        }


        private void mainAppThemesToggleChecked(bool obj)
        {
            App app = (App)Application.Current;

            if (obj)
            {
                app.ChangeTheme(new Uri("ResourceDictionaries/LightTheme.xaml", UriKind.Relative));
            }
            else
            {
                app.ChangeTheme(new Uri("ResourceDictionaries/DarkTheme.xaml", UriKind.Relative));
            }
        }


        private async void GetUsers()
        {
            while (true)
            {
                await Task.Delay(1000);
                Application.Current.Dispatcher.Invoke(new Action(async () =>
                {
                    EndPoint endPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);

                    Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


                    string usernameEdit = myUser.Username;
                    usernameEdit = Regex.Replace(usernameEdit, " ", "<space>");

                    string bioEdit = myUser.Bio;
                    bioEdit = Regex.Replace(bioEdit, " ", "<space>");

                    string message = $"getUsers {myUser.Id} {usernameEdit} {bioEdit}";
                    byte[] data = Encoding.UTF8.GetBytes(message);


                    tcpSocket.Connect(endPoint);
                    tcpSocket.Send(data);


                    byte[] buffer = new byte[1024];
                    int size = 0;
                    StringBuilder answerData = new StringBuilder();
                    do
                    {
                        size = tcpSocket.Receive(buffer);
                        answerData.Append(Encoding.UTF8.GetString(buffer, 0, size));
                    } while (tcpSocket.Available > 0);

                    List<User> newUserList = JsonConvert.DeserializeObject<List<User>>(answerData.ToString());


                    int newUserListCount = newUserList.Count;


                    if (newUserList.Count == 1)
                    {
                        mainAppUsersCount.Text = $"{newUserList.Count} Cat are watching now:";
                    }
                    else
                    {
                        mainAppUsersCount.Text = $"{newUserList.Count} Cats are watching now:";
                    }


                    mainAppUsersList.Items.Clear();
                    foreach (User user in newUserList)
                    {
                        WrapPanel wrapPanel = new WrapPanel();
                        wrapPanel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                        wrapPanel.VerticalAlignment = VerticalAlignment.Center;
                        wrapPanel.Background = Brushes.Transparent;
                        wrapPanel.Cursor = Cursors.Hand;

                        UserIcon userIcon = new UserIcon();
                        userIcon.Style = (Style)FindResource("mainAppUserIcon");
                        userIcon.Source = new BitmapImage(new Uri("/Images/Default Photo.png", UriKind.Relative));
                        wrapPanel.Children.Add(userIcon);

                        StackPanel stackPanel = new StackPanel();
                        stackPanel.Margin = new Thickness(9, 0, 0, 0);
                        stackPanel.VerticalAlignment = VerticalAlignment.Center;

                        TextBlock textBlock = new TextBlock();
                        textBlock.Style = (Style)FindResource("mainAppText");
                        textBlock.Padding = new Thickness(0, 5, 0, 0);
                        textBlock.Text = user.Username;
                        stackPanel.Children.Add(textBlock);

                        wrapPanel.Children.Add(stackPanel);

                        mainAppUsersList.Items.Add(wrapPanel);
                    }
                    

                    tcpSocket.Shutdown(SocketShutdown.Both);
                    tcpSocket.Close();
                }));
            }
        }


        private async void Record()
        {
            while (_isStreaming)
            {
                await Task.Delay(50);
                Application.Current.Dispatcher.Invoke(new Action(async () =>
                {
                    using (Bitmap bitmap = new Bitmap((int)ScreenWorkArea.Width, (int)ScreenWorkArea.Height))
                    {
                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            graphics.CopyFromScreen((int)ScreenWorkArea.Left, (int)ScreenWorkArea.Top, 0, 0, bitmap.Size);

                            using (MemoryStream memory = new MemoryStream())
                            {
                                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                                memory.Position = 0;
                                BitmapImage bitmapImage = new BitmapImage();
                                bitmapImage.BeginInit();
                                bitmapImage.StreamSource = memory;
                                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                                bitmapImage.EndInit();

                                mainAppScreenImage.ImageSource = bitmapImage;

                                byte[] bytes = memory.ToArray();


                                bool answer = false;


                                EndPoint endPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);

                                Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


                                string usernameEdit = myUser.Username;
                                usernameEdit = Regex.Replace(usernameEdit, " ", "<space>");

                                string bioEdit = myUser.Bio;
                                bioEdit = Regex.Replace(bioEdit, " ", "<space>");

                                string message = $"stream {myUser.Id} {usernameEdit} {bioEdit}";
                                byte[] data = Encoding.UTF8.GetBytes(message);


                                tcpSocket.Connect(endPoint);
                                tcpSocket.Send(data);


                                byte[] buffer = new byte[1024];
                                int size = 0;
                                StringBuilder answerData = new StringBuilder();
                                do
                                {
                                    size = tcpSocket.Receive(buffer);
                                    answerData.Append(Encoding.UTF8.GetString(buffer, 0, size));
                                } while (tcpSocket.Available > 0);

                                if (answerData.ToString() == "confirm")
                                {
                                    answer = true;
                                }


                                tcpSocket.Shutdown(SocketShutdown.Both);
                                tcpSocket.Close();
                            }
                        }
                    }
                }));
            }

            mainAppScreenImage.ImageSource = null;
        }

        private void mainAppStreamButtonClick(object sender, RoutedEventArgs e)
        {
            if (!_isStreaming)
            {
                mainAppScreen.Background = Brushes.Transparent;
                mainAppScreenFrame.Style = (Style)FindResource("mainAppScreenFrame");
                mainAppScreenImageBorder.CornerRadius = new CornerRadius(44);

                mainAppStreamButton.Visibility = Visibility.Hidden;
                mainAppStopButtonWrapPanel.Visibility = Visibility.Visible;
                mainAppFullScreenIcon.Visibility = Visibility.Visible;

                _isStreaming = true;
                Record();
            }
            else
            {
                mainAppScreen.Background = Application.Current.Resources["screen"] as SolidColorBrush;
                mainAppScreenFrame.Style = (Style)FindResource("mainAppScreenClosedFrame");
                mainAppScreenImageBorder.CornerRadius = new CornerRadius(0);

                mainAppStreamButton.Visibility = Visibility.Visible;
                mainAppStopButtonWrapPanel.Visibility = Visibility.Hidden;
                mainAppFullScreenIcon.Visibility = Visibility.Hidden;

                _isStreaming = false;


                if (_fullScreenOn)
                {
                    ChangeScreenMode();
                }
            }
        }
    }
}
