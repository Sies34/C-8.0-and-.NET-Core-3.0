using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = a++;
            WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c; // increment c before addigning it
            WriteLine($"c is {c}, c is {d}");
        }
    }
}
