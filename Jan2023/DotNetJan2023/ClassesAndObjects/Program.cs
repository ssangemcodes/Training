using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Details");
            //var name = Console.ReadLine();

            //Console.WriteLine(name);

            #region noprivate variable in student class
            //var student1 = new Student(); //new keyword in .net is used for creating objects
            //var student2 = new Student();

            //Console.WriteLine("Enter student1 name");
            //student1.Name = Console.ReadLine();
            //Console.WriteLine("Enter student1 Id");
            //student1.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter student1 Address");
            //student1.Address = Console.ReadLine();
            //Console.WriteLine("Enter student1 ssn");
            //student1.SSN = Console.ReadLine();

            //student1.DisplayStudentDetails();

            //Console.WriteLine("Enter student2 name");
            //student2.Name = Console.ReadLine();
            //Console.WriteLine("Enter student2 Id");
            //student2.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter student2 Address");
            //student2.Address = Console.ReadLine();
            //Console.WriteLine("Enter student2 ssn");
            //student2.SSN = Console.ReadLine();

            //student2.DisplayStudentDetails();

            #endregion


            Console.WriteLine("Enter student1 Id");
            var id = Convert.ToInt32(Console.ReadLine());
            var student1 = new Student(id); //new keyword in .net is used for creating objects

            Console.WriteLine("Enter student1 name");
            student1.Name = Console.ReadLine();
           
            Console.WriteLine("Enter student1 Address");
            student1.Address = Console.ReadLine();
            Console.WriteLine("Enter student1 ssn");
            student1.SSN = Console.ReadLine();

            student1.DisplayStudentDetails();
            
            Console.WriteLine("Enter student2 Id");
            id = Convert.ToInt32(Console.ReadLine());

            var student2 = new Student(id); //all objects or instances of classes are reference types

            Console.WriteLine("Enter student2 name");
            student2.Name = Console.ReadLine();
            
            Console.WriteLine("Enter student2 Address");
            student2.Address = Console.ReadLine();
            Console.WriteLine("Enter student2 ssn");
            student2.SSN = Console.ReadLine();

            student2.DisplayStudentDetails();
            Console.ReadLine();
            
        }
    }

    public class Student // class definition... describing the properties of the object
    {
        public Student(int id)
        {
            Id = id;
        }
        private int Id { get; set; } //public means its visible in other classes
                                    //private it is only visible in this class
                                    //intenal
                                    //protected
        public string Name { get; set; }
        public string Address { get; set; }
        public string SSN { get; set; }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("**************************");

            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("SSN: " + SSN);
            Console.WriteLine("**************************");

        }

        public float GetGpa()
        {
            return 4.0f;
        }
    }

    //OOPS Concepts
    //Inhertance
    //Polymorphism
    //Encapsulation
}
