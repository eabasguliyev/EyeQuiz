using System.Xml.Serialization;
using EyeQuiz.Abstracts;

namespace EyeQuiz.Entities
{
    public class Answer:Id
    {
        [XmlAttribute]
        public string IsCorrect { get; set; }

        [XmlElement]
        public string Text { get; set; }
    }
}