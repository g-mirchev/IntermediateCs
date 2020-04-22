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
                RunForInt();

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static void RunForInt()
        {
            uint collectionLength;


            /*
             * Ask for user input for the collection lengt
             */
            while(true)
            {
                Console.WriteLine("How large should the collection be? (Don't go too big you will have to fill the collection yourself)");
                if(uint.TryParse(Console.ReadLine(), out collectionLength)) break;
                Console.WriteLine("Invalid input, please try again..");
            }

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

            uint index;

            /*
             * Ask for user input for the index ellement
             */
            while(true)
            {
                Console.WriteLine($"Select an element from your collection by index. The first is 0 the last is {collectionLength - 1}");
                if (uint.TryParse(Console.ReadLine(), out index) && index < collectionLength) break;
                Console.WriteLine("Invalid input, please try again..");
            }

            int number = initializer.RetrieveElementOnIndex(index);
            Console.WriteLine();
            Console.WriteLine($"Element on the index {index} is {number}");
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
