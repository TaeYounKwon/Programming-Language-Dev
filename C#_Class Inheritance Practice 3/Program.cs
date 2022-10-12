using System;

namespace ClassInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //The reference bear is a base-class reference.
            //The allocated object is a subclass of StuffedToy.
            StuffedToy[] toys = new StuffedToy[2];

            StuffedToy bear = new Bear("Winnie the Poo");
            StuffedToy deer = new Deer("Bambi");

            toys[0] = bear;
            toys[1] = deer;

            for (int index = 0; index < 2; index++)
            {
                toys[index].Hug(); //polymorphism (runtime-binding)
            }


            Console.Read(); //Suspend program execution so that the user can view the output.
        }
    }
}
