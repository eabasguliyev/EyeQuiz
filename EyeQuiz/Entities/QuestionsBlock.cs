using System;
using System.Collections.Generic;

namespace EyeQuiz.Entities
{
    public class QuestionsBlock
    {
        public Guid OwnerId { get; set; }
        public string FileName { get; set; }
        public List<QuestionBlock> Questions { get; set; }

        public QuestionsBlock()
        {
            Questions = new List<QuestionBlock>();
        }
    }
}