using NUnit.Framework;
using System;
using System.Security.Cryptography.X509Certificates;
using Student;
using Assignment1;

namespace SearchSortTest
{
    [TestFixture]
    public class Tests
    {
        public Student student1;

        [SetUp]
        public void Setup()
        {


            Student[] students = new Student[]
           {
                new Student(111222333, "Business", new DateTime(2024, 5, 30)),
                new Student(111222334, "IT", new DateTime(2024, 5, 30)),
                new Student(111222335, "Law", new DateTime(2024, 5, 30)),
                new Student(111222336, "Health", new DateTime(2024, 5, 30)),
                new Student(111222337, "Languages", new DateTime(2024, 5, 30)),
                new Student(111222338, "Business", new DateTime(2024, 5, 30)),
                new Student(111222339, "IT", new DateTime(2024, 5, 30)),
                new Student(111222331, "Law", new DateTime(2024, 5, 30)),
                new Student(111222332, "Health", new DateTime(2024, 5, 30)),
                new Student(111222330, "Languages", new DateTime(2024, 5, 30)),
           };
        }

        [Test]
        public void Test1()
        {
            Assert.AreSame("Business", student.getStudentProgram())
        }
    }
}