using System;
using System.Collections.Generic;

namespace EyeQuiz.Entities
{
    public class CheckedAnswer
    {
        public AnswerStatus AnswerStatus { get; set; }
        public Guid AnswerId { get; set; }
    }
    public class ResultQuestionBlock
    {
        public Guid QuestionId { get; set; }

        public Guid CorrectAnswerId { get; set; }
        public CheckedAnswer Answer { get; set; }
    }

    public enum AnswerStatus
    {
        CorrectAnswer,
        IncorrectAnswer,
        NotAnswered,
    }
}