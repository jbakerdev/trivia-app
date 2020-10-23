using System;
using System.Threading.Tasks;

namespace TriviaApp
{
    class Program
    {
        private static async Task Main()
        {
            Console.WriteLine("JB's Trivia App");
            Console.WriteLine("");
            Console.WriteLine("Press <enter> to begin...");
            Console.WriteLine("");
            Console.ReadLine();

            var exit = "";
            
            do
            {
                var question = await TriviaGame.GetQuestionAsync();

                // Ask question
                Console.WriteLine($"Category: {question.Category}");
                Console.WriteLine($"Difficulty: {question.Difficulty}");
                Console.WriteLine("And the question is...");
                Console.WriteLine("");
                Console.WriteLine(System.Text.RegularExpressions.Regex.Unescape(question.Text));
                Console.WriteLine("");

                // Get answer
                Console.WriteLine("Your answer?");
                Console.WriteLine("");
                var answer = Console.ReadLine();
                Console.WriteLine("");

                // Check answer
                if (answer == question.CorrectAnswer)
                {
                    Console.WriteLine("Congratulations! You win!");
                }
                else
                {
                    Console.WriteLine("Oh, I'm sorry... that's incorrect. The answer we were looking for was:");
                    Console.WriteLine(question.CorrectAnswer);
                }
                Console.WriteLine("");

                // Play again?
                Console.WriteLine("Thanks for playing JB's Trivia App!");
                Console.WriteLine("Play again? (y/N)");
                exit = Console.ReadLine();
            }
            while (exit == "y" || exit == "Y");
        }
    }
}
