using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Enrollment
    {
        private DateTime dateEnrolled;
        private string grade;
        private int semester;

        static readonly DateTime DEF_DATE_ENROLLED = DateTime.MinValue;
        const string DEF_GRADE = "No grade provided";
        const int DEF_SEMESTER = 1;
        
        public DateTime EnrollmentDateEnrolled { get; set; }        
        public string EnrollmentGrade { get; set; }
        public int EnrollmentSemester { get; set; }
        public Subject EnrollmentSubject { get; set; }
       
        /// <summary>
        /// No arg constructor 
        /// </summary>
        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        {            
        }

        /// <summary>
        /// All arg constructor
        /// </summary>
        /// <param name="dateEnrolled">When you enrolled</param>
        /// <param name="grade">The grade you got</param>
        /// <param name="semester">The semester you enrolled in</param>
        public Enrollment(DateTime dateEnrolled, string grade, int semester) : this(dateEnrolled, grade, semester, new Subject())
        {
        }

        /// <summary>
        /// Inherited Constructor
        /// </summary>
        /// <param name="dateEnrolled">When you enrolled</param>
        /// <param name="grade">The grade you got</param>
        /// <param name="semester">The semester you enrolled in</param>
        /// <param name="subject">The subject details</param>
        public Enrollment(DateTime dateEnrolled, string grade, int semester, Subject subject)
        {
            EnrollmentDateEnrolled = dateEnrolled;
            EnrollmentGrade = grade;
            EnrollmentSemester = semester;
            EnrollmentSubject = subject;
        }
        /// <summary>
        /// To String
        /// </summary>
        /// <returns>All enrollment and subject info</returns>
        public override string ToString()
        {
            return "\nDate Enrolled: " + EnrollmentDateEnrolled + "\nGrade: " + EnrollmentGrade + "\nSemester: " + EnrollmentSemester + EnrollmentSubject;
        }

    }
}
