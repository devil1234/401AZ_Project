using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT
{
    public abstract class Teachers
    {
        public int Teacher_Id { get; set; }
        public string First_Name { get; set; }
        public int Last_Name { get; set; }
        public string Date_Of_Birth { get; set; }
        public string Gender { get; set; }
        public string E_mail { get; set; }
        public int Payroll_Nr { get; set; }
        public string Teacher_Address { get; set; }
    }
}
