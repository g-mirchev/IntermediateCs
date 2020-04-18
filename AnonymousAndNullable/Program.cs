using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousAndNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Student student1 = new Student("Jenny", "Harper", 3);
                Student student2 = new Student("Dorian", "Gray");

                student1.PrintAwardInfo();
                student2.PrintAwardInfo();

                var anonymousStudent = new { Name = "John", LastName = "Belucci" }; // this is an object of the anonymous class
                Console.WriteLine($"The student named {anonymousStudent.Name}  {anonymousStudent.LastName} doesn't appear in the register");

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
