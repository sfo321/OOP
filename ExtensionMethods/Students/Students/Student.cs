namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Student
    {
        private string firstname;
        private string lastname;
        private string fn;
        private string tel;
        private string email;
        public List<int> Marks { get; set; }
        public Group group { get; set; } 

        public Student(string firstname, string lastname, List<int>marks)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Marks = marks;
        }

        public Student(string firstname, string lastname, List<int> marks, string fn, string tel, string email,
            Group group) : this (firstname, lastname, marks)
        {
            this.Fn = fn;
            this.Tel = tel;
            this.Email = email;
            this.group = group;
        }

        public string Firstname
        {
            get
            {
                return this.firstname;
            }
            set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("The name entered is too short!");
                }
                this.firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("The name entered is too short!");
                }
                this.lastname = value;
            }
        }

        public string Fn
        {
            get
            {
                return this.fn;
            }
            set
            {
                if (value.Length < 8)
                {
                    throw new ArgumentException("Invalid number");
                }
                this.fn = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Invalid number");
                }
                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Invalid email");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(this.firstname);
            result.AppendLine(this.lastname);
            result.AppendLine(this.fn);
            result.AppendLine(this.tel);
            result.AppendLine(this.email);
            result.AppendLine(String.Format("Group: {0}", this.group.Groupnumber));
            result.AppendLine(String.Format("Department: {0}", this.group.DepartmentName));
            result.Append("Marks:");
            foreach(int m in Marks)
            {
                result.AppendFormat(" {0},", m);
            }
        

            return result.ToString();
        }
    }
}
