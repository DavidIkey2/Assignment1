using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private double cost;

        const string DEF_SUBJECT_CODE = "No subject code provided";
        const string DEF_SUBJECT_NAME = "No subject name provided";
        const double DEF_COST = 0.00;

        // Property Assessor Method for subjectCode 
        public string SubjectSubjectCode { get; set; }

        // Property Assessor Method for subjectName
        public string SubjectSubjectName { get; set; }

        // Property Assessor Method for cost
        public double SubjectCost { get; set; }

        //  Constructor (no args)
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {
        }

        //  Constructor (all args)
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectSubjectCode = subjectCode;
            SubjectSubjectName = subjectName;
            SubjectCost = cost;
        }

        public override string ToString()
        {
            return "Subject Code: " + SubjectSubjectCode + " Subject Name: " + SubjectSubjectName + " Cost: " + SubjectCost;
        }


    }
}
