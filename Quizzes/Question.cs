using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Sources;

namespace Quizzes
{
    public abstract class Question

    {
        //public string questionType { get; set; }
        public string strQuestion { get; set; }

        public Dictionary<int,string> answerOptions { get; set; }

        public List<int> correctAnswers { get; set; }
        
        public double credit { get; set; }

        public double score { get; set; } = 0;

        public Question (string strQuestion, Dictionary<int, string> answerOptions, 
                         List<int> correctAnswers, double credit)
        {
            //this.questionType = questionType;
            this.strQuestion = strQuestion;
            this.answerOptions = answerOptions;
            this.correctAnswers = correctAnswers;
            this.credit = credit;
        }

        //public abstract void AnswerQuestion();

        public bool IsCorrect(string userAnswer)
        {
            List<string> userAnswerList = userAnswer.Split(",").ToList();
            foreach (string i in userAnswerList)
            {
                int numI = int.Parse(i);
                if (correctAnswers.IndexOf(numI)<0)
                {
                    return false;
                }
            }
            return true;
        }

        public void AnswerQuestion()
        {
            Console.WriteLine(strQuestion);

            foreach (KeyValuePair<int, string> answer in answerOptions)
            {
                Console.WriteLine(answer.Key + " - " + answer.Value);
            }

            // String[] userInput = Console.ReadLine().Split(",");
            //List<int> userAnswer = Array.ConvertAll(userInput, str => int.Parse(str)).ToList();

            string userAnswer = Console.ReadLine();

            if (IsCorrect(userAnswer))
            {
                score = credit;
            }
        }

    }

}
