using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT
{
    public abstract class Addresses
    {
        public int Address_Id { get; set; }
        public string Address_Street { get; set; }
        public string Address_City { get; set; }
        public string Address_Region { get; set; }
        public string Address_Postcode { get; set; }
    }
}
