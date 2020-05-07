using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*
     * Contains the logic of the methods that are to be mapped to the function delegates in ExecutionManager class
     */
    public class OperationManager
    {
        private int _first;
        private int _second;
        private readonly ExecutionManager _executionManager;

        /*
         * Take two ints and the execution manager as parameters
         * populate the function delegates with the three methods below
         * and map the operations to the function delegates in the dictionary
         */
        public OperationManager(int first, int second, ExecutionManager executionManager)
        {
            _first = first;
            _second = second;
            _executionManager = executionManager;
            _executionManager.PopulateFunctions(Sum, Substract, Multiply);
            _executionManager.PrepareExecution();
        }

        /*
         * Return the sum of _first and _second
         */
        private int Sum() => _first + _second;

        /*
         * Return the substraction of _first and _second
         */
        private int Substract() => _first - _second;

        /*
         * Return the multiplication of _first and _second
         */
        private int Multiply() => _first * _second;
        
        /*
         * If the operation exists in the dictionary execute the function delegate mapped to it
         * and return the result, if it doesn't exist return -1
         */
        public int Execute(Operation operation)
        {
            return _executionManager.FuncExecute.ContainsKey(operation) ?
                _executionManager.FuncExecute[operation]() :
                -1;
        }
    }
}
