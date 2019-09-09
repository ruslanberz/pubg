using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUBG.Models
{
    
        public class ApplicationUser : IdentityUser
        {
            public string Fullname { get; set; }
            public DateTime CreationDate { get; set; }
            public DateTime PreviousLogin { get; set; }
            public DateTime LastLogin { get; set; }
            public string PubgUsername { get; set; }

            public bool IsBanned { get; set; }
            public Season Season { get; set; }
            public virtual ICollection<Posted>Posteds { get; set; }
            public virtual ICollection<SkippedUser> SkippedUsers{ get; set; }
            public DateTime BirthDate { get; set; }
            public bool Gender { get; set; }
           public string MobileNumber { get; set; }
        public int Money { get; set; }
        public int Bonus { get; set; }

    }
    
}
