using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT
{
    public abstract class Enrolments
    {
        public int Student_ID { get; set; }
        public int Class_ID { get; set; }
        public string Date_Start { get; set; }
        public string Date_End { get; set;}
    }
}
