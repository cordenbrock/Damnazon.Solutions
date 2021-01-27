using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Damnazon.Models;

namespace Damnazon.ViewModels
{
  public class HomeViewModel
  {
    public IEnumerable<Product> DamnazonsChoiceProducts { get; set; }
    public IEnumerable<Product> DamnazonSlimeProducts { get; set; }
    public IEnumerable<Category> Categories { get; set; }
  }
}