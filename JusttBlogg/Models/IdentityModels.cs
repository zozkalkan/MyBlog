using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace JusttBlogg.Models
{
    
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string E_mail { get; set; }
        public DateTime Date { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Photo> Photo { get; set; }

        public DbSet<PhotoPath> PhotoPath { get; set; }


    }
}