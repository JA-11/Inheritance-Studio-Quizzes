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
        public int Points { get; set; }

        public Question(string questionText, int points)
        {
            QuestionText = questionText;
            Points = points;
        }

        public abstract void DisplayPossibleAnswers();

        public abstract int GetUserAnswer();

    }
}
