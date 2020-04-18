using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string word = "football";
                Console.WriteLine($"String without extension method: {word}");
                Console.WriteLine($"String with extension method: {word.FirstLetterUpperCase()}");

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
