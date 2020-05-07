using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*
     * Demonstrates the use of function delegates
     */
    class Program
    {
        static void Main(string[] args)
        {
            var executionManager = new ExecutionManager();
            var operationManager = new OperationManager(20, 10, executionManager);

            var sum = operationManager.Execute(Operation.Sum);
            var substraction = operationManager.Execute(Operation.Substract);
            var multiplication = operationManager.Execute(Operation.Multiply);

            Console.WriteLine($"Result of sum: {sum} \nResult of substraction: {substraction} \nResult of multiplication: {multiplication}");

            Console.WriteLine("\nPress any key to continue..");
            Console.ReadKey();

        }
    }
}
