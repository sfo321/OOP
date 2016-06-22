using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
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

            var orderedByFirst = studentlist.OrderBy(x => x.Firstname).ToList();

            var studentByEmail = studentlist.Where(x => x.Email.EndsWith("@abv.bg")).ToList();

            var studentsByTel = studentlist.Where(x => x.Tel.StartsWith("02")).ToList();

            var studentsWith6 = studentlist.Where(x => x.Marks.Contains(6)).ToList();

            var anonymous = new
            {
                Firstname = studentsWith6.Select(x => x.Firstname), Lastname = studentsWith6.Select(x => x.Lastname),
                Marks = studentsWith6.Select(x => x.Marks)
            };

            var studentsWithTwo2 = studentlist.Where(x => x.Marks.Where(y => y == 2).Count() == 2);
        }
    }
}
