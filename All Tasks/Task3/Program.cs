using System;

namespace Task3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //var sides = new Rectangle(10.5, 17);
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double perimeter = PerimeterCalculator(side1, side2);
            double area = AreaCalculator(side1, side2);
            Console.WriteLine(perimeter + " " + area);
        }
        static double PerimeterCalculator(double side1, double side2)
        {
            return 2*(side1 + side2);
        }
        static double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }
    }
}
