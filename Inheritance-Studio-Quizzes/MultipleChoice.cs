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

        public List<string> PossibleAnswers = new List<string>();


        public MultipleChoice(string questionText, int correctAnswer, List<string> possibleAnswers, int points) : base(questionText, points)
        {
            CorrectAnswer = correctAnswer;
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
            Console.Write("\nPlease enter the number that corresponds to the correct answer: ");
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
