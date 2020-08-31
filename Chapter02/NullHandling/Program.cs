#nullable enable
using System;

namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error!

            int? thisCoulsBeNull = null;
            Console.WriteLine(thisCoulsBeNull);
            Console.WriteLine(thisCoulsBeNull.GetValueOrDefault());

            thisCoulsBeNull = 7;
            Console.WriteLine(thisCoulsBeNull);
            Console.WriteLine(thisCoulsBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
            
        }
    }
}
