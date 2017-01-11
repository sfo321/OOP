using System.Text;
using OOP_Principles_Part1_HW.Contracts;
using OOP_Principles_Part1_HW.Models.Abstracts;
using OOP_Principles_Part1_HW.Utils;

namespace OOP_Principles_Part1_HW.Models
{
    public class Student : Human, ICommentable
    {
        private int classNumber;
        
        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                Validator.ValidateIntNumber(value);
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("=========================");
            builder.AppendLine($"Class number: {this.classNumber}");
            builder.Append("Student ");
            builder.Append(base.ToString());           
            return builder.ToString();
        }
    }
}
