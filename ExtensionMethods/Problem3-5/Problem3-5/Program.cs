namespace Problem3_5
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var studentlist = new[]
            {
                new Student {FirstName = "Ivan", LastName = "Ivanov", Age = 17 },
                new Student {FirstName = "Gosho", LastName = "Ivanov", Age = 31 },
                new Student {FirstName = "Pesho", LastName = "Georgiev", Age = 20 },
                new Student {FirstName = "Ahmed", LastName = "Pehlivan", Age = 25 },
                new Student {FirstName = "Ali", LastName = "Reza", Age = 22 },
                new Student {FirstName = "Mustafa", LastName = "Kemal", Age = 23 },
                new Student {FirstName = "Toshko", LastName = "Pavlov", Age = 24 }
            };

            var orderedByName = studentlist.Where(x => string.Compare(x.FirstName, x.LastName, StringComparison.Ordinal) < 0).ToArray();

            var orderedByAge = studentlist.Where(x => x.Age >= 18 && x.Age <= 24).ToArray();

            var orderedstudents = studentlist.OrderByDescending(x => x.FirstName).ThenBy(x => x.LastName).ToArray();

            Print(orderedstudents);
            //Print(orderedByAge);
            //Print(orderedByName);
        }

        static void Print(Student[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
