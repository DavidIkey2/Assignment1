using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeEnrolment1
{
    public class Subject
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

        
        /// <summary>
        /// Constructor (no args)
        /// </summary>
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {
        }
      
        /// <summary>
        /// Constructor (all args)
        /// </summary>
        /// <param name="subjectCode">The alpha numeric subject code</param>
        /// <param name="subjectName">The subject name</param>
        /// <param name="cost">How much it costs</param>
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectSubjectCode = subjectCode;
            SubjectSubjectName = subjectName;
            SubjectCost = cost;
        }
        /// <summary>
        /// To String Method
        /// </summary>
        /// <returns>All subject information</returns>
        public override string ToString()
        {
            return "\nSubject Code: " + SubjectSubjectCode + "\nSubject Name: " + SubjectSubjectName + "\nCost: " + SubjectCost;
        }


    }
}
