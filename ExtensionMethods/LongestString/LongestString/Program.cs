namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var stringlist = new List<string> { "vafla", "zmiq", "kokoshka",
                "portokal", "muu", "rabota", "kot takoa", "C reshetka", "Javascriptaaaa i NODE.js" };

            var ordered = stringlist.OrderBy(x => x.Length).ToList();

            foreach(string str in ordered)
            {
                Console.WriteLine(str);
            }
        }
    }
}
