using System;

namespace DemoVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int anInt = -123;
            uint anUnassignedInt = 567;

            Console.WriteLine("The int is {0} and the unsined int is {1}.",
                anInt, anUnassignedInt);
        }
    }
}
