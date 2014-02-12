namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(double side, double altitude)
        {
            this.Width = side;
            this.Height = altitude;
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width / 2;
        }
    }
}
