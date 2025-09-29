namespace task2
{
    public class Rectangle {
        private readonly double sideA;
        private readonly double sideB;

        public Rectangle(double sideA, double sideB)
        {
            if (sideA < 0 || sideB < 0)
                throw new ArgumentOutOfRangeException("Стороны не могут быть отрицательными");
            
            this.sideA = sideA;
            this.sideB = sideB;
        }

        private double CalculateArea() => sideA * sideB;
        private double CalculatePerimeter() => 2 * (sideA + sideB);

        public double Area => CalculateArea();
        public double Perimeter => CalculatePerimeter();
    }
}