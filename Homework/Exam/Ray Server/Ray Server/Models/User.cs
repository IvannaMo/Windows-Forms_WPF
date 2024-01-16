using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Server.Models
{
    class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }


        public User(int id, string username, string bio) 
        {
            Id = id;
            Username = username;
            Bio = bio;
        }


        public override string ToString()
        {
            return "User Id{" + Id + "} Username{" + Username + "} Bio{" + Bio + "}";
        }
    }
}
