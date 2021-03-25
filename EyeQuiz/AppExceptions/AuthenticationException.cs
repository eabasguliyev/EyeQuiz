using System;

namespace EyeQuiz.AppExceptions
{
    public class AuthenticationException:ApplicationException
    {
        public AuthenticationException()
        {
            
        }

        public AuthenticationException(string message):base(message)
        {
            
        }
    }
}