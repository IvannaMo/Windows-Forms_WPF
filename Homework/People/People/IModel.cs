using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace People
{
    internal interface IModel
    {
        Person PersonObj { get; set; }

        [XmlElement("Person")]
        List<Person> PeopleList { get; set; }

        void Save();
        void ShowAll();
        void Search();
    }
}
