using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Student : Person
    {
        private string studentID;
        private string program;
        private DateTime dateRegistered;

        const string DEF_STUDENT_ID = "No student id provided";
        const string DEF_PROGRAM = "No program provided";
        static readonly DateTime DEF_DATE_REGISTERED = DateTime.MinValue;


        public string StudentStudentID { get; set; }
        public string StudentProgram { get; set; }
        public DateTime StudentDateRegistered { get; set; }
        public Enrollment StudentEnrollment { get; set; }

        // no arg
        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED)
        {
        }

        // all arg
        public Student(string studentID, string program, DateTime dateRegistered) : this(studentID, program, dateRegistered, new Enrollment())
        {
        }

        // inherited
        public Student(string studentID, string program, DateTime dateRegistered, Enrollment enrollment)
        {
            StudentStudentID = studentID;
            StudentProgram = program;
            StudentDateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }
        public override string ToString()
        {
            return "Student ID: " + StudentStudentID + " Program: " + StudentProgram + " Date Registered: " + StudentDateRegistered + " Student Enrollment: " + StudentEnrollment + base.ToString();
        }
    }
}
