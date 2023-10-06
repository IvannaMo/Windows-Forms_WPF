using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Gallery
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
