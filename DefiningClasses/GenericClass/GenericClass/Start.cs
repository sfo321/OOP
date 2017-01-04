namespace GenericClass
{
    using System;

    class Start
    {

        static void Main()
        {
            GenericList<int> proba = new GenericList<int>() { 1, 2, 3, 4, 5, 6, 7};

            proba.RemoveAt(2);

            for (int i = 0; i < 12; i++)
            {
                proba.Add(i);
                if (i == 4)
                {
                    proba.Insert(42, 2);
                }
                if (i == 5)
                {
                    proba.RemoveAt(3);
                }
            }

            Console.WriteLine(proba.ToString());

            proba.Clear();

            for (int i = 0; i < 17; i++)
            {
                proba.Add(i * 2);
            }
            Console.WriteLine(proba.ToString());

            proba.RemoveAt(4);

            Console.WriteLine(proba.ToString());

            proba.Insert(7, 6);
            proba.Insert(7, 6);
            proba.Insert(7, 6);

            Console.WriteLine(proba.ToString());

            Console.WriteLine(proba.Min());

            Console.WriteLine(proba.Max());

            Console.WriteLine(proba.Capacity);

            Console.WriteLine(proba.FindAt(8));

            Console.WriteLine(proba.IndexOf(24));
        }
    }
}
