using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day. Like Monday, Tuesday to Sunday");
            var day = Console.ReadLine();
            Enum.TryParse(day, out DaysOfWeek datEnum); ;


            //if (day == "Monday")
            //    Console.WriteLine(1);
            //if (day == "Tuesday")
            //    Console.WriteLine(2);
            //if (day == "Wednesday")
            //    Console.WriteLine(3);
            //if (day == "Thursday")
            //    Console.WriteLine(4);
            //if (day == "Friday")
            //    Console.WriteLine(5);
            //if (day == "Saturday")
            //    Console.WriteLine(6);
            //if (day == "Sunday")
            //    Console.WriteLine(7);

            //if(day!= "Monday" && day!="Tuesday")

            int dayNumber = 0;

            //switch (day)
            //{
            //    case "Monday":
            //        dayNumber = 1;
            //        break;
            //    case "Tuesday":
            //        dayNumber = 2;
            //        break;
            //    case "Wednesday":
            //        dayNumber = 3;
            //        break;
            //    case "Thursday":
            //        dayNumber = 4;
            //        break;
            //    case "Friday":
            //        dayNumber = 5;
            //        break;
            //    case "Saturday":
            //    case "Sunday":
            //        Console.WriteLine("Program is taking a break. Its the weekend.");
            //        break;
            //    default:
            //        Console.WriteLine("Input could not match any days");
            //        break;
            //}

           

            switch (datEnum)
            {
                case DaysOfWeek.Monday:
                    dayNumber = 1;
                    break;
                case DaysOfWeek.Tuesday:
                    dayNumber = 2;
                    break;
                case DaysOfWeek.Wednesday:
                    dayNumber = 3;
                    break;
                case DaysOfWeek.Thursday:
                    dayNumber = 4;
                    break;
                case DaysOfWeek.Friday:
                    dayNumber = 5;
                    break;
                case DaysOfWeek.Saturday:
                case DaysOfWeek.Sunday:
                    Console.WriteLine("Program is taking a break. Its the weekend.");
                    break;
                default:
                    Console.WriteLine("Input could not match any days");
                    break;
            }

            if (dayNumber > 0)
                Console.WriteLine(dayNumber);

            Console.ReadLine();
        }
    }

    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
