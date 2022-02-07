using Microsoft.EntityFrameworkCore;
using TrueHome.Configurations;
using TrueHome.Entities;

namespace TrueHome.Context
{
    public class TrueHomeContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Survey> Surveys { get; set; }

        public TrueHomeContext(DbContextOptions options) : base(options) 
        {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ActivityConfiguration().Configure(modelBuilder.Entity<Activity>());
        }
    }
}
