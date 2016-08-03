using System;
using NUnit.Framework;
using SchoolProject;

namespace SchoolTests
{
    [TestFixture]
    public class CourseTests
    {
        [Test]
        public void TestIfCourseCreatedCorrectly()
        {
            var course = new Course();
            Assert.IsNotNull(course);
        }

        [Test]
        public void TestIfThrowsWhenTryToAddSameStudentTwice()
        {
            var course = new Course();
            var pesho = new Student("Pesho");

            course.AddStudent(pesho);
            TestDelegate test = () => course.AddStudent(pesho);

            Assert.Throws(typeof(ArgumentException), test);
        }

        [Test]
        public void TestIfThrowsWhenTryToRemoveNon_ExistantStudent()
        {
            var course = new Course();
            var pesho = new Student("Pesho");

            TestDelegate test = () => course.RemoveStudent(pesho);

            Assert.Throws(typeof(ArgumentException), test);
        }

        [Test]
        public void TestIfCanAddMoreThan_30_StudentsInACourse()
        {
            var course = new Course();

            TestDelegate test = () =>
            {
                for (int i = 0; i < 31; i++)
                {
                    var hasan = new Student("Hasan");
                    course.AddStudent(hasan);
                }
            };

            Assert.Throws(typeof(ArgumentException), test);
        }

        [Test]
        public void TestIfStudentsAddCorrectly()
        {
            var course = new Course();
            var pesho = new Student("Pesho");
            var count = course.Count + 1;

            course.AddStudent(pesho);

            Assert.AreEqual(count, course.Count);
        }

        [Test]
        public void TestIfStudentsRemoveCorrectly()
        {
            var course = new Course();
            var pesho = new Student("Pesho");
            var ivan = new Student("Ivan");

            course.AddStudent(pesho);
            course.AddStudent(ivan);

            var count = course.Count - 1;

            course.RemoveStudent(ivan);

            Assert.AreEqual(count, course.Count);
        }
    }
}
