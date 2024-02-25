using Microsoft.EntityFrameworkCore;

namespace spms.Models;



public class SiteDbContext : DbContext
{
        public SiteDbContext(DbContextOptions<SiteDbContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses {get; set;}
}
