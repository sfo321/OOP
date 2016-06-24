namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student : Human
    {
        internal static List<int> studentID = new List<int>();
        public int ID { get; }
 
        public Student(string firstname, string lastname, int id) : base(firstname, lastname)
        {
            this.ID = GenerateId(id);
        }

        private int GenerateId(int step)
        {
            string id = "2016";
            id += (new Random().Next(1, 100000)).ToString().PadLeft(6, '0');
            int result = int.Parse(id) + step;
            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.FirstName);
            result.AppendLine(this.LastName);
            result.AppendLine(this.ID.ToString());
            result.AppendLine(this.Comment ?? "no comments");
            result.AppendLine();
            return result.ToString();
        }
    }
}
