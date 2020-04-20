using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStructure
{
    /*
     * Takes hours, minutes and seconds from user input and prints out the time
     * made from those values
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                /*
                 * Handles the input for hours, minutes and seconds
                 */
                uint hours;

                while(true)
                {
                    Console.WriteLine("Enter value for hours (24h):");
                    if (uint.TryParse(Console.ReadLine(), out hours) && hours <= 24) break;
                    Console.WriteLine("Invalid entry, please try again..");
                }

                uint minutes;

                while (true)
                {
                    Console.WriteLine("Enter value for minutes:");
                    if (uint.TryParse(Console.ReadLine(), out minutes) && minutes < 60) break;
                    Console.WriteLine("Invalid entry, please try again..");
                }

                uint seconds;

                while (true)
                {
                    Console.WriteLine("Enter value for seconds:");
                    if (uint.TryParse(Console.ReadLine(), out seconds) && seconds < 60) break;
                    Console.WriteLine("Invalid entry, please try again..");
                }

                /*
                 * Instantiate structure with user input and print the time
                 */
                Time time = new Time(hours, minutes, seconds);
                time.Printtime();

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
