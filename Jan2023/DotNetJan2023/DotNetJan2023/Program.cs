using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetJan2023
{
    internal class Program
    {
        static void Main(string[] args) //Main method is the entry point to the program
        {
            //CLR, ManagedCode
            //Compiler
            //CIL
            //CTS

            Console.WriteLine("Hello Welcome to the .Net Training"); //console is a class defined by .Net framework 

            Console.WriteLine("Enter your name: "); // write output to the console
            var name = Console.ReadLine(); // we are taking input from the user

            Console.WriteLine("Hello " + name); //I am attaching (concatenation) the two strings and showing to the user

            //shift+ctrl+B to build

            Console.Read();
        }
    }
}
