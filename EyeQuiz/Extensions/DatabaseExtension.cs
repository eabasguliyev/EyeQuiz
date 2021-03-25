using System.Linq;
using EyeQuiz.AppExceptions;
using EyeQuiz.Entities;

namespace EyeQuiz.Extensions
{
    public static class DatabaseExtension
    {
        public static User Login(this Database db, string email, string password)
        {
            var user = db.Users.SingleOrDefault(u => u.Email == email);

            if (user == null)
                throw new UserNotFoundException($"There is no user associated this email: {email}");


            if (user.Password != password)
                throw new PasswordWrongException("Password is wrong!");

            return user;
        }

        public static void Register(this Database db, User user)
        {
            db.Users.Add(user);
        }
    }

}