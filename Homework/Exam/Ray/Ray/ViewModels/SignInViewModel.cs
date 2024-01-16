using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Newtonsoft.Json;
using Ray.Commands;
using Ray.Models;
using Ray.Views;
using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Drawing;
using User = Ray.Models.User;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace Ray.ViewModels
{
    class SignInViewModel : ViewModelBase
    {
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand CloseWindowCommand { get; set; }
        public ICommand RedirectToSignUpCommand { get; set; }
        public ICommand SignInCommand { get; set; }


        private string _username;
        private string _password;


        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                ((RelayCommand)SignInCommand).RaiseCanExecuteChanged();
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                ((RelayCommand)SignInCommand).RaiseCanExecuteChanged();
                OnPropertyChanged(nameof(Password));
            }
        }


        private List<User> _usersList;

        public List<User> UsersList
        {
            get
            {
                return _usersList;
            }
            set
            {
                _usersList = value;
                OnPropertyChanged(nameof(UsersList));
            }
        }


        public SignInViewModel()
        {
            MinimizeWindowCommand = new RelayCommand(MinimizeWindow, CanMinimizeWindow);
            CloseWindowCommand = new RelayCommand(CloseWindow, CanCloseWindow);

            RedirectToSignUpCommand = new RelayCommand(RedirectToSignUp, CanRedirectToSignUp);

            SignInCommand = new RelayCommand(RedirectToMainApp, CanRedirectToMainApp);


            UsersList = new List<User>();
        }


        private bool CanMinimizeWindow(object obj)
        {
            return true;
        }

        private void MinimizeWindow(object obj)
        {
            CurrentWindowState = WindowState.Minimized;
        }


        private bool CanCloseWindow(object obj)
        {
            return true;
        }

        private void CloseWindow(object obj)
        {
            Close?.Invoke();
        }


        private bool CanRedirectToSignUp(object obj)
        {
            return true;
        }

        private void RedirectToSignUp(object obj)
        {
            Window mainWindow = obj as Window;

            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.Owner = mainWindow;
            signUpWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            signUpWindow.Show();
            Close?.Invoke();
        }


        private bool CanRedirectToMainApp(object obj)
        {
            if (!string.IsNullOrEmpty(_username) && !string.IsNullOrEmpty(_password))
            {
                return true;
            }

            return false;
        }

        private void RedirectToMainApp(object obj)
        {
            User signInUser = null;

            string fileName = "UserAccounts.Json";
            FileInfo fileInfo = new FileInfo(fileName);
            if (File.Exists(fileName) && (fileInfo.Length != 0))
            {
                UsersList = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(fileName));
                IEnumerable<User> findSignInUser = UsersList.Where(user => user.Username == _username && user.Password == Password);
                if (findSignInUser.Any())
                {
                    signInUser = findSignInUser.First();
                }
            }


            if (signInUser != null)
            {
                MessageBox.Show("You have successfully signed in!");


                bool answer = false;

                const string ip = "127.0.0.1";
                const int port = 7007;


                EndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);

                Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


                string usernameEdit = signInUser.Username;
                usernameEdit = Regex.Replace(usernameEdit, " ", "<space>");

                string bioEdit = signInUser.Bio;
                bioEdit = Regex.Replace(bioEdit, " ", "<space>");

                string message = $"login {signInUser.Id} {usernameEdit} {bioEdit}";
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
                    Window mainWindow = obj as Window;

                    MainAppWindow mainAppWindow = new MainAppWindow(signInUser);
                    mainAppWindow.Owner = mainWindow;
                    mainAppWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;

                    mainAppWindow.Show();
                    Close?.Invoke();
                }
            }
            else
            {
                MessageBox.Show("User not found!");
            }
        }
    }
}
