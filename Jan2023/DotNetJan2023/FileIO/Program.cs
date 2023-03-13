using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("C:\\Projects\\Training\\FileIO" + @"\Students.txt"); // backslash is an escape charater
            //writer = new StreamWriter(@"C:\Projects\Training\FileIO" + @"\Output.txt");
            var studentList = new List<Student>();
            do
            {
                var stringFromFile = reader.ReadLine(); //I am reading the file one line at a time... first I will read the first line no matter what... then I will check if more lines exist
                //writer.WriteLine(stringFromFile);
                //Console.WriteLine(stringFromFile);

                var studentDetails = stringFromFile.Split('|');
                
                var newStudent = new Student(Convert.ToInt32(studentDetails[0]));
                newStudent.Name = studentDetails[1];
                newStudent.Address = studentDetails[2];
                newStudent.SSN = studentDetails[3];

                studentList.Add(newStudent);
            }
            while (reader.Peek() != -1);

            reader.Close();

            foreach (var student in studentList)
            {
                student.DisplayStudentDetails();
            }

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
}
