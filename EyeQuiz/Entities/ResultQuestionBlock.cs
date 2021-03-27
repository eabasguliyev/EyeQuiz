using System;
using System.Collections.Generic;

namespace EyeQuiz.Entities
{
    public class ResultQuestionBlock
    {
        public Guid QuestionId { get; set; }

        public Guid CorrectAnswerId { get; set; }
        public CheckedAnswer Answer { get; set; }
    }
}