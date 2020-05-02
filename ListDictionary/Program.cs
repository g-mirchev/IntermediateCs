using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                List<Student> students = new List<Student>();

                students.Add(new Student("John", 1));
                students.Add(new Student("Ahmed", 1));
                students.Add(new Student("Totoro", 2));
                students.Add(new Student("Natasha", 2));
                students.Add(new Student("Boris", 2));
                students.Add(new Student("Penny", 3));
                students.Add(new Student("Jenny", 3));
                students.Add(new Student("Reni", 3));
                students.Add(new Student("Alice", 3));

                Dictionary<string, string> studentTeacher = new Dictionary<string, string>();

                foreach(var student in students)
                {
                    studentTeacher.Add(student.Name, MapTeacher(student.Year));
                }    

                foreach(var item in studentTeacher)
                {
                    Console.WriteLine($"The teacher of {item.Key} is {item.Value}");
                }

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        public static string MapTeacher(ushort year)
        {
            string teacher = "";

            switch(year)
            {
                case 1:
                    teacher = "Mr. Hovis";
                    break;
                case 2:
                    teacher = "Ms. Crinckle";
                    break;
                case 3:
                    teacher = "Mrs. Hovis";
                    break;
            }

            return teacher;
        }
    }
}
