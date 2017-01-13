namespace Shapes
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {
        }

        public override void CalculateSurface()
        {
            double result = (Width * Height);
            Console.WriteLine("The Area of {0} is {1}", this.GetType().Name, result);
        }
    }
}
