using System;

namespace PowerPoint_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle1 = new Vehicle("651651",
                   "jigul",
                   "car",
                   "medium",
                   "grey");

            var plant1 = new PlantFood("897478",
                   "Pepper",
                   "Vegetable",
                   "small",
                   "red");

            Console.WriteLine(plant1.GetFoodInfo());
        }
    }
}
