namespace School.Models
{
    using System;
    using System.Text;


    using Human;

    public class Student : Human
    {
        public int ID { get; }
 
        public Student(string firstname, string lastname) : base(firstname, lastname)
        {
            this.ID = GenerateId();
        }

        private int GenerateId()
        {
            string id = "2016";
            id += (new Random().Next(1, 100000)).ToString().PadLeft(6, '0');
            return int.Parse(id);
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
