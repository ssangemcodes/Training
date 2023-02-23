using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -> used for commenting
            /*this is used for
            multi line comment*/

            /*Console.WriteLine("Welcome to Calculator");

            Console.WriteLine("enter a number: ");

            int num1 = Convert.ToInt32(Console.ReadLine()); //= assignment operator, var
                                                            //int is an integer data type

            Console.WriteLine("enter another number: ");
            long num2 = Convert.ToInt64(Console.ReadLine());

            long num3 = num1 + num2; //+ addition operation
            Console.WriteLine(num3);*/

            //To find out if a user entered a even or odd number
            //pseudo code - not actual C# code, you want to write what your c# code does in english or any language that u like

            //1) ask user to enter a number
            Console.WriteLine("Enter a number to check if its even or odd");
            var input = Convert.ToInt32(Console.ReadLine());


            //2) divide the number by 2 , reminder operator is a % (mod operator)
            //3) store the reminder in a variable
            var reminder = (input % 2);


            //4) if reminder is 0 then the input is even number

            //if(reminder == 0)
            //{
            //    Console.WriteLine("input is an even number");
            //}



            //5) if reminder is 1 then the input is odd number

            //if(reminder == 1)
            //{
            //    Console.WriteLine("input is an odd number");
            //}

            //4 and 5 combined

            if (reminder == 0)
            {
                Console.WriteLine("input is an even number");
            }
            else
            {
                Console.WriteLine("input is an odd number");
            }

            //for
            //while
            //switch case

            Console.Read();
        }
    }
}
