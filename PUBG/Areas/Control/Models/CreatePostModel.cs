using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Areas.Control.Models
{
    public class CreatePostModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public IFormFile ImagePath { get; set; }
        public string ApplicationUserId { get; set; }
        public int SeasonId { get; set; }
        public Nullable<int> Point { get; set; }
    }
}
