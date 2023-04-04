using EcommerceWithAngular.web.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWithAngular.web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> OrderItems { get;set; }
        public DbSet<Customer> CustomerItems { get; set; }
        public DbSet<Category> CategoryItems { get; set; }
        public DbSet<OrderLine> OrderLineItems { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
