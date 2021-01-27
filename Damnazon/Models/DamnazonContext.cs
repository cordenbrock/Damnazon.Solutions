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
            CategoryDescription = "Shop Jeff Bezos financial assets!",
            ThumbnailImage = "\\img\\assett2.jpg"
          });
          modelBuilder.Entity<Category>().HasData(new Category
          {
            CategoryId = 2,
            CategoryName = "Properties",
            CategoryDescription = "Shop Jeff Bezos properties!",
            ThumbnailImage = "\\img\\properties.jpg"
          });
          modelBuilder.Entity<Category>().HasData(new Category
          {
            CategoryId = 3,
            CategoryName = "Vehicles",
            CategoryDescription = "Shop Jeff Bezos vehicles!",
            ThumbnailImage = "\\img\\vehicles.jpg"
          });
          modelBuilder.Entity<Category>().HasData(new Category
          {
            CategoryId = 4,
            CategoryName = "Items",
            CategoryDescription = "Shop Jeff Bezos personal items!",
            ThumbnailImage = "\\img\\items.jpg"
          });


          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 1,
            ProductName = "Blue Origin",
            ProductPrice = 20000000,
            ProductDescription = "Blue Origin, LLC is an American privately funded aerospace manufacturer and sub-orbital spaceflight services company headquartered in Kent, Washington.",
            Image = "\\img\\blueOrigin.jpg",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = true,
            CategoryId = 1
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 2,
            ProductName = "Washington Post",
            ProductPrice = 250000000,
            ProductDescription = "The Washington Post is an ancient newspaper dating back to 1877, adapting and transforming to fit the modern era. Nowadays, the Post is primarily a popular online news source featuring reliant information and a touch of tradition.",
            Image = "\\img\\washingtonPost.jpg",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = false,
            CategoryId = 1
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 3,
            ProductName = "Whole Foods",
            ProductPrice = 14000000000,
            ProductDescription = "Whole Foods Market, Inc. is an American multinational supermarket chain headquartered in Austin, Texas, which sells products free from hydrogenated fats and artificial colors, flavors, and preservatives.",
            Image = "\\img\\wholeFoods.jpg",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = false,
            CategoryId = 1
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 4,
            ProductName = "Seattle Lake House",
            ProductPrice = 10000000,
            ProductDescription = "One of his most popular homes is this Seattle mansion, located less than a mile from one of Bill Gates's favorite houses.",
            Image = "\\img\\seattleLakehouse.jpg",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = false,
            CategoryId = 2
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 5,
            ProductName = "Largest house in Washington D.C.",
            ProductPrice = 23000000,
            ProductDescription = "The gigantic mansion used to be a textile museum and features a bold, extravagant exterior perfect for a man of Bezos’ stature.",
            Image = "\\img\\largestHouseInDc.jpg",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = false,
            CategoryId = 2
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 6,
            ProductName = "Gulfstream Private Jet",
            ProductPrice = 65000000,
            ProductDescription = "Gulfstream G-650ER one of the fastest in the world, but it’s also all decked out to resemble a Michelin-starred restaurant more than a plane.",
            Image = "\\img\\gulfstreamPrivateJet.jpg",
            IsDamnazonsChoice = false,
            IsDamnazonSlime = true,
            CategoryId = 3
          });

          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 7,
            ProductName = "1997 Honda Accord",
            ProductPrice = 4000,
            ProductDescription = "This was the first car purchase by Amazon boss, This 1997 Honda Accord  four-cylinder engine, air conditioning, AM/FM/cassette radio, automatic transmission, power locks and windows",
            Image = "\\img\\hondaAccord.jpg",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = false,
            CategoryId = 3
          });
          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 8,
            ProductName = "10,000-Year Clock",
            ProductPrice = 42000000,
            ProductDescription = "this clock is unique because it is designed to keep time for 10,000 years. Jeff Bezos invested in this in order to have the means to embody the abstract longevity of time itself",
            Image = "\\img\\clock.jpg",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = false,
            CategoryId = 4
          });
          modelBuilder.Entity<Product>().HasData(new Product
          {
            ProductId = 9,
            ProductName = "Rolex",
            ProductPrice = 200000,
            ProductDescription = "Overly priced Rolex that once belonged to Jeff Bezos.",
            Image = "\\img\\watch.jpg",
            IsDamnazonsChoice = true,
            IsDamnazonSlime = false,
            CategoryId = 4
          });
        }
  }
}
