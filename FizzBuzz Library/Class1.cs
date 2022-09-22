using System;

namespace FizzBuzz_Library
{
    public class Class1
    {
        public static main()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine(@"ODD NUMBER GAME \nPick a number from 100 to 1000 \n guess the number of odd numbers that are in counting from 1 to the number you chose!!");
            Console.WriteLine("------------------------------------------------------------------------------------------------------ \n");

            int guess = Console.ReadLine("Guess a number!!");

            Console.WriteLine(OddNumberGame(guess));

            return guess;

            Console.ReadKey();            
        }
        private OddNumberGame(int guess)
        {
            int guess;

            do
            {
                i = 1;
                if (guess % 2 != 0)
                {
                    guess--;
                }
                else
                {
                    Console.WriteLine(i);
                    i++;
                    guess--;
                }
            } while (guess != 0);
        }
    }
}
