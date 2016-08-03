namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private IList<Course> courses;

        public School()
        {
            this.courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            if (this.courses.Any(x => x.Id == course.Id))
            {
                throw new ArgumentException("Cannot add a course twice");
            }
            this.courses.Add(course);
        }

        public bool RemoveCourse(Course course)
        {
            if (!this.courses.Any(x => x.Id == course.Id))
            {
                throw new ArgumentException("This course does not exist");
            }

            return this.courses.Remove(course);
        }
    }
}
