using System.Text;
using OOP_Principles_Part1_HW.Contracts;
using OOP_Principles_Part1_HW.Utils;

namespace OOP_Principles_Part1_HW.Models.Abstracts
{
    public abstract class Human : ICommentable
    {
        private readonly string firstName;
        private readonly string lastName;
        private string comment;

        public Human(string firstName, string lastName)
        {
            Validator.ValidateString(firstName, "First name");
            this.firstName = firstName;
            Validator.ValidateString(lastName, "Last name");
            this.lastName = lastName;
        }

        public string Firstname
        {
            get
            {
                return this.firstName;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastName;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                Validator.ValidateString(value, "Comment");
                this.comment = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"name: {this.Firstname} {this.Lastname}");
            builder.AppendLine($"Comment: {this.Comment}");
            return builder.ToString();
        }
    }
}
