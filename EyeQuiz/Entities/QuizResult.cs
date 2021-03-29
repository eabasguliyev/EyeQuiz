using System.Collections.Generic;
using System.Drawing;
using iText.Layout.Element;

namespace EyeQuiz.Entities
{
    public class QuizResult
    {
        public List<Bitmap> QuestionImages { get; set; }
        public Bitmap Result { get; set; }
        public Result result { get; set; }

        public QuizResult()
        {
            QuestionImages = new List<Bitmap>();
        }
    }
}