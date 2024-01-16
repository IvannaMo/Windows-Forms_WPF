using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }


        public User() { }

        public User(string username, string password) 
        {
            Id = (new Random()).Next(1000, 9999); ;
            Username = username;
            Bio = "Just a cat";
            Password = password;
        }

        public User(int id, string username, string bio)
        {
            Id = id;
            Username = username;
            Bio = bio;
        }
    }
}