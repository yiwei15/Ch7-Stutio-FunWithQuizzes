using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzes
{
    public class MultipleChoice: Question
    {
        //public Question(string strQuestion, List<Dictionary<int, string>> answerOptions,
        //         List<int> correctAnswers, double credit)
        //{
        //    this.strQuestion = strQuestion;
        //    this.answerOptions = answerOptions;
        //    this.correctAnswers = correctAnswers;
        //    this.credit = credit;
        //}

        public MultipleChoice(string strQuestion, Dictionary<int, string> answerOptions, int correctAnswer, double credit) : base(strQuestion, answerOptions, new List<int> { correctAnswer }, credit)
        {

        }

        public void AnswerQuestion()
        {
            Console.WriteLine(strQuestion);

            foreach (KeyValuePair<int, string> answer in answerOptions)
            {
                Console.WriteLine(answer.Key + " - " + answer.Value);
            }

            int userAnswer = int.Parse(Console.ReadLine());

            if (correctAnswers.Equals(userAnswer))
            {
                score = credit;
            }
        }




        //override ToString() to print out question
    }
}
