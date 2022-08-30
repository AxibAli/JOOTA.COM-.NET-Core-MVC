using Joota.com.Models;
using Microsoft.EntityFrameworkCore;

namespace Joota.com.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Shoes> Shoes { get; set; }

        //Orders Related Tables
        public DbSet<Order> Orders  { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

    }
}
