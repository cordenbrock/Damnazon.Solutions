using System.Collections.Generic;

namespace Damnazon.Models
{
  public class Category
  {
    // public Category()
    // {
    //   this.JoinEntries = new HashSet<Product>();
    // }
    public int CategoryId { get; set;}
    public string CategoryName { get; set;}
    public string CategoryDescription { get; set;}

    public List<Product> Products { get; set; }

    //public virtual ICollection<Product> JoinEntries { get; set; }
  }
}