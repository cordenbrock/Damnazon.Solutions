using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Damnazon.Models
{
  public class DamnazonContext : IdentityDbContext<ApplicationUser>
  {
    public DamnazonContext(DbContextOptions<DamnazonContext> options) : 
        base(options) 
    { 
    }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<OrderProduct> OrderProduct { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          base.OnModelCreating(modelBuilder);

          modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Assets", CategoryDescription = "This is a tab for all of Jeff Bezos finacial assets." });
          modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Properties", CategoryDescription = "This is a tab for all of Jeff Bezos properties." });
          modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Vehicles", CategoryDescription = "This is a tab for all of Jeff Bezos vehicles." });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 1,
            ProductName = "",
            ProductPrice = 5.25M,
            ProductDescription = "",
            CategoryId = 1
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 2,
            ProductName = "",
            ProductPrice = 4.10M,
            ProductDescription = "",
            CategoryId = 2
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 3,
            ProductName = "",
            ProductPrice = 2.5M,
            ProductDescription = "",
            CategoryId = 3
          });
        }
  }
}
