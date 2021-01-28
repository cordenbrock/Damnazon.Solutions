using Damnazon.Models;
using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Stripe;

namespace Damnazon.Controllers
{
  public class OrderController : Controller
  {
    private readonly IOrderRepository _orderRepository;
    private readonly ShoppingCart _shoppingCart;

    public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
    {
      _orderRepository = orderRepository;
      _shoppingCart = shoppingCart;
    }

    public IActionResult Checkout()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Checkout(Models.Order order)
    {
      _shoppingCart.ShoppingCartItems = _shoppingCart.GetAllShoppingCartItems();

      if (_shoppingCart.ShoppingCartItems.Count == 0)
      {
        ModelState.AddModelError("", "Your cart is empty");
      }

      if (ModelState.IsValid)
        {
          _orderRepository.CreateOrder(order);
          
          return RedirectToAction("Create", "PaymentIntentApi");
        }

      return View(order);
    }
    public IActionResult CheckoutComplete()
    {
      ViewBag.CheckoutCompleteMessage = "Thank you for your order. Enjoy your items.";
      return View();
    }
  }
}




