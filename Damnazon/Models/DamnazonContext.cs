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
            ProductName = "Lorem Blue Origin Stocksum",
            ProductPrice = 5.25M,
            ProductDescription = "Space bugs, everywhere, hurry, buy blue origin stock today, fight cosmic insects!",
            Image = "",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = true,
            CategoryId = 1
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 2,
            ProductName = "Lorem Washerington Pest",
            ProductPrice = 4.10M,
            ProductDescription = "Real news based on real true facts",
            Image = "",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = false,
            CategoryId = 2
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 3,
            ProductName = "Lorem Bezos Bicyclusum",
            ProductPrice = 2.5M,
            ProductDescription = "WOOOOOOOOOOOO",
            Image = "",
            IsDamnazonsChoice = false,
            IsDamnazonSlime = true,
            CategoryId = 3
          });
        }
  }
}
