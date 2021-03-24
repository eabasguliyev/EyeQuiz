using System.Collections.Generic;
using System.Xml.Serialization;
using EyeQuiz.Abstracts;

namespace EyeQuiz.Entities
{
    public class QuestionBlock:Id
    {
        [XmlElement]
        public string Text { get; set; }

        [XmlArray]
        public List<Answer> Answers { get; set; }

        public QuestionBlock()
        {
            Answers = new List<Answer>();
        }
    }
}