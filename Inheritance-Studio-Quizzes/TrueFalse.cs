using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Studio_Quizzes
{
    public class TrueFalse : Question
    {
        public int CorrectAnswer { get; set; }

        public TrueFalse(string questionText, int correctAnswer, int points) : base(questionText, points)
        {
            CorrectAnswer = correctAnswer;
            Points = 1;
        }

        public override void DisplayPossibleAnswers()
        {
        }

        public bool CheckUserAnswer(int userAnswer)
        {
            if (userAnswer == CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetUserAnswer()
        {
            Console.Write("\nPlease enter 1 for True and 2 for False: ");
            string userInput = Console.ReadLine();
            int answerNumber = int.Parse(userInput);

            if (CheckUserAnswer(answerNumber) == true)
            {
                Console.WriteLine("Correct!\n");
                return 1;
            }
            else
            {
                Console.WriteLine("Sorry, that is incorrect.\n");
                return 0;
            }
        }

    }
}
