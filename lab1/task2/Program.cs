using System;

namespace task2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите сторону A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону B: ");
            double b = double.Parse(Console.ReadLine());

            var rect = new Rectangle(a, b);

            Console.WriteLine($"Площадь: {rect.Area}");
            Console.WriteLine($"Периметр: {rect.Perimeter}");
        }
    }
}