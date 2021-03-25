namespace EyeQuiz.AppExceptions
{
    public class UserNotFoundException : AuthenticationException
    {
        public UserNotFoundException()
        {

        }

        public UserNotFoundException(string message) : base(message)
        {

        }
    }
}