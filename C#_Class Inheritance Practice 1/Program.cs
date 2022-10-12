using System;

namespace ClassInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //The reference bear is a base-class reference.
            //The allocated object is a subclass of StuffedToy.
            StuffedToy bear = new Bear();

            bear.Hug();
            bear.Squeeze();
            bear.Wash();

            Console.Read(); //Suspend program execution so that the user can view the output.
        }
    }
}
