using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Damnazon.Models
{
  public class OrderDetail
  {
    public int OrderDetailId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public Order order { get; set; }
  }
}