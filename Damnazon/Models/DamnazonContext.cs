using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Damnazon.Models
{
  public class DamnazonContext : IdentityDbContext<ApplicationUser>
  {
    public DamnazonContext(DbContextOptions<DamnazonContext> options) : 
        base(options) {}

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          base.OnModelCreating(modelBuilder);

          modelBuilder.Entity<Category>().HasData(new Category 
          { 
            CategoryId = 1,
            CategoryName = "Assets", 
            CategoryDescription = "This is a tab for all of Jeff Bezos finacial assets.",
            ThumbnailImage = "\\img\\asset.jpg"
          });
          modelBuilder.Entity<Category>().HasData(new Category
          {
            CategoryId = 2,
            CategoryName = "Properties",
            CategoryDescription = "This is a tab for all of Jeff Bezos properties.",
            ThumbnailImage = "\\img\\seattleLakehouse.jpg"
          });
          modelBuilder.Entity<Category>().HasData(new Category
          {
            CategoryId = 3,
            CategoryName = "Vehicles",
            CategoryDescription = "This is a tab for all of Jeff Bezos vehicles.",
            ThumbnailImage = "\\img\\hondaAccord.jpg"
          });


          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 1,
            ProductName = "Lorem Blue Origin Stocksum",
            ProductPrice = 5.25M,
            ProductDescription = "Space bugs, everywhere, hurry, buy blue origin stock today, fight cosmic insects!",
            Image = "\\img\\blueOrigin.jpg",
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
            Image = "\\img\\washingtonPost.jpg",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = false,
            CategoryId = 2
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 3,
            ProductName = "Lorem Bezos Jetticus jettison",
            ProductPrice = 2.5M,
            ProductDescription = "WOOOOOOOOOOOO",
            Image = "\\img\\gulfstreamPrivateJet.jpg",
            IsDamnazonsChoice = false,
            IsDamnazonSlime = true,
            CategoryId = 3
          });
        }
  }
}
