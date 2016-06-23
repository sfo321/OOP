using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    using Human;

    public class Teacher : Human
    {
        public List<string> Disciplines { get; private set; }

        public Teacher(string firstname, string lastname, List<string> disciplines)
            : base(firstname, lastname)
        {
            this.Disciplines = disciplines;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.FirstName);
            result.AppendLine(this.LastName);
            foreach(string st in Disciplines)
            {
                result.AppendLine(st);
            }
            result.AppendLine(this.Comment ?? "no comments");
            result.AppendLine();
            return result.ToString();
        }
    }
}
