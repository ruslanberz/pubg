using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Models
{
    public  class FacebookImage
    {
        public Application1 Application { get; set; }
        public Datum1 Datum { get; set; }
        public Paging1 Paging { get; set; }
        public Feed1 Feed { get; set; }
        public RootObject1 RootObject { get; set; }
        public  class Application1
        {
            public string category { get; set; }
            public string link { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public  class Datum1
        {
            public string full_picture { get; set; }
            public string id { get; set; }
            public Application1 application { get; set; }
            public DateTime created_time { get; set; }
            }

        public  class Paging1
        {
            public string previous { get; set; }
            public string next { get; set; }
        }

        public  class Feed1
        {
            public List<Datum1> data { get; set; }
            public Paging1 paging { get; set; }
        }

        public  class RootObject1
        {
            public string id { get; set; }
            public string name { get; set; }
            public Feed1 feed { get; set; }
        }
    }
}
