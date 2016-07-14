namespace Dealership.Models
{
    using Dealership.Common;
    using Dealership.Contracts;
    using System;
    using System.Text;
    public class Comment : IComment
    {
        public string Author { get; set; }
        private string content;
        
        public Comment(string content)
        {
            this.Content = content;
        }

        public string Content
        {
            get
            {
                return this.content;
            }
            private set
            {
                Validator.ValidateNull(value, 
                    String.Format("{0} cannot be null or empty!", "Content"));

                Validator.ValidateIntRange(value.Length, Constants.MinCommentLength, Constants.MaxCommentLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax,
                    "Content", Constants.MinCommentLength, Constants.MaxCommentLength));
                this.content = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("    ----------");
            result.AppendLine(String.Format("    {0}", this.Content));
            result.AppendLine(String.Format("      User: {0}", this.Author));
            result.AppendLine("    ----------");
            return result.ToString();
        }
    }
}
