using System.Text;
using System.Collections.Generic;

namespace OOP_Principles_Part1_HW.Models
{
    public class School
    {
        private ICollection<SchoolClass> classes;

        public School()
        {
            this.classes = new List<SchoolClass>();
        }

        public void AddClass(SchoolClass classToAdd)
        {
            this.classes.Add(classToAdd);
        }

        public void ReamoveClass(SchoolClass classToRemove)
        {
            this.classes.Remove(classToRemove);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach(var c in this.classes)
            {
                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
