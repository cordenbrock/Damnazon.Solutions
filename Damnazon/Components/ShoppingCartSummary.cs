using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Damnazon.Models;
using Damnazon.ViewModels;

namespace Damnazon.Components
{
  public class ShoppingCartSummary : ViewComponent
  {
    private readonly ShoppingCart _shoppingCart;

    public ShoppingCartSummary(ShoppingCart shoppingCart)
    {
      _shoppingCart = shoppingCart;
    }

    public IViewComponentResult Invoke()
    {
      _shoppingCart.ShoppingCartItems = _shoppingCart.GetAllShoppingCartItems();
      var shoppingCartViewModel = new ShoppingCartViewModel
      {
        ShoppingCart = _shoppingCart,
        ShoppingCartTotalPrice = _shoppingCart.GetShoppingCartTotalPrice()
      };

      return View(shoppingCartViewModel);
    }
  }
}