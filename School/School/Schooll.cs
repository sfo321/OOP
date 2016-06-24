using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    using School;

    public class Schooll
    {
        private List<SchoolClass> Classes { get; set; }

        public Schooll()
        {
            this.Classes = new List<SchoolClass>();
        }

        public void AddClass(SchoolClass input)
        {
            if(this.Classes.Contains(input))
            {
                throw new ArgumentException("This class already exists!!");
            }
            this.Classes.Add(input);
        }

        public void RemoveClass(SchoolClass input)
        {
            if(!this.Classes.Contains(input))
            {
                throw new ArgumentException("This class does not exist!!");
            }
            this.Classes.Remove(input);
        }
        public void SchoolInfo()
        {
            foreach(var clas in Classes)
            {
                Console.WriteLine(clas);
            }
        }
    }
}
