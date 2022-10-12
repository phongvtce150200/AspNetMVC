using Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.DB
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public ApplicationDBContext() { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderDetail>().HasKey(table => new
            {
                table.OrderId,
                table.ProductId
            });
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}