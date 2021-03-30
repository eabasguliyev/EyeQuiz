using System;
using System.Collections.Generic;

namespace EyeQuiz.Entities
{
    public class QuizRandomize
    {
        private Random _random { get; set; }

        public QuizRandomize()
        {
            _random = new Random();
        }
        public List<QuestionBlock> RandomizeQuestions(List<QuestionBlock> questions)
        {
            var randomQuestions = Randomize(questions);

            for (int i = 0; i < randomQuestions.Count; i++)
            {
                randomQuestions[i].Answers = Randomize(randomQuestions[i].Answers);
            }

            return randomQuestions;
        }

        private List<T> Randomize<T>(List<T> data)
        {
            var randomData = new List<T>();

            var uniqueIndexes = new List<int>();

            for (int i = 0; i < data.Count;)
            {
                var randomIndex = _random.Next(0, data.Count);

                if (!uniqueIndexes.Contains(randomIndex))
                {
                    uniqueIndexes.Add(randomIndex);

                    randomData.Add(data[randomIndex]);
                    i++;
                }
            }

            return randomData;
        }
        
    }
}