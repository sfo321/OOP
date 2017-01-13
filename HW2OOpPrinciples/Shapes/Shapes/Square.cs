namespace Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(int width) : base(width, width)
        {
        }

        public override void CalculateSurface()
        {
            double result = (Width * Width);
            Console.WriteLine("The Area of {0} is {1}", this.GetType().Name, result);
        }
    }
}
