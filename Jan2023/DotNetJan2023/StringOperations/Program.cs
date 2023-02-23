using System; //namespaces
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exampleString = "Enter a number"; //string literal

            Console.WriteLine(exampleString);

            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();

            Console.WriteLine("Your name is: " + name); // concatenating two string, append, attach
                                                        // operator overloading
                                                        // + sign - addition operator
                                                        // when it has two number as operand
                                                        // it gives a sum of the two numbers
                                                        // same + sign when it has two string or even one string and
                                                        // one number it attaches them together or concatenates
                                                        //them
            Console.WriteLine(2 + 3);

            Console.WriteLine("length is: " + name.Length); //to get number of characters in this string
            Console.WriteLine("Does it contan am: " + name.Contains("am")); //to get number of characters in this string

            Console.WriteLine("First three charcaters: " + name.Substring(0,3));
            //array or string index or starting point in .net
            //is 0 based... it always starts with 0
            //first element is at position 0
            Console.WriteLine("First three charcaters: " + name.Substring(1,3));

            foreach (var item in name.ToCharArray())
            {
               Console.WriteLine(item);
            }

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            //string vs StringBuilder
            //name = "Mr. " + name; //concat... this approach using + is ineffecient
                                  //strings are immutable
                                  //immutable means you can change it in place
                                  //it abandons the first memory location for name
                                  //creates new memory location for the new string ("Mr. " + name)
                                  //memory will have two strings: old name, new name with Mr
            //name = name + " Jr";

            //Console.WriteLine(name);

            var nameBuilder = new StringBuilder("Mr. "); //no new string is created everytime we do append.
            nameBuilder.Append(name);
            nameBuilder.Append(" Jr");
            Console.WriteLine("string builder output");
            Console.WriteLine(nameBuilder.ToString());

            Console.Read();

        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
