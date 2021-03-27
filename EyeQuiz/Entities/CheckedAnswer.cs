using System;
using EyeQuiz.Enums;

namespace EyeQuiz.Entities
{
    public class CheckedAnswer
    {
        public AnswerStatus AnswerStatus { get; set; }
        public Guid AnswerId { get; set; }
    }
}