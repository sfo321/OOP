using System;
using NUnit.Framework;
using SchoolProject;

namespace SchoolTests
{
    [TestFixture]
    public class SchoolTests
    {
        [Test]
        public void Test_if_school_created()
        {
            var school = new School();

            Assert.IsNotNull(school);
        }

        [Test]
        public void TestifCourseCanbeAddedTwice()
        {
            var school = new School();
            var course = new Course();

            school.AddCourse(course);

            TestDelegate add = () => school.AddCourse(course);

            Assert.Throws(typeof(ArgumentException), add);
        }

        [Test]
        public void TestifThrowWhenNoCoursesAndtryToRemove()
        {
            var school = new School();
            var course = new Course();

            TestDelegate remove = () => school.RemoveCourse(course);

            Assert.Throws(typeof(ArgumentException), remove);
        }
    }
}
