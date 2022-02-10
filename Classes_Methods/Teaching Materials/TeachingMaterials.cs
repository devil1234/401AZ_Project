using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401AZ_PROJECT.Classes.Teaching_Materials
{
    public abstract class TeachingMaterials
    {
        public int Teaching_Id { get; set; }
        public string Filename { get; set; }
        public string File_Types_Name { get; set; }
        public string Description { get; set; }
        public byte[] File_Content { get; set; }
        //public int Teacher_id { get; set; } 
    }
}
