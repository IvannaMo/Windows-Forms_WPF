using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Notebook.Models
{
    internal class Contact
    {
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }


        public Contact() { }

        public Contact(string? fullName, string? address, string? phoneNumber)
        {
            FullName = fullName;
            Address = address;
            PhoneNumber = phoneNumber;
        }


        public override string ToString()
        {
            return $"ФИО: {FullName}  Адрес: {Address}  Телефон: {PhoneNumber}";
        }
    }
}
