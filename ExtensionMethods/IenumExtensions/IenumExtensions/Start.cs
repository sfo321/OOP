namespace IenumExtensions
{
    using System;
    using System.Collections.Generic;

    public static class Start
    {
        static void Main()
        {
            var proba = new List<int>() { 1, 2, 3, 4, 5, 10, 42 };
            Console.WriteLine(proba.iSum());
            Console.WriteLine(proba.iProduct());
            Console.WriteLine(proba.iMin());
            Console.WriteLine(proba.iMax());
            Console.WriteLine(proba.iAverage());
            proba.ForEach(x => Console.WriteLine(x));
        }
    }
}
