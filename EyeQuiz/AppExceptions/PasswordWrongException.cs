namespace EyeQuiz.AppExceptions
{
    public class PasswordWrongException : AuthenticationException
    {
        public PasswordWrongException()
        {

        }

        public PasswordWrongException(string message) : base(message)
        {

        }
    }
}