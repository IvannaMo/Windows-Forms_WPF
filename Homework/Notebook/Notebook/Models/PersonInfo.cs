using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    class PersonInfo
    {
        private string FullName { get; set; }
        private string Address { get; set; }
        private string PhoneNumber { get; set; }


        public PersonInfo() 
        {
            FullName = "";
            Address = "";
            PhoneNumber = "";
        }

        public PersonInfo(string fullName, string address, string phoneNumber)
        {
            FullName = fullName;
            Address = address;
            PhoneNumber = phoneNumber;
        }


        public override string ToString()
        {
            return "Full name: " + FullName + ' ' + "Address: " + Address + ' ' + "Phone number: " + PhoneNumber;
        }
    }
}
