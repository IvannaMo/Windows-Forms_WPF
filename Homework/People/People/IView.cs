using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public interface IView
    {
        string PersonName { get; set; }
        int PersonAge { get; set; }
        string PeopleInfo { get;  set; }
        string PersonSearchName { get; set; }


        event EventHandler<EventArgs> SaveEvent;
        event EventHandler<EventArgs> ShowAllEvent;
        event EventHandler<EventArgs> SearchEvent;
    }
}
