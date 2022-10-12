using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceExample
{
    class Deer : StuffedToy
    {
        //Constructors
        public Deer(string name)
        {
            base.f_name = name;
        }

        //Methods
        public override void Eat()
        {
            Console.WriteLine("Eating like a deer!");
        }

        //Bear can "override" base-class methods.
        //Terminology: base-class, superclass, parent
        //In this case the base-class is StuffedToy
        //Bear is the derived class. It derives from StuffedToy
        //Terminology: derived class, subclass, child

        //Hug "overrides" the base-class Hug method
        public override void Hug()
        {
            Console.WriteLine("I'm getting hugged like a deer!");
        }

        public override void Squeeze()
        {
            Console.WriteLine("I'm getting squeezed like a deer!");
        }

        public override void Wash()
        {
            Console.WriteLine("I'm getting washed like a deer!");
        }
    }
}
