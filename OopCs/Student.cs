using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCs
{
    /*
     * Represents a data object of type Student
     */
    public partial class Student
    {
        /*
         * Declare two strings as members of this classification
         */
        private string _name;
        private string _lastName;

        /*
         * Default constructor for this class looks like this
         */
        public Student()
        {
            _name = string.Empty;
            _lastName = string.Empty;
        }
    }

    public partial class Student
    { 
        /*
         * Overloads the default constructor to accept parameters
         * these paremeters then get assigned to the class members declared above
         * when the object is created.
         */
        public Student(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        /*
         * Returns a concatination of the two strings to display a full name
         */
        public string GetFullName()
        {
            return _name + ' ' + _lastName;
        }
    }
}
