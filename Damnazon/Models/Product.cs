using System.Collections.Generic;

namespace Damnazon.Models
{
  public class Product
  {
    public int ProductId { get; set;}
    public string ProductName { get; set;}
    public string ProductDescription { get; set;}
    public decimal ProductPrice { get; set;}
    public string Image { get; set; }
    public bool IsDamnazonsChoice { get; set; }
    public bool IsDamnazonSlime { get; set; }
    public bool IsInStock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set;}
  }
}