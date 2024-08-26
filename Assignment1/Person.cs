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
        public const string DEF_NAME = "No name provided";
        public const string DEF_EMAIL = "No email provided";
        public const string DEF_PHONE_NUMBER = "No phone number provided";

        // Property Assessor Method for name 
        public string PersonName { get; set; }        

        // Property Assessor Method for email
        public string PersonEmail { get; set; }

        // Property Assessor Method for phoneNumber
        public string PersonPhoneNumber { get; set; }

        // Property Assessor Method
        public Address PersonAddress { get; set; }

        /// <summary>
        /// Constructor (no args)
        /// </summary>
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER)
        {            
        }

        /// <summary>
        /// Constructor (all args)
        /// </summary>
        /// <param name="name">The persons name</param>
        /// <param name="email">The persons email</param>
        /// <param name="phoneNumber">Home or mobile number</param>
        public Person(string name, string email, string phoneNumber) : this(name, email, phoneNumber, new Address())
        {
        }

        /// <summary>
        /// Inherited constructor
        /// </summary>
        /// <param name="name">The persons name</param>
        /// <param name="email">The persons email</param>
        /// <param name="phoneNumber">Home or mobile number</param>
        /// <param name="address">The full address</param>
        public Person(string name, string email, string phoneNumber, Address address)
        {
            PersonName = name;
            PersonEmail = email;
            PersonPhoneNumber = phoneNumber;            
            PersonAddress = address;
        }
        /// <summary>
        /// To String Method
        /// </summary>
        /// <returns>Returns all person information and address</returns>
        public override string ToString()
        {
            return "\nName: " + PersonName + "\nEmail: " + PersonEmail + "\nPhone Number: " + PersonPhoneNumber + PersonAddress;
        }



    }
}
