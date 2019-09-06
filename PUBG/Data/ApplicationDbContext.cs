using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PUBG.Models;

namespace PUBG.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SkippedUser> SkippedUsers { get; set; }
        public DbSet<Posted> Posteds { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Subscriptions> Subscriptions { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet <GalleryPhotos> GalleryPhotos { get; set; }


    }
}
