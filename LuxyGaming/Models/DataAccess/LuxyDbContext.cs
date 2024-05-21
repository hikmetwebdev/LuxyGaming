using LuxyGaming.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LuxyGaming.Models.DataAccess
{
    public class LuxyDbContext: DbContext
    {
        public LuxyDbContext(DbContextOptions<LuxyDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<MainGame> MainGames { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Price)
                      .HasColumnType("decimal(18,2)");
                entity.Property(e => e.Discount)
                      .HasColumnType("decimal(18,2)");
            });
        }

      
    }
}
