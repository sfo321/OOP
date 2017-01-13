namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double height;
        private double width;

        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive!");
                }
                this.height = value;
            }
        }

        public abstract void CalculateSurface();
    }
}
