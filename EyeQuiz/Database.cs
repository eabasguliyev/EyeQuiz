using System.Collections.Generic;
using EyeQuiz.Entities;

namespace EyeQuiz
{
    public class Database
    {
        public List<User> Users { get; set; }


        public Database()
        {
            Users = new List<User>();
        }
    }
}