using System;
using System.Collections.Generic;

namespace task3
{
    public class Figure
    {
        public string Name { get; private set; }
        private readonly List<Point> points = new();

        public Figure(string name, Point a, Point b, Point c)
        {
            Name = name;
            points.AddRange(new[] { a, b, c });
        }
        public Figure(string name, Point a, Point b, Point c, Point d)
            : this(name, a, b, c) => points.Add(d);

        public Figure(string name, Point a, Point b, Point c, Point d, Point e)
            : this(name, a, b, c, d) => points.Add(e);

        public double LengthSide(Point A, Point B)
        {
            double dx = B.X - A.X;
            double dy = B.Y - A.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double PerimeterCalculator()
        {
            double sum = 0;
            for (int i = 0; i < points.Count; i++)
            {
                var cur = points[i];
                var next = points[(i + 1) % points.Count];
                sum += LengthSide(cur, next);
            }
            return sum;
        }
    }
}