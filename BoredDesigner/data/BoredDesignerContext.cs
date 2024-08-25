using Microsoft.EntityFrameworkCore;

namespace BoredDesigner
{
    public class BoredDesignerContext : DbContext
    {
        public BoredDesignerContext(DbContextOptions<BoredDesignerContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Moodboard> Moodboards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure only the entities you have
            // Example:
            modelBuilder.Entity<User>()
                .HasMany(u => u.Moodboards)
                .WithOne(mb => mb.User)
                .HasForeignKey(mb => mb.UserId);

            modelBuilder.Entity<Moodboard>()
                .HasOne(mb => mb.User)
                .WithMany(u => u.Moodboards)
                .HasForeignKey(mb => mb.UserId);

            // Remove configurations for removed entities
            // If you need to add any new configurations for other entities, do so here
        }
    }
}
