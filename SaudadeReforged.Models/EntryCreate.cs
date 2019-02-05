using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudadeReforged.Models
{
    public class EntryCreate
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Topic { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Tag { get; set; }

        public override string ToString() => Title;
    }
}
