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
using System.Net.Sockets;
using System.Net;
using System.Data;
using Ray_Server.Models;
using Ray_Server.ViewModels;

namespace Ray_Server
{
    public partial class ServerWindow : Window
    {
        public ServerWindow()
        {
            InitializeComponent();

            ServerViewModel serverViewModel = new ServerViewModel();
            DataContext = serverViewModel;
        }
    }
}
