namespace DivisibleBy7and3
{
    using System;
    using System.Linq;

    public class Divisibvle
    {
        static void Main()
        {
            var numbers = new[] { 5, 34, 140, 70, 21, 435, 562, 908, 900, 42, 84 };

            var result = numbers.Where(x => x % 3 == 0 && x % 7 == 0).ToArray();

            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
