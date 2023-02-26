using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student1 Id");
            var id = Convert.ToInt32(Console.ReadLine());
            var student1 = new Student(id); //new keyword in .net is used for creating objects

            Console.WriteLine("Enter student1 name");
            student1.Name = Console.ReadLine();

            Console.WriteLine("Enter student1 Address");
            student1.Address = Console.ReadLine();
            Console.WriteLine("Enter student1 ssn");
            student1.SSN = Console.ReadLine();

            var studentArray = new Student[2]; // this is how we declare an array
            var studentList = new List<Student>(); // this is how we declare a list

            studentArray[0] = student1;
            studentList.Add(student1);
            //student1.DisplayStudentDetails();

            Console.WriteLine("Enter student2 Id");
            id = Convert.ToInt32(Console.ReadLine());

            var student2 = new Student(id); //all objects or instances of classes are reference types

            Console.WriteLine("Enter student2 name");
            student2.Name = Console.ReadLine();

            Console.WriteLine("Enter student2 Address");
            student2.Address = Console.ReadLine();
            Console.WriteLine("Enter student2 ssn");
            student2.SSN = Console.ReadLine();
            studentArray[1] = student2;
            studentList.Add(student2);


            //for (int i = 0; i < studentArray.Length; i++)
            //{
            //    studentArray[i].DisplayStudentDetails();
            //}

            //foreach (var student in studentArray) // foreach is for iterating thru collections
            //{
            //    student.DisplayStudentDetails();
            //}

            //for (int i = 0; i < studentList.Count(); i++)
            //{
            //    studentList[i].DisplayStudentDetails();
            //}

            foreach (var student in studentList) // foreach is for iterating thru collections
            {
                student.DisplayStudentDetails();
            }

            //LINQ - language integrated query
            var studentResult = studentList.Where(x => x.Name.Equals("John")); //list of students whose name is john
            var firstJohnResult = studentList.First(x => x.Name.Equals("John")); //first student object whose name is john... you are sure that there is a student with name John
            var firstOrDefaultJohnResult = studentList.FirstOrDefault(x => x.Name.Equals("John")); //first student object whose name is john... it returns a null when thee is no student with name John
            if(firstOrDefaultJohnResult != null)
            {
                Console.WriteLine("found a record");
            }

            studentList.Sort();
            studentList.OrderBy(x => x.Name);

            //x=> x. you read this 'x such that x.Name equals John
            //lambda expression- its a delegate method we pass in the linq expressions

            //student2.DisplayStudentDetails();
            Console.ReadLine();
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
    }
}
