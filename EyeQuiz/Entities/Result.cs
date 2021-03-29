using System.Collections.Generic;
using EyeQuiz.Enums;

namespace EyeQuiz.Entities
{
    public class Result
    {
        public Dictionary<AnswerStatus, int> Results { get; set; }

        public Result()
        {
            Results = new Dictionary<AnswerStatus, int>()
            {
                {AnswerStatus.CorrectAnswer, 0},
                {AnswerStatus.IncorrectAnswer, 0},
                {AnswerStatus.NotSure, 0},
                {AnswerStatus.NotAnswered, 0},
            };
        }
    }
}