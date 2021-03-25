using System.Collections.Generic;
using EyeQuiz.Entities;
using Newtonsoft.Json;

namespace EyeQuiz
{
    public class Database
    {
        [JsonIgnore]
        public bool Changes { get; set; }
        public List<User> Users { get; set; }

        public Database()
        {
            Users = new List<User>();
        }
    }
}