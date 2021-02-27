namespace Rectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public double Area { get; }
        public double Perimeter { get; }

        public Rectangle()
        {
            this.side1 = 0;
            this.side2 = 0;
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;

            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
    }
}
