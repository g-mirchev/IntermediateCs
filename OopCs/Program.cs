using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCs
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Student student = new Student(); //default constructor

                Student student1 = new Student("John", "Doe"); //oveloaded constructor

                Console.WriteLine($"First student name is {student.GetFullName()}");
                Console.WriteLine($"Seccond student name is {student1.GetFullName()}");

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
