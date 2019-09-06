using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Models
{
    public class Posted
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ImagePath { get; set; }
        public string ApplicationUserId { get; set; }
        public int SeasonId { get; set; }
        public Nullable<int> Point { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public Season Season { get; set; }
    }
}
