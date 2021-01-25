using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Damnazon.Models
{
  public class ProductRepository : IProductRepository 
  {
    private readonly DamnazonContext _db;

    public ProductRepository(DamnazonContext db)
    {
      _db = db;
    }

    public IEnumerable<Product> GetAllProducts
    {
      get
        {
          return _db.Products.Include(p => p.Category);
        }
    }

    public Product GetProductById(int productId)
    {
      return _db.Products.FirstOrDefault(p => p.ProductId == productId);
    }
  }
}