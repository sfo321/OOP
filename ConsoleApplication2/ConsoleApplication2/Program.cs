using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            for(int i = 0; i < input.Length; i++)
            {
                int min = input[i];
                int index = i;

                for(int j = i; j < input.Length; j++)
                {
                    if(input[j] < min)
                    {
                        min = input[j];
                        index = j;
                    }
                }
                input[index] = input[i];
                input[i] = min;
            }

            foreach (var num in input)
            {
                Console.Write($"{num}, ");
            }
        }
    }
}
