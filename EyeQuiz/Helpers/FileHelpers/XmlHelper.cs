using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using EyeQuiz.Entities;
using EyeQuiz.UCUserAccess;

namespace EyeQuiz.Helpers.FileHelpers
{
    public static class XmlHelper
    {
        public static void Serialize(string filePath, QuestionsBlock questionsBlock)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));

            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, questionsBlock.Questions);
            }
        }

        public static void Deserialize(string filePath, QuestionsBlock questionsBlock)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));

            using (var fs = new FileStream(filePath, FileMode.Open))
            {
                questionsBlock.Questions = xmlSerializer.Deserialize(fs) as List<QuestionBlock>;
            }
        }
    }
}