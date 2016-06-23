namespace CovergentSeries
{
    using System;

    public static class CovergentSeriesTest
    {
        static void Main()
        {
            var result = Covergent.Calc(1000, x => x / 2);
            Console.WriteLine("{0:f2}", result);

            result = Covergent.Calc(1000, x => -x / 2);
            Console.WriteLine("{0:f2}", result);

            result = Covergent.Calc2(100, (x, i) => x * (1 / i));
            Console.WriteLine("{0:f2}", result);
        }
    }
}