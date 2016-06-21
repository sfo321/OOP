namespace DefiningClasses2
{
    public struct Point3D
    {
        private static readonly Point3D point0 = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D O
        {
            get
            {
                return point0;
            }
        }

        public override string ToString()
        {
            return $"[{this.X}, {this.Y}, {this.Z}]";
        }
    }
}
