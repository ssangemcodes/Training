using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndIterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for, while, do-while

            //for (int i = 1; i <= 100; i++)// for i=0, i<100 i++. i++ is same as i=i+1 
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1;

            //while(i<=100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //tell if a number is prime or not
            //prime number means its divisible only by 1 and the number itself

            //37

            Console.WriteLine("Enter a number to see if it is prime number");
            var input = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true; //assume its a prime
             
            for (int i = 2; i < input; i++)
            {
                var reminder = input % i; //% operator for reminder
                if(reminder == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine(input + " is a prime number");
            else
                Console.WriteLine(input + " is not a prime number");

            

            //from 1 to 100 print all the prime numbers


            Console.Read();
        }
    }
}
