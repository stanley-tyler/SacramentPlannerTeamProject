using SacramentMeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace SacramentMeetingPlanner.Data
{
    public class ChurchContext : DbContext
    {
        public ChurchContext(DbContextOptions<ChurchContext> options) : base(options)
        {
        }

        public DbSet<Sacrament> Sacrament { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sacrament>().ToTable("Sacrament");
        }
    }
}
