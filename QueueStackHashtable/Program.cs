using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueStackHashtable
{
    /*
     * Creates queue, stack and hashtable, populates them and prints the elements
     * to demonstrate the FIFO principle of the queue and FILO principle of the queue
     * shows how you can select an element by key from the hashtable.
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Queue<int> queue = new Queue<int>();
                Stack<int> stack = new Stack<int>();
                Hashtable hashtable = new Hashtable();

                /*
                 * Ask for user input to populate the collections with the same values
                 */
                Console.WriteLine("Select five ints to ba added to a queue, stack and hashtable (with keys 1 - 5) one at a time.");
                for(int i = 0; i < 5; i++)
                {
                    int input;
                    while(true)
                    {
                        Console.WriteLine($"Add element {i + 1}");
                        if (int.TryParse(Console.ReadLine(), out input)) break;
                        Console.WriteLine("Invalid input, please try again..");
                    }
                    queue.Enqueue(input);
                    stack.Push(input);
                    hashtable.Add(i + 1, input);
                }

                Console.WriteLine();
                Console.WriteLine($"The top element of the stack is {stack.Peek()}");

                /*
                 * Print the values of the queue and stack
                 */
                Console.WriteLine();
                Console.WriteLine("# \t Queue \t Stack");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i} \t {queue.Dequeue()} \t {stack.Pop()}");
                }

                /*
                 * Select a key from the hashtable to show the value mapped to it
                 */
                Console.WriteLine();
                do
                {
                    int key;
                    while (true)
                    {
                        Console.WriteLine("Select a key from (1 - 5) to see it's value in the hashtable:");
                        if (int.TryParse(Console.ReadLine(), out key) && hashtable.ContainsKey(key)) break;
                        Console.WriteLine("Invalid input, please try again..");
                    }
                    Console.WriteLine($"The value at key: {key} is {hashtable[key]}");

                    Console.WriteLine();
                    Console.WriteLine("Press ESC to close or any key to select again.");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

                Console.WriteLine();
                Console.WriteLine("Press ESC to close or any key to run again.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
