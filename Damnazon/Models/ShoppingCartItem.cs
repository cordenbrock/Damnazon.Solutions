
// This class might not be needed? Might already be handled by OrderProduct?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Damnazon.Models
{
  public class ShoppingCartItem
  {
    public int ShoppingCartItemId { get; set; }
    public string ShoppingCartId { get; set; }
    public Product Product { get; set; }
    public int TotalPrice { get; set; }
    public List<OrderProduct> OrderProduct { get; set; }
  }
}