using System.Text.RegularExpressions;

namespace EyeQuiz.Helpers
{
    public static class UserHelper
    {
        public static bool ValidateFullname(string fullname)
        {
            return Regex.IsMatch(fullname, @"(?=^.{0,40}$)^[a-zA-Z-]+\s[a-zA-Z-]+$");
        }
        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }

        public static bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
        }
    }
}