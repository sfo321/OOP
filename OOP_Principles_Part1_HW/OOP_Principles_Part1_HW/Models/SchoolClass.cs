using System;
using System.Text;
using System.Collections.Generic;
using OOP_Principles_Part1_HW.Contracts;
using OOP_Principles_Part1_HW.Utils;

namespace OOP_Principles_Part1_HW.Models
{
    public class SchoolClass : ICommentable
    {
        private static int studentClassNumber = 0;
        private static int letter = 64;
        private readonly string textId;
        private string comment;

        private readonly ICollection<Student> students;
        private readonly ICollection<Teacher> teachers;

        public SchoolClass(int grade)
        {
            Validator.ValidateGrade(grade);
            this.textId = grade.ToString() + (char)(++letter);

            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public string TextId
        {
            get
            {
                return this.textId;
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

        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
        }

        public void AddStudent(Student student)
        {
            Validator.ValidateIfNull(student, "Student");
            if (this.students.Contains(student))
            {
                throw new ArgumentException($"Student {student.Firstname} {student.Lastname} already exists!");
            }
            student.ClassNumber = ++studentClassNumber;
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Validator.ValidateIfNull(student, "Student");
            if (!this.students.Contains(student))
            {
                throw new ArgumentException($"Student {student.Firstname} {student.Lastname} does not exist!");
            }
            this.students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Validator.ValidateIfNull(teacher, "Teacher");
            if (this.teachers.Contains(teacher))
            {
                throw new ArgumentException($"Teacher {teacher.Firstname} {teacher.Lastname} already exists!");
            }
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            Validator.ValidateIfNull(teacher, "Teacher");
            if (!this.teachers.Contains(teacher))
            {
                throw new ArgumentException($"Teacher {teacher.Firstname} {teacher.Lastname} does not exist!");
            }
            this.teachers.Remove(teacher);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"School class: {this.TextId}");
            builder.AppendLine($"Comment: {this.Comment}");
            builder.AppendLine();
            builder.AppendLine($"Teachers count: {this.Teachers.Count}");
            foreach(var t in this.teachers)
            {
                builder.Append(t);
            }
            builder.AppendLine();
            builder.AppendLine($"Students count: {this.Students.Count}");
            foreach (var s in this.students)
            {
                builder.Append(s);
            }           
            return builder.ToString();
        }
    }
}
