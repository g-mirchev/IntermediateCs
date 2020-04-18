using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousAndNullable
{
    class Student
    {
        private uint? _awards = null;   //this is a nullable value
        public string Name { get; }
        public string LastName { get; }

        public Student(string name, string lastName, uint? awards = null)
        {
            this.Name = name;
            this.LastName = lastName;
            _awards = awards; // the default value of awards if unasigned is null
        }

        /*
         * Prints out how many awards the student has
         */
        public void PrintAwardInfo()
        {
            if(_awards.HasValue)
            {
                Console.WriteLine($"{GetFullName()} has {_awards} awards");
            }
            else
            {
                Console.WriteLine($"{GetFullName()} doesn't have awards");
            }
        }

        private string GetFullName()
        {
            return Name + ' ' + LastName;
        }
    }
}
