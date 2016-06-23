using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{

    class Program
    {
        static void Main(string[] args)
        {
            var Hasan = new Student("Goshio", "Petrov");
            Hasan.Comment = "Hasan da si hodi";
            Console.WriteLine(Hasan);

            var dryndio = new Teacher("Ivan", "Ivanov", 
                new List<string> { "Bulgarian", "Russian", "Chemistry" ,"Biology" });

            Console.WriteLine(dryndio);
        }
    }
}
