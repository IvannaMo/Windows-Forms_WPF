using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    interface IView
    {
        string FormTitle { get; set; }
        string InputPassword { get; set; }


        event EventHandler<EventArgs> CEvent;
        event EventHandler<EventArgs> OkEvent;
    }
}
