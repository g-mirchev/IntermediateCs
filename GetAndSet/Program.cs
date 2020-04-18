using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSet
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Student student = new Student("Joe", "Rogan");

                Console.WriteLine($"First student's name is: {student.GetFullName()}");
                Console.WriteLine($"{student.Name} 's ID is: {student.Id}");

                student.Name = "Jessie";

                Console.WriteLine($"After changing their first name, the student with ID: {student.Id} is now called {student.GetFullName()}");

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
