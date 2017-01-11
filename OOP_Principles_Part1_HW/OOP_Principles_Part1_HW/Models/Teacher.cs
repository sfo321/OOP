using System;
using System.Text;
using System.Collections.Generic;
using OOP_Principles_Part1_HW.Contracts;
using OOP_Principles_Part1_HW.Models.Abstracts;
using OOP_Principles_Part1_HW.Utils;

namespace OOP_Principles_Part1_HW.Models
{
    public class Teacher : Human, ICommentable
    {
        private readonly ICollection<Discipline> disciplines;

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            Validator.ValidateIfNull(discipline, "Discipline");
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            Validator.ValidateIfNull(discipline, "Discipline");

            if (!this.disciplines.Contains(discipline))
            {
                throw new ArgumentException("Discipline does not exist!");
            }
            this.disciplines.Remove(discipline);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("=========================");
            builder.Append("Teacher ");
            builder.Append(base.ToString());
            builder.AppendLine("Disciplines: ");
            foreach(var d in disciplines)
            {
                builder.Append(d);
            }
            builder.AppendLine();
            return builder.ToString();
        }
    }
}
