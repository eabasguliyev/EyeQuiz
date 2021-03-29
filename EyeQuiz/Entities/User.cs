using EyeQuiz.Abstracts;

namespace EyeQuiz.Entities
{
    public class User:Id
    {
        public bool FacebookUser { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}