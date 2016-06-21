namespace DefiningClasses2
{
    using System;
    using System.IO;

    public class PathStorage
    {
        public static void Save(Path path, string filename)
        {
            using (StreamWriter writer = File.CreateText("..//..//" + filename + ".txt"))
            {
                writer.WriteLine(path.ToString());
            }
        }

        public static Path Read(string filename)
        {
            Path path = new Path();
            filename = "..//..//" + filename + ".txt";

            using (StreamReader sr = new StreamReader(filename))
            {
                string[] txt = sr.ReadToEnd().Split(new char[] { '\n', '\r' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach(var str in txt)
                {
                    path.AddPoint(Path.Parse(str));
                }               
            }
            return path;
        }
    }
}

