using System;

namespace ClassInheritanceExample
{
    //The : operator is used for class inheritance. Just like C++
    class Bear : StuffedToy
    {
        public override void Eat()
        {
            Console.WriteLine("Eating like a bear!");
        }

        //Bear can "override" base-class methods.
        //Terminology: base-class, superclass, parent
        //In this case the base-class is StuffedToy
        //Bear is the derived class. It derives from StuffedToy
        //Terminology: derived class, subclass, child

        //Hug "overrides" the base-class Hug method
        public override void Hug()
        {
            Console.WriteLine("I'm getting hugged like a bear!");
        }

        public override void Squeeze()
        {
            Console.WriteLine("I'm getting squeezed like a bear!");
        }

        public override void Wash()
        {
            Console.WriteLine("I'm getting washed like a bear!");
        }
    }
}
