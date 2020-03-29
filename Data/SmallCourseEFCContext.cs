using Microsoft.EntityFrameworkCore;
using smallCourseEFC.Model;

namespace smallCourseEFC.Data
{
  public class SmallCourseEFCContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductOrder> ProductOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=smallCourseEFC.db");
    }
  }
}