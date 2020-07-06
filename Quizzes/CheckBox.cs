using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzes
{
    class CheckBox: Question
    {
        public CheckBox(string strQuestion, Dictionary<int, string> answerOptions, List<int> correctAnswers, double credit) : base(strQuestion, answerOptions, correctAnswers, credit)
        {
        }

    }
}
