using Damnazon.Models;
using Damnazon.ViewModels;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using Stripe;

namespace Damnazon.Controllers
{
  [Route("create-payment-intent")]
  [ApiController]
  public class PaymentIntentApiController : Controller
  {
    private readonly IOrderRepository _orderRepository;
    private readonly ShoppingCart _shoppingCart;
    public PaymentIntentApiController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
    {
      _orderRepository = orderRepository;
      _shoppingCart = shoppingCart;
    }
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(PaymentIntentCreateRequest request)
    {
      // Alternatively, set up a webhook to listen for the payment_intent.succeeded event
      // // and attach the PaymentMethod to a new Customer
      // var customers = new CustomerService();
      // var customer = customers.Create(new CustomerCreateOptions());

      var paymentIntents = new PaymentIntentService();
      var amount = _shoppingCart.GetShoppingCartTotalPrice() * 100;
      // var shoppingCartItems = _shoppingCart.GetAllShoppingCartItems();
      var paymentIntent = paymentIntents.Create(new PaymentIntentCreateOptions
      {
        Amount = amount,
        Currency = "usd",
      });
      _shoppingCart.ClearShoppingCart();
      return Json(new { clientSecret = paymentIntent.ClientSecret });
    }
    public class Item
    {
      [JsonProperty("id")]
      public string Id { get; set; }
    }
    public class PaymentIntentCreateRequest
    {
      [JsonProperty("items")]
      public Item[] Items { get; set; }
    }
  }
}