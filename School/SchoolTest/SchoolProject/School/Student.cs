namespace SchoolProject
{
    using System;
    using Utils;

    public class Student
    {
        private string name;
        private int sn;

        public Student(string name)
        {
            this.Sn = IDgenerator.GenerateId(10000);
            this.Name = name;
        }

        public int Sn
        {
            get
            {
                return this.sn;
            }
            private set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException();
                }
                this.sn = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value == "")
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }
    }
}
