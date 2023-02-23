using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInput = string.Empty;

            do
            {
                Console.WriteLine("Enter a number to see if it is prime number");
                var input = Convert.ToInt32(Console.ReadLine());
                bool isPrime = true; //assume its a prime

                for (int i = 2; i < input; i++)
                {
                    var reminder = input % i; //% operator for reminder
                    if (reminder == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.WriteLine(input + " is a prime number");
                else
                    Console.WriteLine(input + " is not a prime number");

                Console.WriteLine("Do you want to run again? Y/N");
                userInput = Console.ReadLine();
            }
            while (userInput == "Y");

            Console.WriteLine("You chose to exit the program");
            Console.ReadLine();
        }
    }
}
