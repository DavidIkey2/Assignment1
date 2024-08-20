using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Person
    {
        private string name;
        private string email;
        private string phoneNumber;
        const string DEF_NAME = "No name provided";
        const string DEF_EMAIL = "No email provided";
        const string DEF_PHONE_NUMBER = "No phone number provided";

        // Property Assessor Method for name 
        public string PersonName { get; set; }        

        // Property Assessor Method for email
        public string PersonEmail { get; set; }

        // Property Assessor Method for phoneNumber
        public string PersonPhoneNumber { get; set; }

        //  Constructor (no args)
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER)
        {            
        }

        //  Constructor (all args)
        public Person(string name, string email, string phoneNumber)
        {
            PersonName = name;
            PersonEmail = email;
            PersonPhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return "name: " + PersonName + " email: " + PersonEmail + " phone number: " + PersonPhoneNumber;
        }



    }
}
