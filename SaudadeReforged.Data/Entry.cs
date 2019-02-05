using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudadeReforged.Data
{
    public class Entry
    {
        [Key]
        public int EntryId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "Please enter a title that is at LEAST TWO characters long!")]
        [MaxLength(20, ErrorMessage = "Please enter a title that is LESS than TWENTY characters long!")]
        public string Title { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter a topic that is at LEAST TWO characters long!")]
        [MaxLength(20, ErrorMessage = "Please enter a topic that is LESS than TWENTY characters long!")]
        public string Topic { get; set; }

        [Required]
        [MaxLength(8000)]
        public string Content { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter a tag that is at LEAST TWO characters long!")]
        [MaxLength(20, ErrorMessage = "Please enter a tag that is at LESS than TWENTY characters long!")]
        public string Tag { get; set; }


        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
