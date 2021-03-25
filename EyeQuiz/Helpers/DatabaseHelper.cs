using System.Linq;
using System.Runtime.CompilerServices;
using EyeQuiz.AppExceptions;
using EyeQuiz.Entities;

namespace EyeQuiz.Helpers
{
    public static class DatabaseHelper
    {
        public static bool CheckEmail(this Database db, string email)
        {
            var user = db.Users.SingleOrDefault(u => u.Email == email);

            return user == null;
        }
    }
}