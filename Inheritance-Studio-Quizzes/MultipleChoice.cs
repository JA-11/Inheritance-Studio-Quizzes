using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Studio_Quizzes
{
    public class MultipleChoice : Question
    {
        public int CorrectAnswer { get; set; }


        public MultipleChoice(string questionText, List<string> possibleAnswers, int correctAnswer) : base(questionText, possibleAnswers)
        {
            CorrectAnswer = correctAnswer;
        }
    }
}
