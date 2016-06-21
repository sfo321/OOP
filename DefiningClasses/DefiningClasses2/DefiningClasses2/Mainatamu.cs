using System;

namespace DefiningClasses2
{
    class Mainatamu
    {
        static void Main()
        {
            var path = new Path();
            for(int i = 0; i < 10; i++)
            {
                path.AddPoint(new Point3D(i, i * 2 + 1, i + 4));
            }
            PathStorage.Save(path, "tashak");
            Path treeyyy = PathStorage.Read("tashak");
            Console.WriteLine(treeyyy);
        }
    }
}
