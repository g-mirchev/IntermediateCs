using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriatenceAndInterface
{
    /*
     * Kitten is a type of Animal
     */
    class Kitten : Animal
    {
        public Kitten(string name)
            :base(name)
        { 
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} said: Meow meow ~");
        }

        /*
         * Kittens age twice as fast than other animnals
         * so we override this method increment the age once
         * and then call the base method.
         */
        public override void AgeOlder()
        {
            Age++;
            base.AgeOlder();
        }
    }
}
