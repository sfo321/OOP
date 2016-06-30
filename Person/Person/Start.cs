namespace PersonClass
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var ivan = new Person("Ivan Ivanov");
            Console.WriteLine(ivan);

            var dima = new Person("Dima Koleva", 22);
            Console.WriteLine(dima);
        }
    }
}