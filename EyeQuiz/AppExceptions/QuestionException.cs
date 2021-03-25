using System;

namespace EyeQuiz.AppExceptions
{
    public class QuestionException:ApplicationException
    {
        public QuestionException()
        {
            
        }

        public QuestionException(string message):base(message)
        {
            
        }
    }
}