using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Studio_Quizzes
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public double Score { get; set; }
        public double InitialPoints { get; set; }

        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Score = 0;
            InitialPoints = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                InitialPoints += questions[i].Points;
            }
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
            InitialPoints += question.Points;
        }

        public void RunQuiz()
        {
            foreach (Question question in Questions)
            {
                Console.WriteLine(question.QuestionText);
                question.DisplayPossibleAnswers();
                //question.GetUserAnswer();

                if (question.GetUserAnswer() == 1)
                {
                    Score++;
                }

            }
        }

        public void GradeQuiz()
        {
            double quizScore = (Score / InitialPoints) * 100;

            Console.WriteLine($"You scored a {Math.Round(quizScore)}% on the quiz.");
        }

    }
}
