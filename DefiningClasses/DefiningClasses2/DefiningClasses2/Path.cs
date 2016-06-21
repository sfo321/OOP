namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Path
    {
        private ICollection<Point3D> points;

        public Path()
        {
            this.points = new HashSet<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public static Point3D Parse(string str)
        {
            Path result = new Path();
            double[] temp = (str.Split(new char[] { '[', ']', ',', ' ' },
                        StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray());

            Point3D current = new Point3D(temp[0], temp[1], temp[2]);

            return current;
        }

        public override string ToString()
        {
            return string.Join(" \n", this.points);
        }
    }
}
