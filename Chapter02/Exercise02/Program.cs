using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Type[] names;
            names = new Type[11];
            
            names[0]= sbyte;
            names[1]= byte;
            names[2]= short;
            names[3]= ushort;
            names[4]= int;
            names[5]= uint;
            names[6]= long;
            names[7]= ulong;
            names[8]= float;
            names[9]= double;
            names[10]= decimal;

            foreach (Type name in names)
            {
                Console.WriteLine(
                    format: sizeof({0}),
                    arg0: name);
            }

        }
    }
}
