using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStructure
{
    /*
     * Creating structure to represent a time format in hours minutes and seconds
     * the object created is immutable
     */
    public struct Time
    {

        private uint _hours, _minutes, _seconds;

        /*
         * The constructor must instantiate all values of the struct
         */
        public Time(uint hours, uint minutes, uint seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }

        /*
         * Print out the time
         */
        public void Printtime()
        {
            Console.WriteLine($"The time is {_hours}:{_minutes}:{_seconds}");
        }
    }
}
