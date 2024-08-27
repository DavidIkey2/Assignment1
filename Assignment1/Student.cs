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

        /// <summary>
        /// no arg constructor 
        /// </summary>
        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED)
        {
        }
       
        /// <summary>
        /// All arg constructor
        /// </summary>
        /// <param name="studentID">Unique student number</param>
        /// <param name="program">Program or course title</param>
        /// <param name="dateRegistered">Date student registered</param>
        public Student(string studentID, string program, DateTime dateRegistered) : this(studentID, program, dateRegistered, DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER, new Enrollment(),new Address())
        {
        }

        /// <summary>
        /// Inherited Constructor
        /// </summary>
        /// <param name="studentID">Unique student number</param>
        /// <param name="program">Program or course title</param>
        /// <param name="dateRegistered">Date student registered</param>
        /// <param name="name">The persons name</param>
        /// <param name="email">The persons email</param>
        /// <param name="phone">Home or mobile number</param>
        /// <param name="enrollment">All enrollment information</param>
        /// <param name="address">Full address</param>
        public Student(string studentID, string program, DateTime dateRegistered, string name, string email, string phone, Enrollment enrollment, Address address) : base (name, email, phone, address)
        {
            StudentStudentID = studentID;
            StudentProgram = program;
            StudentDateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }
        /// <summary>
        /// To String Method
        /// </summary>
        /// <returns>All Student Information, Person(al) information and Enrollment</returns>
        public override string ToString()
        {
            return "\nStudent ID: " + StudentStudentID + base.ToString() + "\nProgram: " + StudentProgram + "\nDate Registered: " + StudentDateRegistered + StudentEnrollment;
        }
        /// <summary>
        /// To overide the normal equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Result of new equality test</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)//check null object to avoid NullReferenceException
                return false;
            if (ReferenceEquals(obj, this))//check reference equality
                return true;
            if (obj.GetType() != this.GetType())//check different object types
                return false;
            Student student = (Student)obj;
            return student.StudentStudentID == this.StudentStudentID;
        }
        /// <summary>
        /// New equals test
        /// </summary>
        /// <param name="student1">Student id #1</param>
        /// <param name="student2">Student id #2</param>
        /// <returns>True if same</returns>
        public static bool operator ==(Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }
        /// <summary>
        /// New not equal test
        /// </summary>
        /// <param name="student1">Student id #1</param>
        /// <param name="student2">Student id #2</param>
        /// <returns>False if not same</returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }
        /// <summary>
        /// A method for encripting the student id
        /// I have used student id because it is unique (individual names may be the same)
        /// </summary>
        /// <returns>The hash code for student id</returns>
        public override int GetHashCode()
        {
            return this.StudentStudentID.GetHashCode();
        }


    }
}
