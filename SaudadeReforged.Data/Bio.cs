using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudadeReforged.Data
{
    public class Bio
    {
        [Key]
        public int BioId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

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

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
