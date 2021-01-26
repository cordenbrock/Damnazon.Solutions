using System.Collections.Generic;

namespace Damnazon.Models
{
  public class Product
  {
    public int ProductId { get; set;}
    public string ProductName { get; set;}
    public string ProductDescription { get; set;}
    public decimal ProductPrice { get; set;}
    public int CategoryId { get; set; }
    public Category Category { get; set;}
  }
}