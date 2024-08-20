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

        //  Constructor (no args)
        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {
        }

        //  Constructor (all args)
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            AddressStreetNum = streetNum;
            AddressStreetName = streetName;
            AddressSuburb = suburb;
            AddressPostcode = postcode;
            AddressState = state;
        }

        public override string ToString()
        {
            return "Street Num: " + AddressStreetNum + " Street Name: " + AddressStreetName + " Suburb: " + AddressSuburb + " Postcode: " + AddressPostcode + "";
        }


    }
}
