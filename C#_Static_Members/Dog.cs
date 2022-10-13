using System;

namespace Example_01
{
    class Dog
    {
        //Data Members (Fields)
        public static string BarkMessage;
        public static int BarkCount;

        //Methods
        public static void Bark()
        {
            for (int count = 0; count < BarkCount; count++)
            {
                Console.WriteLine(BarkMessage);
            }
        }
    }
}
