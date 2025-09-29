using System;
using task3;
using Xunit;

namespace task3
{
    public class FigureTests
    {
        private static void AssertAlmostEqual(double expected, double actual, double eps = 1e-9)
            => Assert.True(Math.Abs(expected - actual) <= eps, $"Expected {expected}, got {actual}");

        [Fact]
        public void LengthSide_Zero_WhenSamePoint()
        {
            var p = new Point(2, 2);
            var f = new Figure("tri", new Point(0,0), new Point(1,0), new Point(0,1));
            AssertAlmostEqual(0, f.LengthSide(p, p));
        }

        [Fact]
        public void LengthSide_Calculates_Pythagoras_3_4_5()
        {
            var a = new Point(0, 0);
            var b = new Point(3, 4);
            var f = new Figure("tri", new Point(0,0), new Point(1,0), new Point(0,1));

            var d1 = f.LengthSide(a, b);
            var d2 = f.LengthSide(b, a); // симметрично

            AssertAlmostEqual(5, d1);
            AssertAlmostEqual(d1, d2);
        }

        [Fact]
        public void Name_IsSet_ByConstructor()
        {
            var fig = new Figure("Тест-фигура", new Point(0,0), new Point(1,0), new Point(0,1));
            Assert.Equal("Тест-фигура", fig.Name);
        }

        [Fact]
        public void Perimeter_Triangle_From_Program_Is_12()
        {
            // Треугольник из Program.cs: (0,0)-(3,0)-(3,4): 3 + 4 + 5 = 12
            var A = new Point(0, 0);
            var B = new Point(3, 0);
            var C = new Point(3, 4);

            var triangle = new Figure("Треугольник", A, B, C);

            AssertAlmostEqual(12, triangle.PerimeterCalculator());
        }

        [Fact]
        public void Perimeter_Square_With_4PointCtor_Is_8()
        {
            var A = new Point(0, 0);
            var B = new Point(2, 0);
            var C = new Point(2, 2);
            var D = new Point(0, 2);

            var square = new Figure("Квадрат", A, B, C, D);

            AssertAlmostEqual(8, square.PerimeterCalculator());
        }

        [Fact]
        public void Perimeter_Closes_LastToFirst_And_5PointCtor_Works()
        {
            // Пятиугольник (ломаная по часовой стрелке)
            var p1 = new Point(0, 0);
            var p2 = new Point(2, 0);
            var p3 = new Point(3, 1);
            var p4 = new Point(1, 3);
            var p5 = new Point(0, 1);

            var pent = new Figure("Пятиугольник", p1, p2, p3, p4, p5);

            // Считаем ожидаемый периметр по тем же отрезкам + замыкание p5->p1
            double Dist(Point a, Point b)
            {
                var dx = b.X - a.X;
                var dy = b.Y - a.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }

            var expected =
                Dist(p1, p2) +
                Dist(p2, p3) +
                Dist(p3, p4) +
                Dist(p4, p5) +
                Dist(p5, p1);

            AssertAlmostEqual(expected, pent.PerimeterCalculator());
        }
    }
}
