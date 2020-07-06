using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Sources;

namespace Quizzes
{
    class Quiz
    {
        public List<Question> questionList { get; set; } = new List<Question>();

        public void TakeQuiz()
        {
            double totalScore = 0;

            Console.WriteLine("******Quiz******\n");

            foreach (Question question in questionList)
            {
                question.AnswerQuestion();
                totalScore += question.score;
            }

            Console.WriteLine("Your score: " + totalScore);
        }
    }
}
