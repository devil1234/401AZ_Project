using System;

namespace _401AZ_PROJECT.Models
{
    public class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string EMailAddress { get; set; }
        public int ParentId { get; set; }
        public string ParentFName { get; set; }
        public string ParentLName { get; set; }
        public string ParentPhoneNumber { get; set; }
        public int AddressId { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressRegion { get; set; }
        public string AddressPostcode { get; set; }

    }
}