using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Areas.Control.Models
{
    public class EditModelBlog:CreateModelBlog
    {

        public string ExistPhotoPath { get; set; }
    }
}
