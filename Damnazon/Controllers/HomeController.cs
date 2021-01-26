using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Damnazon.Models;
using Damnazon.ViewModels;

namespace Damnazon.Controllers
{
  public class HomeController : Controller
  {
    private readonly IProductRepository _productRepository;

    public HomeController(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }
    public IActionResult Index()
    {
      return View(new HomeViewModel
      {
        DamnazonsChoiceProducts = _productRepository.GetDamnazonsChoiceProducts,
        DamnazonSlimeProducts = _productRepository.GetDamnazonSlimeProducts
      });
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
