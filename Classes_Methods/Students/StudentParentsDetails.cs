using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT
{
    public abstract class StudentParentsDetails
    {
        public int Student_Parent_Id { get; set; }
        public string Parent_First_Name { get; set; }
        public string Parent_Last_Name { get; set; }
        public string Parent_Phone_Number_Type { get; set; }
        public string Parent_Phone_Number_Main { get; set; }
        public string Parent_Phone_Number_Home { get; set; }
        public string Parent_Phone_Number_Mobile { get; set; }
    }
}
