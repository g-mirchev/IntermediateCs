using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriatenceAndInterface
{
    /*
     * Abstract class to represent an Animal for
     * objects to inherit from
     */
    public abstract class Animal : IFeedable
    {
        public string Name { get; set; }    //Every animal will inherit a name and age property
        public uint Age { get; protected set;  }    //the age property can only be set within this and sub classes

        /*
         * This class cannot be instantiated but it's constructor will
         * set the base rules for constructing any objects of it's sub classes
         */
        public Animal(string name, uint age = 0)
        {
            Name = name;
            Age = age;
        }

        /*
         * Implementing the method from the interface contract
         */
        public void Feed()
        {
            Console.WriteLine($"{Name} has been fed.");
        }

        /*
         * An overridable method for aging older as some
         * animals age different to others
         */
        public virtual void AgeOlder()
        {
            Age++;
            Console.WriteLine($"{Name} has aged. {Name}'s age is now {Age}");
        }

        /*
         * An abstract method that must be defined in every class
         * to create a unique string for every animal
         */
        public abstract void Speak();
    }
}
