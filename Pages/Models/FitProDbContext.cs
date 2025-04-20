using Microsoft.EntityFrameworkCore;

namespace FitProGymManager.Models
{
    public class FitProDbContext : DbContext
    {
        public FitProDbContext(DbContextOptions<FitProDbContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; } = null!;
        public DbSet<MembershipPlan> MembershipPlans { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MembershipPlan>()
                .HasIndex(p => p.PlanName)
                .IsUnique();
        }
    }
}

