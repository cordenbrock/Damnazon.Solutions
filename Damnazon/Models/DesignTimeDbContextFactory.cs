using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Damnazon.Models
{
  public class DamnazonContextFactory : IDesignTimeDbContextFactory<DamnazonContext>
  {
    DamnazonContext IDesignTimeDbContextFactory<DamnazonContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();
      
      var builder = new DbContextOptionsBuilder<DamnazonContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new DamnazonContext(builder.Options);
    }
  }
}