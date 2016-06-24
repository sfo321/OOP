namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Disciplines;
    public class Teacher : Human
    {
        private List<Discipline> disciplines;

        public Teacher(string firstname, string lastname)
            : base(firstname, lastname)
        {
            this.Disciplines = new List<Discipline>(); 
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline input)
        {
            if(this.Disciplines.Contains(input))
            {
                throw new ArgumentException("This discipline already exists!!!");
            }
            this.Disciplines.Add(input);
        }

        public void RemoveDiscipline(Discipline input)
        {
            if(!this.Disciplines.Contains(input))
            {
                throw new ArgumentException("No such Discipline in the list!!!");
            }
            this.Disciplines.Remove(input);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.FirstName);
            result.AppendLine(this.LastName);
            result.AppendLine(this.Comment ?? "no comments");
            result.AppendLine("Disciplines:");
            foreach (var dis in Disciplines)
            {
                result.Append(dis);
            }           
            result.AppendLine();
            return result.ToString();
        }
    }
}
