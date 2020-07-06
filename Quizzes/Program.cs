using System;
using System.Collections.Generic;

namespace Quizzes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Quiz newQuiz = new Quiz();

            Question q1 = new TrueOrFalse("A function can return more than one value.", 2, 5);

            Dictionary<int, string> q2Answers = new Dictionary<int, string>();
            q2Answers.Add(1, "1");
            q2Answers.Add(2, "2");
            q2Answers.Add(3, "3");
            Question q2 = new MultipleChoice("How many units will be covered in codecamp program?", q2Answers, 2, 7);

            Dictionary<int, string> q3Answers = new Dictionary<int, string>();
            q3Answers.Add(1, "Java");
            q3Answers.Add(2, "JavaScript");
            q3Answers.Add(3, "Ruby");
            q3Answers.Add(4, "C#");

            List<int> q3CorrectAnswer = new List<int> { 2, 4 };

            Question q3 = new CheckBox("Which languages will be covered in codecamp program? Select all.", q3Answers, q3CorrectAnswer, 9);
            
            newQuiz.questionList.Add(q1);

            newQuiz.questionList.Add(q2);

            newQuiz.questionList.Add(q3);
            
            newQuiz.TakeQuiz();
        }
    }
}
