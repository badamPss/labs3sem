using System;

namespace task3
{
    public class Program
    {
        static void Main()
        {
            var A = new Point(0, 0);
            var B = new Point(3, 0);
            var C = new Point(3, 4);
            
            var triangle = new Figure("Треугольник", A, B, C);

            Console.WriteLine($"Фигура: {triangle.Name}");
            Console.WriteLine($"Периметр: {triangle.PerimeterCalculator()}");
        }
    }
}