using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter another number to add");
            var num2 = Convert.ToDecimal(Console.ReadLine());


            var mathHelper = new MathHelper(); //create an object of MathHelper
                                               //mathHelper naming variables like this is camel casing
            var sum = mathHelper.Add(num1, num2);


            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();
        }
    }

    public class MathHelper
    {
        public int Add(int x, int y) // access modifier (public),
                                            // return type is int,
                                            // name of the function Add
                                            // arguments to the function x and y
        {                                   // return type, name and arguments are also called signature of the method
            var result = x + y;
            return result;
        }

        //method overloading

        public decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public decimal Add(int x, decimal y)
        {
            return x + y;
        }
    }
}
