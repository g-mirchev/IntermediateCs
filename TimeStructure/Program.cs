using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStructure
{
    /*
     * Takes hours, minutes and seconds from user input and prints out the time
     * made from those values, then asks for day of the week and prints it out
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

                ushort day;

                while(true)
                {
                    Console.WriteLine("Enter value for day of week from 1 to 7 (1 = Monday, 2 = Tuesday etc.)");
                    if (ushort.TryParse(Console.ReadLine(), out day) && day > 0 && day <= 7) break;
                    Console.WriteLine("Invalid entry, please try again..");
                }

                PrintDay(day); //prints the day of the week the user input corresponds to

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        public static void PrintDay(ushort day)
        {
            switch (day)
            {
                case 1:
                    DaysInWeek monday = DaysInWeek.Monday;
                    Console.WriteLine(monday);
                    break;
                case 2:
                    DaysInWeek tuesday = DaysInWeek.Tuesday;
                    Console.WriteLine(tuesday);
                    break;
                case 3:
                    DaysInWeek wednesday = DaysInWeek.Wednesday;
                    Console.WriteLine(wednesday);
                    break;
                case 4:
                    DaysInWeek thursday = DaysInWeek.Thursday;
                    Console.WriteLine(thursday);
                    break;
                case 5:
                    DaysInWeek friday = DaysInWeek.Friday;
                    Console.WriteLine(friday);
                    break;
                case 6:
                    DaysInWeek saturday = DaysInWeek.Saturday;
                    Console.WriteLine(saturday);
                    break;
                case 7:
                    DaysInWeek sunday = DaysInWeek.Sunday;
                    Console.WriteLine(sunday);
                    break;
            }
        }
    }
}
