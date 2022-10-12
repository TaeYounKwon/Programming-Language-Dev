using System;

namespace ClassInheritanceExample
{
    class StuffedToy
    {
        public virtual void Hug()
        {
            Console.WriteLine("I'm getting hugged!");
        }

        public virtual void Squeeze()
        {
            Console.WriteLine("I'm getting squeezed!");
        }

        public virtual void Wash()
        {
            Console.WriteLine("I'm getting washed!");
        }
    }
}
