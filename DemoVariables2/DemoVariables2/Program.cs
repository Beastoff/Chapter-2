using System;

namespace DemoVariables2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 43;
            int value2 = 10;
            int sum;
            int diff;
            int product;
            int quotient;
            int remainder;

            sum = value1 + value2;
            diff = value1 - value2;
            product = value1 * value2;
            quotient = value1 / value2;
            remainder = value1 % value2;

            Console.WriteLine("The sum of {0} and {1} is {2}", value1, value2, sum);
            Console.WriteLine("The diff of {0} and {1} is {2}", value1, value2, diff);
            Console.WriteLine("The product of {0} and {1} is {2}", value1, value2, product);
            Console.WriteLine("The quotient of {0} and {1} is {2}", value1, value2, quotient);
            Console.WriteLine("The remainder of {0} and {1} is {2}", value1, value2, remainder);
        }
    }
}
