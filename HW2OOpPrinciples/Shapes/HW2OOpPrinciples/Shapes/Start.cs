namespace Shapes
{
    class Start
    {
        static void Main()
        {
            Shape[] shapes = new Shape[] {
            new Triangle(34, 27),
            new Triangle(17, 23),
            new Rectangle(31, 64),
            new Rectangle(11, 22),
            new Square(90),
            new Square(12) };

            foreach(var shape in shapes)
            {
                shape.CalculateSurface();
            }
        }
    }
}
