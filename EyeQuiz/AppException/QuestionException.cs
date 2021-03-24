using System;

namespace EyeQuiz.AppException
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