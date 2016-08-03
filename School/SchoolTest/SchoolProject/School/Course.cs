namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utils;

    public class Course
    {
        private int id;
        private IList<Student> students;

        public Course()
        {
            this.id = IDgenerator.GenerateId(0);
            this.students = new List<Student>();
        }

        public int Count
        {
            get
            {
                return students.Count;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public void AddStudent(Student student)
        {
            if (this.students.Any(x => x.Sn == student.Sn))
            {
                throw new ArgumentException("Cannot add same student twice");
            }

            if (this.students.Count >= 30)
            {
                throw new ArgumentException("Students must be less than or equal to 30");
            }

            this.students.Add(student);
        }

        public bool RemoveStudent(Student student)
        {
            if (!this.students.Any(x => x.Sn == student.Sn))
            {
                throw new ArgumentException("No such student");
            }

            return this.students.Remove(student);
        }
    }
}
