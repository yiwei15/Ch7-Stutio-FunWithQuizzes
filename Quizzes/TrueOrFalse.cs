using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Quizzes
{
    public class TrueOrFalse : Question
    {
        //public Question(string strQuestion, List<Dictionary<int, string>> answerOptions,
        //         List<int> correctAnswers, double credit)
        //{
        //    this.strQuestion = strQuestion;
        //    this.answerOptions = answerOptions;
        //    this.correctAnswers = correctAnswers;
        //    this.credit = credit;
        //}

        public TrueOrFalse(string strQuestion, int correctAnswer, double credit) : base(strQuestion, null, new List<int> { correctAnswer }, credit)
        {
            this.answerOptions = new Dictionary<int, string>();
            this.answerOptions.Add(1, "true");
            this.answerOptions.Add(2, "false");
        }

    }
}
