using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriatenceAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Bear bear = new Bear("Derek");
                Bunny bunny = new Bunny("Chungus");
                Kitten kitten = new Kitten("Meatball");

                Feeder feeder = new Feeder();

                feeder.FeedAnimal(bear);
                feeder.FeedAnimal(bunny);
                feeder.FeedAnimal(kitten);
                Console.WriteLine();

                bear.Speak();
                bunny.Speak();
                kitten.Speak();
                Console.WriteLine();

                bear.AgeOlder();
                bunny.AgeOlder();
                kitten.AgeOlder();
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
