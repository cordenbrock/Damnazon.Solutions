using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Damnazon.Models
{
  public class CategoryRepository : ICategoryRepository
  {
    private readonly DamnazonContext _db;
    public CategoryRepository(DamnazonContext db)
    {
      _db = db;
    }
    public IEnumerable<Category> GetAllCategories => _db.Categories;
  }
}
    // public IEnumerable<Category> GetAllCategories => new List<Category>
    // {
    //   new Category{CategoryId=1, CategoryName="Assets", CategoryDescription="sdfg"},
    //   new Category{CategoryId=1, CategoryName="Properties", CategoryDescription="sdfdg"},
    //   new Category{CategoryId=1, CategoryName="Vehicles", CategoryDescription="sdfdg"}
    // };