namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StartPoint
    {
        static void Main()
        {
            var studentlist = new List<Student> {
                new Student("Hasan", "Pehlivan", new List<int> { 3, 4, 5, 5, 3, 4, 5, 6 },
                "345306874544", "02978452365", "tralala@abv.bg", new Group(2, "Physics")),

                new Student("Pesho", "Petrov", new List<int> { 2, 4, 5, 5, 2, 4, 6, 6 },
                "345330687454", "03618452365", "blablaaa@mail.bg", new Group(1, "Mathematics")),

                new Student("Mihail", "Djordjanov", new List<int> { 2, 4, 3, 3, 3, 4, 5, 2 },
                "665308874908", "02121314151", "kukuruku@gmail.com", new Group(1, "Mathematics")),

                new Student("BatBojko", "Borisov", new List<int> { 2, 2, 2, 2, 2, 2, 2, 2 },
                "355330681122", "02454655445", "BatBojko@abv.bg", new Group(3, "Politics")),

                new Student("Pulio", "Pulevich", new List<int> { 3, 2, 5, 5, 2, 4, 6, 6 },
                "345306874544", "03631445512", "pulio@mail.bg", new Group(4, "Chemistry")),

                new Student("SirBaj", "Mangau", new List<int> { 3, 5, 2, 5, 6, 4, 6, 6 },
                "345330687454", "02631445512", "BajMangau@mail.bg", new Group(1, "Mathematics")),

                new Student("Unufri", "Kolev", new List<int> { 3, 5, 2, 4, 2, 4, 4, 6 },
                "345306878796", "03635688876", "unufrii@abv.bg", new Group(3, "Politics")),

                new Student("Evlampi", "Katilov", new List<int> { 3, 6, 5, 5, 6, 4, 6, 6 },
                "845320687454", "02631445512", "katil@gmail.com", new Group(2, "Physics")),
            };

            var studentgroupTwo = studentlist.Where(x => x.group.Groupnumber == 2).ToList();

            Print(studentgroupTwo);

            var orderedByFirstName = studentlist.OrderBy(x => x.Firstname).ToList();

            Print(orderedByFirstName);

            var studentByEmail = studentlist.Where(x => x.Email.EndsWith("@abv.bg")).ToList();

            Print(studentByEmail);

            var studentsByTel = studentlist.Where(x => x.Tel.StartsWith("02")).ToList();

            Print(studentsByTel);

            var studentsWith6 = studentlist.Where(x => x.Marks.Contains(6)).ToList();

            Print(studentsWith6);

            var anonymous = new
            {
                Firstname = studentsWith6.Select(x => x.Firstname), Lastname = studentsWith6.Select(x => x.Lastname),
                Marks = studentsWith6.Select(x => x.Marks)
            };

            var studentsWithTwo2 = studentlist.Where(x => x.Marks.Where(y => y == 2).Count() == 2).ToList();

            Print(studentsWithTwo2);

            var studentMarks2006 = studentlist.Where(x => x.Fn.Substring(5, 2) == "06").Select(y => y.Marks).ToArray();

            PrintList(studentMarks2006);

            var studentMathematics = studentlist.Where(x => x.group.DepartmentName == "Mathematics").ToList();

            Print(studentMathematics);

            var studentsByGroupNumber = studentlist.OrderBy(x => x.group.Groupnumber).ToList(); ;

            Print(studentsByGroupNumber);

            var studentByGroupnumber = from s in studentlist group s
                                       by s.@group.Groupnumber into 
                                       d select new { d.Key }.ToString();
        }

        static void PrintList<T>(List<T>[] input)
        { 
            for(int i = 0; i < input.Length; i++)
            {
                var result = new StringBuilder();
                foreach(var str in input[i])
                {
                    result.AppendFormat(" {0},", str);
                }
                Console.WriteLine(result.ToString());
                Console.WriteLine();
            }
        }

        static void Print<T>(List<T> input)
        {
            foreach(var st in input)
            {
                Console.WriteLine(st);
                Console.WriteLine();
            }
        }
    }
}
