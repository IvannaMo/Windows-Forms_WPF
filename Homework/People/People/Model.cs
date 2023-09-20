using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace People
{
    internal class Model : IModel
    {
        public Person PersonObj { get; set; }
        public List<Person> PeopleList { get; set; }


        public Model() 
        {
            PeopleList = new List<Person>();


            if (!File.Exists("../../Data.xml"))
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter("../../Data.xml", Encoding.UTF8);
                xmlTextWriter.WriteStartDocument();

                xmlTextWriter.Formatting = Formatting.Indented;
                xmlTextWriter.IndentChar = '\t';
                xmlTextWriter.Indentation = 1;

                xmlTextWriter.WriteStartElement("people");
                xmlTextWriter.WriteEndElement();

                xmlTextWriter.Close();
            }
        }


        public void Save()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../Data.xml");

            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement personElem = xDoc.CreateElement("person");

            XmlElement nameElem = xDoc.CreateElement("name");
            nameElem.AppendChild(xDoc.CreateTextNode(PersonObj.Name));

            XmlElement ageElem = xDoc.CreateElement("age");
            ageElem.AppendChild(xDoc.CreateTextNode(PersonObj.Age.ToString()));

            personElem.AppendChild(nameElem);
            personElem.AppendChild(ageElem);
            xRoot.AppendChild(personElem);

            xDoc.Save("../../Data.xml");
        }


        public void ShowAll()
        {
            PeopleList.Clear();


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../Data.xml");

            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                Person person = new Person();

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        person.Name = childnode.InnerText;
                    }
                    if (childnode.Name == "age")
                    {
                        person.Age = Convert.ToInt32(childnode.InnerText);
                    }
                }

                PeopleList.Add(person);
            }
        }


        public void Search()
        {
            PeopleList.Clear();


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../Data.xml");

            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                Person person = new Person();

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        person.Name = childnode.InnerText;
                    }
                    if (childnode.Name == "age")
                    {
                        person.Age = Convert.ToInt32(childnode.InnerText);
                    }
                }

                if (person.Name == PersonObj.Name)
                {
                    PeopleList.Add(person);
                }
            }
        }
    }
}
