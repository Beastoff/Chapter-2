﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, bossName;
            Boolean areNamesTheSame;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}! Enter the name of your boss", name);
            bossName = Console.ReadLine();
            areNamesTheSame = name == bossName;
            Console.WriteLine("It is {0} that you are your own boss", areNamesTheSame);
        }
    }
}
