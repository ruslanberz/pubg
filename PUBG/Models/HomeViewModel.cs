using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Models
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Blog>  Blogs { get; set; }
        public List<Advertisement> Advertisements { get; set; }
        public List<GalleryPhotos> galleryPhotos { get; set; }
        //basqa nese var?
    }
}
