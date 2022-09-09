using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Studio_Quizzes
{
    public abstract class Question
    {
        public string QuestionText { get; set; }

        public List<string> PossibleAnswers { get; set; }

        public Question(string questionText, List<string> possibleAnswers)
        {
            QuestionText = questionText;
            PossibleAnswers = possibleAnswers;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(QuestionText);
        }

    }
}
