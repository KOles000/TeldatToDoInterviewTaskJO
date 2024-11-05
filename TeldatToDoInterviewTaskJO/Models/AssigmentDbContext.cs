using Microsoft.EntityFrameworkCore;

namespace TeldatToDoInterviewTaskJO.Models
{
    public class AssigmentDbContext : DbContext
    {
        public AssigmentDbContext(DbContextOptions<AssigmentDbContext> options) : base(options) { }

        public DbSet<Assigment> Assigments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assigment>(builder =>
            {
                builder.HasKey(p => p.AssigmentId);
                builder.Property(p => p.AssigmentName).IsRequired();
                builder.Property(p => p.AssigmentDate).IsRequired();
            });
        }
    }
}
