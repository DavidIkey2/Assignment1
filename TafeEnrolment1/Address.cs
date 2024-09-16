using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeEnrolment1
{
    public class Address
    {
        private string streetNum;
        private string streetName;
        private string suburb;
        private string postcode;
        private string state;

        const string DEF_STREET_NUM = "No street num provided";
        const string DEF_STREET_NAME = "No street name provided";
        const string DEF_SUBURB = "No suburb provided";
        const string DEF_POSTCODE = "No postcode provided";
        const string DEF_STATE = "No state provided";

        // Property Assessor Methods
        public string AddressStreetNum { get; set; }
        public string AddressStreetName { get; set; }
        public string AddressSuburb { get; set; }
        public string AddressPostcode { get; set; }
        public string AddressState { get; set; }
        
        /// <summary>
        /// Constructor (no args)
        /// </summary>
        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {
        }

        /// <summary>
        /// Constructor (all args)
        /// </summary>
        /// <param name="streetNum">What street number</param>
        /// <param name="streetName">The street name</param>
        /// <param name="suburb">Suburb or province</param>
        /// <param name="postcode">Post or zip code</param>
        /// <param name="state">State or territory</param>
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            AddressStreetNum = streetNum;
            AddressStreetName = streetName;
            AddressSuburb = suburb;
            AddressPostcode = postcode;
            AddressState = state;
        }
        /// <summary>
        /// To String Method
        /// </summary>
        /// <returns>All address information</returns>
        public override string ToString()
        {
            return "\nStreet Num: " + AddressStreetNum + "\nStreet Name: " + AddressStreetName + "\nSuburb: " + AddressSuburb + "\nPostcode: " + AddressPostcode + "\nState: " + AddressState;
        }


    }
}
