namespace Shapes
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(int width, int height) : base(width, height)
        {
        }

        public override void CalculateSurface()
        {
            double result = (Width * Height) / 2;
            Console.WriteLine("The Area of {0} is {1}", this.GetType().Name, result);
        }
    }
}
