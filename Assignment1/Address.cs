using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Address
    {
        private string streetNum;
        private string streetName;
        private string suburb;
        private int postcode;
        private string state;

        const string DEF_STREET_NUM = "No street num provided";
        const string DEF_STREET_NAME = "No street name provided";
        const string DEF_SUBURB = "No suburb provided";
        const int DEF_POSTCODE = 0;
        const string DEF_SUBURB = "No suburb provided";

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
