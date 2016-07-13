using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaaa
{
    class Program
    {
        static void Main()
        {

            string k = Enum.GetName(typeof(Kurec), 4);

            int g = (int)Kurec.Kopele;

            Console.WriteLine(k);

            var role = "Tashak";

            Kurec t = (Kurec)Enum.Parse(typeof(Kurec), role);
        }
    }
}
