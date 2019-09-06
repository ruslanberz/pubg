using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Areas.Control.Models
{
    public class DashboardIndex
    {
        public string Id { get; set; }
        public string PubgUsername { get; set; }
        public int Count { get; set; }
        public int? Points { get; set; }
    }
}
