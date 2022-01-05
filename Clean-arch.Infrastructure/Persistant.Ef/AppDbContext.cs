using Clean_arch.Domain.OrderAgg;
using Clean_arch.Domain.Orders;
using Clean_arch.Domain.ProductAgg;
using Clean_arch.Domain.Products;
using Clean_arch.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Clean_arch.Infrastructure.Persistant.Ef
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>().OwnsOne(b => b.Price, option =>
            {
                option.Property(b => b.RialValue)
                 .HasColumnName("RialPrice");
            });
            modelBuilder.Entity<Product>().OwnsOne(b => b.Money);
            modelBuilder.Entity<User>().OwnsOne(b => b.PhoneNumber);

            base.OnModelCreating(modelBuilder);
        }
    }
}
