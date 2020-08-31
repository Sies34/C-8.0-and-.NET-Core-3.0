using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = 66_000_000; // 66 million in UK
            double weight =  1.88; // in kilograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; //strings use double-quotes
            char letter = 'Z'; //chars use singles-quotes
            bool happy = true; //Booleans have value of true or false

            // var population = 66_000_000; // 66 million in UK
            // var weight =  1.88; // in kilograms
            // var price = 4.99M; // in pounds sterling
            // var fruit = "Apples"; //strings use double-quotes
            // var letter = 'Z'; //chars use singles-quotes
            // var happy = true; //Booleans have value of true or false

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

        }
    }
}
