//This tells the compiler/linker to look for Classes in the System namespace,
//which is in the System.dll code library.
using System; 

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog.BarkCount = 5;
            Dog.BarkMessage = "Ruff!";

            Dog.Bark();

            Console.ReadLine();


        }
    }
}
