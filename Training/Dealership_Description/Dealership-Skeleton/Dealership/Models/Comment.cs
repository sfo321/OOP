namespace Dealership.Models
{
    using Dealership.Common;
    using Dealership.Contracts;
    using System;

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
                Validator.ValidateIntRange(value.Length, Constants.MinCommentLength, Constants.MaxCommentLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax,
                    "Comment", Constants.MinCommentLength, Constants.MaxCommentLength));
                this.content = value;
            }
        }
    }
}
