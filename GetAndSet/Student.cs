using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSet
{
    public class Student
    {
        /*
         * Access methods for the _name property
         */
        public string Name { get; set; }

        /*
         * This property is read only as it only has a getter
         */
        public string LastName { get; }

        /*
         * This property can only be set internally (in this class)
         */
        public Guid Id { get; private set; }

        public Student(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            this.Id = Guid.NewGuid();   //create a global unique ID for each new student
        }

        public string GetFullName()
        {
            return Name + ' ' + LastName;
        }
    }
}
