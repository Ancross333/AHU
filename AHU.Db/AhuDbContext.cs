using Ahu.Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Ahu.Db
{
    public class AhuDbContext : DbContext
    {

        public AhuDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //TODO: Configure options and remove hardcoded value
            optionsBuilder.UseNpgsql("Host=localhost;Database=ahu;Username=postgres;Password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}
