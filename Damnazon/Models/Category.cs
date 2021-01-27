using System.Collections.Generic;

namespace Damnazon.Models
{
  public class Category
  {
    public int CategoryId { get; set;}
    public string CategoryName { get; set;}
    public string CategoryDescription { get; set;}
    public string ThumbnailImage { get; set; }
    public List<Product> Products { get; set; }
  }
}