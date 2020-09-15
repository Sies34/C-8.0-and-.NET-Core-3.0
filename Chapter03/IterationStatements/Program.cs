using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            string password = string.Empty;

            int attempts = 0;
            
            do
            {
                WriteLine("Enter your password: ");
                password = ReadLine();
                attempts++;
            }
            while (password != "Pa$$w0rd" & attempts < 10);
            
            if (attempts >= 10)
            {
                WriteLine("error");
            }
            else
            {
                WriteLine("Correct");
            }

            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            string[] names = {"Johan", "Esther", "Cas", "Job"};

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
                                    
        }
    }
}
