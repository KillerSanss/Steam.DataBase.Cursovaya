using Microsoft.EntityFrameworkCore;
using steam.Infrastructure.Entities;


namespace steam.Infrastructure.Context
{
    /// <summary>
    /// Класс контектса
    /// </summary>
    public class SteamDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        
        public SteamDbContext(DbContextOptions<SteamDbContext> options) : base(options)
        {
        }
        public SteamDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Steam;Username=postgres;Password=7733");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.User)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Question>()
                .HasOne(q => q.User)       
                .WithMany(u => u.Questions)
                .HasForeignKey(q => q.UserId);

            modelBuilder.Entity<Question>()
                .HasOne(q => q.Admin)
                .WithMany(a => a.Questions)
                .HasForeignKey(q => q.AdminId);

            modelBuilder.Entity<User>()
                .HasOne(c => c.Card);
        }
    }
}
