using Microsoft.EntityFrameworkCore;
using Task9AspMVCApplication.Core.Models;

namespace Task9AspMVCApplication.Core
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
