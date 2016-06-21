namespace IenumExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionIE
    {
        public static decimal iSum<T>(this IEnumerable<T> input)
        {
            var result = input.Select(x => Convert.ToDecimal(x)).Sum();
            return result;
        }

        public static decimal iProduct<T>(this IEnumerable<T> input)
        {
            decimal temp = 1;
            var result = input.Select(x => Convert.ToDecimal(x));
            foreach (decimal num in result)
            {
                temp *= num;
            }
            return temp;
        }

        public static decimal iMin<T>(this IEnumerable<T> input) where T : IComparable
        {
            var result = input.Select(x => Convert.ToDecimal(x));
            var i = result.First();
            foreach (decimal num in result)
            {
                if(i.CompareTo(num) > 0)
                {
                    i = num;
                }
            }
            return i;
        }

        public static decimal iMax<T>(this IEnumerable<T> input) where T : IComparable
        {
            var result = input.Select(x => Convert.ToDecimal(x));
            var i = result.First();
            foreach (decimal num in result)
            {
                if (i.CompareTo(num) < 0)
                {
                    i = num;
                }
            }
            return i;
        }

        public static decimal iAverage<T>(this IEnumerable<T> input)
        {
            var result = input.iSum() / input.Count();
            return result;
        }
    }
}
