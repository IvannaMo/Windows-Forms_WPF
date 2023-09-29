using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    class Model : IModel
    {
        private Random random;

        public int Password { get; set; }


        public Model() 
        { 
            random = new Random();

            Password = random.Next(11111111, 99999999);
        }


        public bool CheckPassword(string password)
        {
            return Password.ToString() == password;
        }
    }
}
