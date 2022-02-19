using System;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class Person.
    /// </summary>
    public class Person 
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the dob.
        /// </summary>
        /// <value>The dob.</value>
        public DateTime Dob { get; set; }
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>The gender.</value>
        public string Gender { get; set; }
        /// <summary>
        /// Gets or sets the e mail address.
        /// </summary>
        /// <value>The e mail address.</value>
        public string EMailAddress { get; set; }
        /// <summary>
        /// Gets or sets the parent identifier.
        /// </summary>
        /// <value>The parent identifier.</value>
        public int ParentId { get; set; }
        /// <summary>
        /// Gets or sets the name of the parent f.
        /// </summary>
        /// <value>The name of the parent f.</value>
        public string ParentFName { get; set; }
        /// <summary>
        /// Gets or sets the name of the parent l.
        /// </summary>
        /// <value>The name of the parent l.</value>
        public string ParentLName { get; set; }
        /// <summary>
        /// Gets or sets the parent phone number.
        /// </summary>
        /// <value>The parent phone number.</value>
        public string ParentPhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets the address identifier.
        /// </summary>
        /// <value>The address identifier.</value>
        public int AddressId { get; set; }
        /// <summary>
        /// Gets or sets the address street.
        /// </summary>
        /// <value>The address street.</value>
        public string AddressStreet { get; set; }
        /// <summary>
        /// Gets or sets the address city.
        /// </summary>
        /// <value>The address city.</value>
        public string AddressCity { get; set; }
        /// <summary>
        /// Gets or sets the address region.
        /// </summary>
        /// <value>The address region.</value>
        public string AddressRegion { get; set; }
        /// <summary>
        /// Gets or sets the address postcode.
        /// </summary>
        /// <value>The address postcode.</value>
        public string AddressPostcode { get; set; }

    }
}