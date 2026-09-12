using Microsoft.EntityFrameworkCore;
using TshuduCV.Models;

namespace TshuduCV.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserProfile> UserProfiles => Set<UserProfile>();
        public DbSet<ProjectItem> Projects => Set<ProjectItem>();
        public DbSet<WorkExperience> Experiences => Set<WorkExperience>();
    }
}