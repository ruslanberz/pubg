using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Models
{
    public class Rule
    {
        public int Id { get; set; }
        [Column(TypeName = "ntext")]
        [Required]
        public string BodyText { get; set; }
    }
}
