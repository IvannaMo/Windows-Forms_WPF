using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string CivilStatus { get; set; }
        public string AdInfo { get; set; }


        public Person() { }

        public Person(string surname, string name, string patronymic, string gender, DateTime birthDate, string civilStatus, string adInfo) 
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Gender = gender;
            BirthDate = birthDate;
            CivilStatus = civilStatus;
            AdInfo = adInfo;
        }
    }
}
