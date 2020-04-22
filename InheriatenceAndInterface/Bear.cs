using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriatenceAndInterface
{
    /*
     * This class inherits the animal class or
     * we can say Bear is a type of Animal
     */
    class Bear : Animal
    {
        /*
         * Pass a name to the base constructor
         */
        public Bear(string name)
            :base(name)
        { 
        }

        /*
         * Implement the abstract base method
         */
        public override void Speak()
        {
            Console.WriteLine($"{Name} said: Roar");
        }
    }
}
