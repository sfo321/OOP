using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var tashak = new Student("Hasan", "Pehlivan", new List<int> { 3, 4, 5, 5, 3, 4, 5, 6 },
                "345306874544", "02978452365", "tralala@abv.bg", new Group(2, "Physics"));

            Console.WriteLine(tashak.group.DepartmentName);
        }
    }
}
