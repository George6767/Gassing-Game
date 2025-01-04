using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gassing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the number guesssing game!");
            Console.WriteLine("A number between 1 and 10 willbe gerated.");
            Console.WriteLine("If you guess  the correct number, you win!");

            Console.WriteLine(randomNum);

            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess.");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is to hig.");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Congratualations, you have won the game!");

            Console.ReadKey(true);

        }
    }
}
