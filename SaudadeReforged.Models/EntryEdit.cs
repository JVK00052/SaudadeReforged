using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudadeReforged.Models
{
    public class EntryEdit
    {
        public int EntryId { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }
    }
}
