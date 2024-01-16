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


        public ServerViewModel()
        {
            UsersList = new List<User>();
            Message = "start server\r\n";

            WaitClientQuery();
        }


        public async void WaitClientQuery()
        {
            await Task.Run(() =>
            {
                _ip = "127.0.0.1";
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
                while (true)
                {
                    Socket listener = _tcpSocket.Accept();


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

                        string username = commandInfo[2];
                        username = Regex.Replace(username, "<space>", " ");


                        User user = UsersList.Where(user => user.Id == id && user.Username == username).First();
                        UsersList.Remove(user);

                        serverAnswer = "confirm";
                        Message += "logout " + user.ToString() + "\r\n";
                    }
                    else if ((commandInfo[0] == "getUsers"))
                    {
                        int id = Convert.ToInt32(commandInfo[1]);

                        string username = commandInfo[2];
                        username = Regex.Replace(username, "<space>", " ");

                        string bio = commandInfo[3];
                        bio = Regex.Replace(bio, "<space>", " ");


                        User user = new User(id, username, bio);


                        List<User> tempUsers = new List<User>();
                        foreach(User tempUser in UsersList)
                        {
                            tempUsers.Add(tempUser);
                        }
                        serverAnswer = System.Text.Json.JsonSerializer.Serialize(tempUsers);
                        Message += "sendUsers " + user.ToString() + "\r\n";
                    }
                    else if ((commandInfo[0] == "stream"))
                    {
                        int id = Convert.ToInt32(commandInfo[1]);

                        string username = commandInfo[2];
                        username = Regex.Replace(username, "<space>", " ");

                        string bio = commandInfo[3];
                        bio = Regex.Replace(bio, "<space>", " ");


                        //_stream = Array.Empty<byte>();
                        //_stream = commandInfo[1];

                        serverAnswer = "confirm";
                    }



                    listener.Send(Encoding.UTF8.GetBytes(serverAnswer));


                    listener.Shutdown(SocketShutdown.Both);
                    listener.Close();
                }
            });
        }
    }
}
