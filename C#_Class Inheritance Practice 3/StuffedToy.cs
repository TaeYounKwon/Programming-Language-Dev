using System;

namespace ClassInheritanceExample
{
    //The abstract keyword precludes instantiation (allocation) of a StuffedToy object.
    //An abstract is designed to only advertise an interface to any programmer that
    //would like to program a concrete class (a class with methods that have implementation (code))
    //and adhere to the base-class interface.
    abstract class StuffedToy
    {
        //Fields
        protected string f_name;

        //Constructor

        //Abstract Methods

        //An abstract method can't have a method with implementation.
        //A subclass must implement all abstract base-class methods.
        public abstract void Eat();

        public abstract void Hug();

        public abstract void Squeeze();

        public abstract void Wash();
        
    }
}
