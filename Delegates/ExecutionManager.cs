using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*
     * Class to hold all operations and referances towards methods (Func delegates)
     */
    public class ExecutionManager
    {
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; }
        private Func<int> _sum;
        private Func<int> _substract;
        private Func<int> _multiply;

        /*
         * Instantiate dictionary that maps enumerable operation to a function delegate
         */
        public ExecutionManager()
        {
            FuncExecute = new Dictionary<Operation, Func<int>>(3);
        }

        /*
         * Populate the function delegates with the appropriate methods passed as parameters
         */
        public void PopulateFunctions(Func<int> Sum, Func<int> Substract, Func<int> Multiply)
        {
            _sum = Sum;
            _substract = Substract;
            _multiply = Multiply;
        }

        /*
         * Populate the dictionary by mapping each operation enum
         * to its appropriate function delegate
         */
        public void PrepareExecution()
        {
            FuncExecute.Add(Operation.Sum, _sum);
            FuncExecute.Add(Operation.Substract, _substract);
            FuncExecute.Add(Operation.Multiply, _multiply);
        }
    }
}
