using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Damnazon.Models
{
  public interface IProductRepository
  {
    IEnumerable<Product> GetAllProducts { get; }
    IEnumerable<Product> GetDamnazonsChoiceProducts { get; }
    IEnumerable<Product> GetDamnazonSlimeProducts { get; }
    Product GetProductById(int productId);

  }
}