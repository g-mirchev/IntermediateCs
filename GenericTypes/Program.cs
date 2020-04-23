using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ushort input;

                while (true)
                {
                    Console.WriteLine("Choose your collection type: Type 1 for int 2 for string.");
                    if (ushort.TryParse(Console.ReadLine(), out input) && input > 0 && input <= 2) break;
                    Console.WriteLine("Invalid input, please try again..");
                }

                switch(input)
                {
                    case 1:
                        RunForInt();
                        break;
                    case 2:
                        RunForString();
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /*
         * Run the program for int collection
         */
        private static void RunForInt()
        {
            Console.WriteLine("Creating collection of strings:");
            uint collectionLength = AskForCollectionLength();

            CollectionInitializer<int> initializer = new CollectionInitializer<int>(collectionLength);

            int[] inputCollection = new int[collectionLength];

            /*
             * Ask for user input for the array of elements
             */
            for (int i = 0; i < collectionLength; i++)
            {
                int input;
                while(true)
                {
                    Console.WriteLine($"Write your element for position {i}");
                    if (int.TryParse(Console.ReadLine(), out input)) break;
                    Console.WriteLine("Invalid input, please try again..");
                }
                inputCollection[i] = input;
            }
            
            initializer.AddElementsToCollection(inputCollection);
            int[] collection = initializer.RetrieveAllElements();
            PrintCollection<int>(collection);

            uint index = AskForIndex(collectionLength);

            int number = initializer.RetrieveElementOnIndex(index);
            Console.WriteLine();
            Console.WriteLine($"Element on the index {index} is {number}");
        }

        /*
         * Run the program making a string collection
         */
        private static void RunForString()
        {
            uint collectionLength = AskForCollectionLength();

            CollectionInitializer<string> initializer = new CollectionInitializer<string>(collectionLength);

            string[] inputCollection = new string[collectionLength];

            /*
             * Ask for user input for the array of elements
             */
            for (int i = 0; i < collectionLength; i++)
            {
                Console.WriteLine($"Write your element for position {i}");
                string input = Console.ReadLine();
                inputCollection[i] = input;
            }

            initializer.AddElementsToCollection(inputCollection);
            string[] collection = initializer.RetrieveAllElements();
            PrintCollection<string>(collection);

            uint index = AskForIndex(collectionLength);

            string value = initializer.RetrieveElementOnIndex(index);
            Console.WriteLine();
            Console.WriteLine($"Element on the index {index} is {value}");
        }

        /*
         * Ask for user input for the collection lengt
         */
        public static uint AskForCollectionLength()
        {
            uint input;
            while (true)
            {
                Console.WriteLine("How large should the collection be? (Choose at least 1 but don't go too big as you will have to fill the collection yourself)");
                if (uint.TryParse(Console.ReadLine(), out input) && input >= 1) break;
                Console.WriteLine("Invalid input, please try again..");
            }
            return input;
        }

        /*
         * Ask for user input for the index ellement
         */
        public static uint AskForIndex(uint maxLength)
        {
            uint input;
            while (true)
            {
                Console.WriteLine($"Select an element from your collection by index. The first is 0 the last is {maxLength - 1}");
                if (uint.TryParse(Console.ReadLine(), out input) && input < maxLength) break;
                Console.WriteLine("Invalid input, please try again..");
            }
            return input;
        }

        /*
         * Generic method to print array of any type
         */
        public static void PrintCollection<T>(params T[] elements)
        {
            Console.WriteLine();
            Console.WriteLine("Printing current collection:");
            for(int i = 0; i < elements.Length; i ++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
