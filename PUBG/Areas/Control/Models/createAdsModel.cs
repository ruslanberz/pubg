using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Areas.Control.Models
{
    public class createAdsModel
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public string Title { get; set; }
        public string UniqueID { get; set; }
        public string BodyText { get; set; }
        public IFormFile  Image { get; set; }
    }
}
