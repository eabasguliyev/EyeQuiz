using System.Collections.Generic;

namespace EyeQuiz.Entities
{
    public class QuestionsBlock
    {
        public string FileName { get; set; }
        public List<QuestionBlock> Questions { get; set; }

        public QuestionsBlock()
        {
            Questions = new List<QuestionBlock>();
        }
    }
}