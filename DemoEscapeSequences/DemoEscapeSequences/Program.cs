using System;

namespace DemoEscapeSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This line\tcontains two\ttabs");
            Console.WriteLine("This statement\ncontains a end line");
            Console.WriteLine("This statement sounds three alerts\a\a\a");
        }
    }
}
