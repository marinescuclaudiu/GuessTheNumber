using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public static class Game
    {
        public static void Start()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 101);
            int inputNumber;
            bool successfullyParsed;

            Console.WriteLine("Try to guess the number!");

            do
            {
                Console.Write("Your number: ");
                successfullyParsed = int.TryParse(Console.ReadLine(), out inputNumber);

                if (successfullyParsed == false)
                {
                    Console.WriteLine("That is not an integer number, try again.");
                    continue;
                }

                if (randomNumber > inputNumber)
                {
                    Console.WriteLine("Your number is too small.");
                }
                else if (randomNumber < inputNumber)
                {
                    Console.WriteLine("Your number is too big.");
                }

            } while (inputNumber != randomNumber);

            Console.WriteLine("You guessed the number!");
        }
    }
}
