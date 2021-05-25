using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var address1 = new Address(
                0979695,
                "Ukraine",
                "Kyiv",
                "Vyshenka",
                "LivingProsp",
                "Sleephouse");
            Console.WriteLine(
                address1.Index,
                address1.Country, 
                address1.City, 
                address1.Street, 
                address1.House, 
                address1.Apartment);
        }
    }
}
