using Microsoft.VisualBasic.ApplicationServices;
using Ray.Commands;
using Ray.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using User = Ray.Models.User;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Ray.ViewModels
{
    internal class MainAppViewModel : ViewModelBase
    {
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand CloseWindowCommand { get; set; }


        private User _myUser;


        private int _id;
        private string _username;
        private string _bio;


        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Bio
        {
            get
            {
                return _bio;
            }
            set
            {
                _bio = value;
                OnPropertyChanged(nameof(Bio));
            }
        }


        public MainAppViewModel(User user) 
        {
            MinimizeWindowCommand = new RelayCommand(MinimizeWindow, CanMinimizeWindow);
            CloseWindowCommand = new RelayCommand(CloseWindow, CanCloseWindow);

            _myUser = user;

            Id = _myUser.Id;
            Username = _myUser.Username;
            Bio = _myUser.Bio;

            CurrentWindowState = WindowState.Maximized;
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
    }
}
