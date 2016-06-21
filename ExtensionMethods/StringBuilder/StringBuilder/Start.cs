namespace StringBuilder
{
    using System;
    using System.Text;

    public static class Start
    {
        static void Main()
        {
            var proba = new StringBuilder();
            for(int i = 0; i < 26; i++)
            {
                proba.Append((char)('A' + i));
            }

            Console.WriteLine(proba.ToString());

            Console.WriteLine(proba.Substring(20));

            Console.WriteLine(proba.Substring(5, 6));
        }
    }
}
