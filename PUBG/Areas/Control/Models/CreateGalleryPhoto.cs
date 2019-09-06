using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Areas.Control.Models
{
    public class CreateGalleryPhoto
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public IFormFile Photo { get; set; }
    }
}
