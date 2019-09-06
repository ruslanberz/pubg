﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Areas.Control.Models
{
    public class CreateSliderModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public IFormFile Photo { get; set; }
    }
}
