using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine ("--------------------------------------------------------------------------");

            Write(
                format: "{0, -7} {1, -17}",
                arg0: "Type",
                arg1: "Byte(s) of memory"
            );

            Write(
                format: " {0, 17} {1, 30}\n",
                arg0: "Min",
                arg1: "Max"
            );

            WriteLine ("--------------------------------------------------------------------------");

            Write(
                format: "{0, -7} {1, -4}",
                arg0: "sbyte",
                arg1: sizeof(sbyte)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: sbyte.MinValue,
                arg1: sbyte.MaxValue
            );

            Write(
                format: "{0, -7} {1, -4}",
                arg0: "byte",
                arg1: sizeof(byte)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: byte.MinValue,
                arg1: byte.MaxValue
            );

            Write(
                format: "{0, -7} {1, -4}",
                arg0: "short",
                arg1: sizeof(short)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: short.MinValue,
                arg1: short.MaxValue
            );

            Write(
                format: "{0, -7} {1, -4}",
                arg0: "ushort",
                arg1: sizeof(ushort)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: ushort.MinValue,
                arg1: ushort.MaxValue
            );

            Write(
                format: "{0, -7} {1, -4}",
                arg0: "int",
                arg1: sizeof(int)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: int.MinValue,
                arg1: int.MaxValue
            );
            Write(
                format: "{0, -7} {1, -4}",
                arg0: "uint",
                arg1: sizeof(uint)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: uint.MinValue,
                arg1: uint.MaxValue
            );

            Write(
                format: "{0, -7} {1, -4}",
                arg0: "long",
                arg1: sizeof(long)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: long.MinValue,
                arg1: long.MaxValue
            );
            Write(
                format: "{0, -7} {1, -4}",
                arg0: "ulong",
                arg1: sizeof(ulong)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: ulong.MinValue,
                arg1: ulong.MaxValue
            );
            
            Write(
                format: "{0, -7} {1, -4}",
                arg0: "float",
                arg1: sizeof(float)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: float.MinValue,
                arg1: float.MaxValue
            );
            
            Write(
                format: "{0, -7} {1, -4}",
                arg0: "double",
                arg1: sizeof(double)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: double.MinValue,
                arg1: double.MaxValue
            );

            Write(
                format: "{0, -7} {1, -4}",
                arg0: "decimal",
                arg1: sizeof(decimal)
            );

            Write(
                format: " {0, 30} {1, 30}\n",
                arg0: decimal.MinValue,
                arg1: decimal.MaxValue
            );

        }
    }
}
