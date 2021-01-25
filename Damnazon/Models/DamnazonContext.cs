using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Damnazon.Models
{
  public class DamnazonContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<OrderProduct> OrderProduct { get; set; }
    public DamnazonContext(DbContextOptions options) : base(options) { }
  }
}