using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudadeReforged.Models
{
    public class BioEdit
    {
        public int BioId { get; set; }
        public string FullName { get; set; }

        public string NickNames { get; set; }
        public string Birthday { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string Race { get; set; }
        public string Ethnicity { get; set; }
        public string AboutYou { get; set; }
        public string Hobbies { get; set; }
        public string Interests { get; set; }
    }
}
