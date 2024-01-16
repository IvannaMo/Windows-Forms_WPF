using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CV.Models
{
    internal class CVPersonInfo
    {
        public string FullName { get; set; }
        public string Age { get; set; }
        public string MaritalStatus { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public bool Engish { get; set; }
        public bool CPlusPlus { get; set; }
        public bool CSharp { get; set; }
        public bool JavaScript { get; set; }


        public CVPersonInfo() { }

        public CVPersonInfo(string fullname, string age, string maritalStatus, string address, string email, bool english, bool cPlusPlus, bool cSharp, bool javaScript)
        {
            FullName = fullname;
            Age = age;
            MaritalStatus = maritalStatus;
            Address = address;
            Email = email;

            Engish = english;
            CPlusPlus = cPlusPlus;
            CSharp = cSharp;
            JavaScript = javaScript;
        }


        public override string ToString()
        {
            return FullName;
        }
    }
}
