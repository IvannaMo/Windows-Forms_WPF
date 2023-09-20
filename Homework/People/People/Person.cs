using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace People
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Person() { }

        public Person(string name)
        {
            this.Name = name;
            this.Age = 0;
        }

        public Person(string name, int age) 
        { 
            this.Name = name;
            this.Age = age;
        }


        public override string ToString()
        {
            return "Name: " + Name + "\r\n" + "Age: " + Age + "\r\n\r\n";
        }
    }
}
