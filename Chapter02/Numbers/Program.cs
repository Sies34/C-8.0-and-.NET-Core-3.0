using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positove whole number
            // include 0
            uint naturalNumber = 23;
            Console.WriteLine($"naturalNumber = {naturalNumber}");
            Console.WriteLine($"uint uses {sizeof(uint)} bytes and can store numbers in the range {uint.MinValue:N0} to {uint.MaxValue:N0}.");

            // integer means negative or positive whole number
            // include 0
            int integerNumber = -23;
            Console.WriteLine("integerNumber = {0}", integerNumber);
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");

            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;
            Console.WriteLine("realNumber = {0}", realNumber);
            
            // double means double-precision floating point
            double anotherNumber = 2.3; //double literal
            Console.WriteLine("anotherNumber = {0}", anotherNumber);
            Console.WriteLine($"double {sizeof(double)} bytes and can store numbers in the range {double.MinValue} to {double.MaxValue}.");

            // three variables that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            // check the three variables have the same value
            // both statements output true
            Console.WriteLine("decimalNotation = {0}", decimalNotation);
            Console.WriteLine("binaryNotation = {0}", binaryNotation);
            Console.WriteLine("hexadecimalNotation = {0}", hexadecimalNotation);
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
            Console.WriteLine($"decimal {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            Console.WriteLine("Using doubles:");

            double a = 0.1;
            double b = 0.2;

            Console.WriteLine($"Value a = {a}, value b = {b} and a + b = {a + b}");

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }

            Console.WriteLine("Using decimals:");

            decimal c = 0.1M; //M suffix means a decimal literal value
            decimal d = 0.2M;

            Console.WriteLine($"Value a = {c}, value b = {d} and a + b = {c + d}");

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }
        }
    }
}
