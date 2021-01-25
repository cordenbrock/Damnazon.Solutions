using System.Collections.Generic;

namespace Damnazon.Models
{
  public interface ICategoryRepository
  {
    IEnumerable<Category> GetAllCategories { get; }
  }
}