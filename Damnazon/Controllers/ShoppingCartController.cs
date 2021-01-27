using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Damnazon.Models;
using Damnazon.ViewModels;

namespace Damnazon.Controllers
{
  public class ShoppingCartController : Controller
  {
    private readonly IProductRepository _productRepository;
    private readonly ShoppingCart _shoppingCart;
    public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart)
    {
      _productRepository = productRepository;
      _shoppingCart = shoppingCart;
    }

    public ViewResult Index()
    {
      _shoppingCart.ShoppingCartItems = _shoppingCart.GetAllShoppingCartItems();
      var shoppingCartViewModel = new ShoppingCartViewModel
      {
        ShoppingCart = _shoppingCart,
        ShoppingCartTotal = _shoppingCart.GetShoppingCartTotalPrice()
      };
      
      return View(shoppingCartViewModel);
    }
  }  
}