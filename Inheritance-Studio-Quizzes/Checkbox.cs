using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Studio_Quizzes
{
    public class Checkbox : Question
    {
        public List<int> CorrectAnswers { get; set; }

        public List<string> PossibleAnswers = new List<string>();


        public Checkbox(string questionText, List<int> correctAnswers, List<string> possibleAnswers, int points) : base(questionText, points)
        {
            CorrectAnswers = correctAnswers;
            PossibleAnswers = possibleAnswers;
            Points = 1;
        }

        public override void DisplayPossibleAnswers()
        {
            foreach (string possibleAnswer in PossibleAnswers)
            {
                Console.WriteLine(possibleAnswer);
            }
        }

        public bool CheckUserAnswer(List<int> userAnswers, List<int> correctAnswers)
        {
            bool isEqual = Enumerable.SequenceEqual(userAnswers.OrderBy(e => e), correctAnswers.OrderBy(e => e));  //ignores list order

            if (isEqual)
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
            List<int> userAnswers = new List<int>();
            string userInput;

            do
            {
                Console.Write("\nPlease enter the number that corresponds to one of the correct answers (If all answers have been submitted, please hit the enter key): ");
                userInput = Console.ReadLine();

                if (userInput != "")
                {
                    int answerNumber = int.Parse(userInput);
                    userAnswers.Add(answerNumber);
                }

            }
            while (!Equals(userInput, ""));



            if (CheckUserAnswer(userAnswers, CorrectAnswers) == true)
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
