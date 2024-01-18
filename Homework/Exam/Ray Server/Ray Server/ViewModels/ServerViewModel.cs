using Newtonsoft.Json;
using Ray_Server.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Ray_Server.ViewModels
{
    class ServerViewModel : ViewModelBase
    {
        private string _ip;
        private int _port;
        private Socket _tcpSocket;


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


        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }


        private byte[] _stream;
        private User _streamUser;


        public ServerViewModel()
        {
            UsersList = new List<User>();
            Message = "start server\r\n";

            _stream = null;
            _streamUser = null;

            WaitClientQuery();
        }


        public async void WaitClientQuery()
        {
            await Task.Run(() =>
            {
                _ip = "192.168.0.201";
                //_ip = "192.168.0.63";
                _port = 7007;

                EndPoint endPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);

                _tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _tcpSocket.Bind(endPoint);
                _tcpSocket.Listen(100);


                StartMessageLoop();
            });
        }


        public async void StartMessageLoop()
        {
            await Task.Run(() =>
            {
                Socket listener;


                while (true)
                {
                    listener = _tcpSocket.Accept();


                    byte[] buffer = new byte[1024];
                    int size = 0;
                    StringBuilder data = new StringBuilder();
                    do
                    {
                        size = listener.Receive(buffer);
                        data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                    } while (listener.Available > 0);


                    string serverAnswer = "reject";
                    string[] commandInfo = data.ToString().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    if ((commandInfo[0] == "register") || (commandInfo[0] == "login"))
                    {
                        int id = Convert.ToInt32(commandInfo[1]);

                        string username = commandInfo[2];
                        username = Regex.Replace(username, "<space>", " ");

                        string bio = commandInfo[3];
                        bio = Regex.Replace(bio, "<space>", " ");


                        User user = new User(id, username, bio);
                        UsersList.Add(user);

                        serverAnswer = "confirm";
                        Message += $"{commandInfo[0]} " + user.ToString() + "\r\n";
                    }
                    else if ((commandInfo[0] == "logout"))
                    {
                        int id = Convert.ToInt32(commandInfo[1]);

                        User user = UsersList.Where(user => user.Id == id).First();
                        UsersList.Remove(user);

                        serverAnswer = "confirm";
                        Message += "logout " + user.ToString() + "\r\n";
                    }
                    else if ((commandInfo[0] == "getUsers"))
                    {
                        int id = Convert.ToInt32(commandInfo[1]);

                        serverAnswer = System.Text.Json.JsonSerializer.Serialize(UsersList);
                    }
                    else if ((commandInfo[0] == "stream"))
                    {
                        try
                        {
                            int id = Convert.ToInt32(commandInfo[1]);
                            if (_streamUser == null)
                            {
                                _streamUser = UsersList.Where(user => user.Id == id).First();
                                Message += "startStream " + _streamUser.ToString() + "\r\n";
                            }

                            byte[] _streamCheck = Convert.FromBase64String(commandInfo[2]);
                            _stream = _streamCheck;


                            //using (MemoryStream memory = new MemoryStream(_stream))
                            //{
                            //    BitmapImage bitmapImage = new BitmapImage();
                            //    bitmapImage.BeginInit();
                            //    bitmapImage.StreamSource = memory;
                            //    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                            //    bitmapImage.EndInit();


                            //    BitmapEncoder encoder = new PngBitmapEncoder();
                            //    encoder.Frames.Add(BitmapFrame.Create(bitmapImage));

                            //    using (var fileStream = new FileStream("Test.bmp", System.IO.FileMode.Create))
                            //    {
                            //        encoder.Save(fileStream);
                            //    }
                            //}
                            

                            serverAnswer = "confirm";
                        }
                        catch (Exception ex)
                        {
                            //Message += "error " + ex.ToString() + "\r\n";
                        }
                    }
                    else if ((commandInfo[0] == "stopStream"))
                    {
                        Message += "stopStream " + _streamUser.ToString() + "\r\n";

                        _stream = null;
                        _streamUser = null;

                        serverAnswer = "confirm";
                    }
                    else if ((commandInfo[0] == "getStream"))
                    {
                        if (_stream != null)
                        {
                            serverAnswer = Convert.ToBase64String(_stream);
                        }
                        else
                        {
                            serverAnswer = "null";
                        }
                    }


                    listener.Send(Encoding.UTF8.GetBytes(serverAnswer));
                }


                //listener.Shutdown(SocketShutdown.Both);
                //listener.Close();
            });
        }
    }
}
