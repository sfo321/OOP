using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.School
{
    using Models;

    public class SchoolClass
    {
        internal static List<string> uniqueIDs = new List<string>();
        private string id;
        private List<Teacher> Teachers { get; }
        private List<Student> Students { get; }


        public SchoolClass(string id)
        {
            this.Id = id;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }


        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ID must be set!!");
                }
                if(uniqueIDs.Contains(value))
                {
                    throw new ArgumentException("This Class already exists!!");
                }
                this.id = value;
                uniqueIDs.Add(id);
            }
        }

        public void AddStudent(Student input)
        {
            if (Student.studentID.Contains(input.ID))
            {
                throw new ArgumentException("This student ID already exists!!!");
            }
            this.Students.Add(input);
            Student.studentID.Add(input.ID);
        }

        public void RemoveStudent(Student input)
        {
            if(!this.Students.Contains(input))
            {
                throw new ArgumentException("This student is not in list!");
            }
            this.Students.Remove(input);
            Student.studentID.Remove(input.ID);
        }

        public void AddTeacher(Teacher input)
        {
            this.Teachers.Add(input);
        }

        public void RemoveTeacher(Teacher input)
        {
            if(!this.Teachers.Contains(input))
            {
                throw new ArgumentException("Teacher does not exist in the list!");
            }
            this.Teachers.Remove(input);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat(". . .Class {0}. . . \n", this.id);
            result.AppendLine("Teachers:");
            foreach(var t in Teachers)
            {
                result.AppendLine(t.ToString());
            }
            result.AppendLine();
            result.AppendLine("Students");
            foreach (var s in Students)
            {
                result.AppendLine(s.ToString());
            }
            result.AppendLine();

            return result.ToString();
        }
    }
}
