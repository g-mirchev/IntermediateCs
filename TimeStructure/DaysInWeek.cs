using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStructure
{
    /*
     * An enumeration to represent the days of the week
     */
    public enum DaysInWeek : ushort
    {
        Monday = 1,     //make the first index 1 instead of 0
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
