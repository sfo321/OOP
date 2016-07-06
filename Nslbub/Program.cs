using System;
using System.Text;


namespace Nslbub
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var result = new StringBuilder();

            for(int i = 0; i < input.Length; i++)
            {
                result.Append((char)(input[i] - 1));
            }

            Console.WriteLine(result);
        }
    }
}
