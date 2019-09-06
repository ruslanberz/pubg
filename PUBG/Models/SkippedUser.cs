using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Models
{
    public class SkippedUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SeasonId { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Season Season { get; set; }
    }
}
