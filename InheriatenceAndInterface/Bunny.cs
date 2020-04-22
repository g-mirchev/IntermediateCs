using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriatenceAndInterface
{
    /*
     * Bunny is a type of Animal
     */
    class Bunny : Animal
    {
        public Bunny(string name)
            : base(name)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} said: What's up, doc?");
        }

        /*
         * Bunnies age 3 times faster than other animals
         * therefore we hide the original implementation
         */
        public new void AgeOlder()
        {
            Age += 3;
            Console.WriteLine($"{Name} has aged. {Name}'s age is {Age}");
        }
    }
}
