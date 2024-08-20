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

        // no arg
        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        {            
        }

        // all arg
        public Enrollment(DateTime dateEnrolled, string grade, int semester) : this(dateEnrolled, grade, semester, new Subject())
        {
        }
        
        // inherited
        public Enrollment(DateTime dateEnrolled, string grade, int semester, Subject subject)
        {
            EnrollmentDateEnrolled = dateEnrolled;
            EnrollmentGrade = grade;
            EnrollmentSemester = semester;
            EnrollmentSubject = subject;
        }
        public override string ToString()
        {
            return "Date Enrolled: " + EnrollmentDateEnrolled + " Grade: " + EnrollmentGrade + " Semester: " + EnrollmentSemester + " Subject: " + EnrollmentSubject + base.ToString();
        }

    }
}
