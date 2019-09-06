using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public string Title { get; set; }
        public string UniqueID { get; set; }
        public string  BodyText { get; set; }
        public string Image { get; set; }
    }
}
