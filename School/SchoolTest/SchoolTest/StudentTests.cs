using System;
using NUnit.Framework;
using SchoolProject;

namespace StudentTest
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void TestIfStudentCreatedCorrectly()
        {
            var student = new Student("Pesho");

            Assert.IsNotNull(student);
        }

        [TestCase("")]
        [TestCase(" ")]
        public void TestIfThrowsWhenInvalidName(string name)
        {
            TestDelegate test = () => new Student(name);

            Assert.Throws(typeof(ArgumentException), test);
        }

        [Test]
        public void TestIfUniqueStudentNumberIsInRange()
        {
            var student = new Student("Ivan");

            Assert.True(student.Sn >= 10000 && student.Sn <= 99999);
        }

        [Test]
        public void TestIfStudentNumbersAreUnique()
        {
            var pesho = new Student("Pesho");
            var gosho = new Student("Gosho");
            var minka = new Student("Minka");

            Assert.True(pesho.Sn != gosho.Sn && gosho.Sn != minka.Sn);
        }
    }
}
