namespace School.Human
{
    using System;

    public class Human
    {
        private string firstname;

        private string lastname;

        public string Comment { get; set; }

        public Human(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name must be set!");
                }
                this.firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastname;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name must be set!");
                }
                this.lastname = value;
            }
        }
    }
}
