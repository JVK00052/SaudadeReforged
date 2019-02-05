using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudadeReforged.Models
{
    public class EntryDetail
    {
        public int EntryId { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name="Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
        public override string ToString() => $"[{EntryId}] {Title}";
    }
}
