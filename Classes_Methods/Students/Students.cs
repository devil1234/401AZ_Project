using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT
{

    public abstract class Students : StudentParentsDetails
    {
        public int StudentId { get; set; }
        public string Student_First_Name { get; set; }
        public string Student_Last_Name { get; set; }
        public string Student_Date_Of_Birth { get; set; }
        public string Student_Gender { get; set; }
        public byte[] Student_Picture { get; set; }
        public string Student_E_Mail_Address { get; set; }
        public string Student_Parent_Full_Name { get; set; }

        //public int Address_Id { get; set; }
        public Addresses Address { get; set; }


    }
}
