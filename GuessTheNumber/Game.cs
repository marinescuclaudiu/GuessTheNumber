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

            Console.WriteLine("Try to guess the number!");

            do
            {
                Console.Write("Your number: ");
                inputNumber = int.Parse(Console.ReadLine());

                if(inputNumber == randomNumber)
                {
                    Console.WriteLine("You guessed the number!");
                    return;
                }
                else if (randomNumber > inputNumber)
                {
                    Console.WriteLine("Your number is too small.");
                }
                else
                {
                    Console.WriteLine("Your number is too big.");
                }

            } while (true);
        }
    }
}
