using NUnit.Framework;
using System;
using TafeEnrolment1;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {        
        public Student[] students;

        Student s0 = new Student(111222333, "Business", new DateTime(2024, 5, 30));
        Student s1 = new Student(111222334, "IT", new DateTime(2024, 5, 30));
        Student s2 = new Student(111222335, "Law", new DateTime(2024, 5, 30));
        Student s3 = new Student(111222336, "Health", new DateTime(2024, 5, 30));
        Student s4 = new Student(111222337, "Languages", new DateTime(2024, 5, 30));
        Student s5 = new Student(111222338, "Business", new DateTime(2024, 5, 30));
        Student s6 = new Student(111222339, "IT", new DateTime(2024, 5, 30));
        Student s7 = new Student(111222331, "Law", new DateTime(2024, 5, 30));
        Student s8 = new Student(111222332, "Health", new DateTime(2024, 5, 30));
        Student s9 = new Student(111222330, "Languages", new DateTime(2024, 5, 30));

        Student Test1 = new Student(111222333, "Business", new DateTime(2024, 5, 30));
        Student Test2 = new Student(111222666, "Business", new DateTime(2024, 5, 30));

        [SetUp]
        public void Setup()
        {
            students = new Student[] { s0, s1, s2, s3, s4, s5, s6, s7, s8, s9 };

        }
        [Test]
        public void Test01LinearSearchInArray()       
        {
            Assert.AreNotEqual(-1, Utility.LinearSearchArray(students, Test1));
        }
        [Test]
        public void Test02LinearySearchNotInArray()
        {
            Assert.AreEqual(-1, Utility.LinearSearchArray(students, Test2));
        }
        [Test]
        public void Test03BinarySearchInArray()
        {
            Utility.BubbleSortAsc(students);
            Assert.AreNotEqual(-1, Utility.BinarySearchArray(students, Test1));
        }
        [Test]
        public void Test04BinarySearchNotInArray()
        {
            Utility.BubbleSortAsc(students);
            Assert.AreEqual(-1, Utility.BinarySearchArray(students, Test1));
        }
        [Test]
        public void Test05BubbleSortArraySortsAscending()
        {
            // Arrange            
            Student[] expected;
            
            Student s0 = new Student(111222333, "Business", new DateTime(2024, 5, 30));
            Student s1 = new Student(111222334, "IT", new DateTime(2024, 5, 30));
            Student s2 = new Student(111222335, "Law", new DateTime(2024, 5, 30));
            Student s3 = new Student(111222336, "Health", new DateTime(2024, 5, 30));
            Student s4 = new Student(111222337, "Languages", new DateTime(2024, 5, 30));
            Student s5 = new Student(111222338, "Business", new DateTime(2024, 5, 30));
            Student s6 = new Student(111222339, "IT", new DateTime(2024, 5, 30));
            Student s7 = new Student(111222331, "Law", new DateTime(2024, 5, 30));
            Student s8 = new Student(111222332, "Health", new DateTime(2024, 5, 30));
            Student s9 = new Student(111222330, "Languages", new DateTime(2024, 5, 30));

            expected = new Student[] { s9, s7, s8, s0, s1, s2, s3, s4, s5, s6 };

            // Act
            Utility.BubbleSortAsc(students);

            // Assert
            Assert.AreEqual(expected, students);  // Check if array with duplicates is sorted correctly
        }
        [Test]
        public void Test06BubbleSortArraySortsDescending()
        {
            // Arrange            
            Student[] expected;

            Student s0 = new Student(111222333, "Business", new DateTime(2024, 5, 30));
            Student s1 = new Student(111222334, "IT", new DateTime(2024, 5, 30));
            Student s2 = new Student(111222335, "Law", new DateTime(2024, 5, 30));
            Student s3 = new Student(111222336, "Health", new DateTime(2024, 5, 30));
            Student s4 = new Student(111222337, "Languages", new DateTime(2024, 5, 30));
            Student s5 = new Student(111222338, "Business", new DateTime(2024, 5, 30));
            Student s6 = new Student(111222339, "IT", new DateTime(2024, 5, 30));
            Student s7 = new Student(111222331, "Law", new DateTime(2024, 5, 30));
            Student s8 = new Student(111222332, "Health", new DateTime(2024, 5, 30));
            Student s9 = new Student(111222330, "Languages", new DateTime(2024, 5, 30));
            
            expected = new Student[] { s6, s5, s4, s3, s2, s1, s0, s8, s7, s9 };

            // Act
            Utility.BubbleSortDes(students);

            // Assert
            Assert.AreEqual(expected, students);  // Check if array with duplicates is sorted correctly
        }
        //[Test]
        //public void Test03()
        //{
        //    Assert.AreSame("Business", students[0].StudentProgram);
        //}
        //[Test]
        //public void Test04()
        //{
        //    Assert.AreEqual(false, students[0]==students[1]);
        //}
    }
}