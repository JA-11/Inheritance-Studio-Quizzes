using System;

namespace Inheritance_Studio_Quizzes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Multiple Choice Quiz Test
            List<string> answerOptions = new List<string> { "red", "yellow", "blue", "green" };  //look into changing display to make all in one line

            MultipleChoice test = new MultipleChoice("What color is corn?", 2, answerOptions, 1);
            MultipleChoice testTwo = new MultipleChoice("What color is the sky?", 3, answerOptions, 1);
            MultipleChoice testThree = new MultipleChoice("What color is Lightning McQueen?", 1, answerOptions, 1);
            MultipleChoice testFour = new MultipleChoice("What color is grass?", 4, answerOptions, 1);

            /*Quiz testQuiz = new Quiz(new List<Question>());
            testQuiz.AddQuestion(test);
            testQuiz.AddQuestion(testTwo);
            testQuiz.AddQuestion(testThree);
            testQuiz.AddQuestion(testFour);

            testQuiz.RunQuiz();
            testQuiz.GradeQuiz();*/


            //TrueFalse Quiz Test
            TrueFalse testTF = new TrueFalse("True or False: Football is back.", 1, 1);
            TrueFalse testTFTwo = new TrueFalse("True or False: Cats are the best pets.", 2, 1);
            TrueFalse testTFThree = new TrueFalse("True or False: Concerts are super fun.", 1, 1);

            /*Quiz testTFQuiz = new Quiz(new List<Question>());
            testTFQuiz.AddQuestion(testTF);
            testTFQuiz.AddQuestion(testTFTwo);
            testTFQuiz.AddQuestion(testTFThree);

            testTFQuiz.RunQuiz();
            testTFQuiz.GradeQuiz();*/


            //Checkbox Quiz Test
            List<string> answerChoices = new List<string> { "basketball", "baseball", "hockey", "soccer", "football", "tennis" };
            List<int> correctAnswers1 = new List<int> { 6 };
            List<int> correctAnswers2 = new List<int> { 1, 2, 4, 6 };
            List<int> correctAnswers3 = new List<int> { 1, 3 };

            Checkbox testCheckboxOne = new Checkbox("What sports are played individually?", correctAnswers1, answerChoices, 1);
            Checkbox testCheckboxTwo = new Checkbox("What sports use a round ball?", correctAnswers2, answerChoices, 1);
            Checkbox testCheckboxThree = new Checkbox("What sports are played inside?", correctAnswers3, answerChoices, 1);

            /*Quiz testCheckboxQuiz = new Quiz(new List<Question>());
            testCheckboxQuiz.AddQuestion(testCheckboxOne);
            testCheckboxQuiz.AddQuestion(testCheckboxTwo);
            testCheckboxQuiz.AddQuestion(testCheckboxThree);

            testCheckboxQuiz.RunQuiz();
            testCheckboxQuiz.GradeQuiz();*/


            Quiz finalQuiz = new Quiz(new List<Question>());
            finalQuiz.AddQuestion(test);
            finalQuiz.AddQuestion(testTFThree);
            finalQuiz.AddQuestion(testCheckboxTwo);
            finalQuiz.AddQuestion(testFour);
            finalQuiz.AddQuestion(testTFTwo);
            finalQuiz.AddQuestion(testCheckboxThree);

            finalQuiz.RunQuiz();
            finalQuiz.GradeQuiz();

        }
    }
}
