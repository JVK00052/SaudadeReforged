using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudadeReforged.Models
{
    public class BioCreate
    {
        [Required]
        public string FullName { get; set; }
        public string NickNames { get; set; }
        [Required]
        public string Birthday { get; set; }
        [Required]
        public int Age { get; set; }
        public string Gender { get; set; } //Make an Enum
        public string Location { get; set; }
        public string Race { get; set; }
        public string Ethnicity { get; set; }
        [Required]
        public string AboutYou { get; set; }
        public string Interests { get; set; }
        public string Hobbies { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
