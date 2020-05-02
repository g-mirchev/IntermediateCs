using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionary
{
    class Student
    {
        public string Name { get; set; }
        public ushort Year { get; set; }

        public Student(string name, ushort year)
        {
            Name = name;
            Year = year;
        }
    }
}
