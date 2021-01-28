using Damnazon.Models;
using Damnazon.ViewModels;
using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Stripe;

namespace Damnazon.Controllers
{
  [Route("create-payment-intent")]
  [ApiController]
  public class PaymentIntentApiController : Controller
  {
    public IActionResult Create()
    {
      // var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
      // Event stripeEvent = EventUtility.ParseEvent(json);
      // StripeConfiguration.ApiKey = "obfuscated_offline_key";

      // var service = new PaymentIntentService();
      // var model = service.Get("pi_1IEXdVAj6lEpfZJJDBXnNoaX");

      return View();
    }

    [HttpPost]
    public ActionResult Create(PaymentIntentCreateRequest request)
    {
      // Alternatively, set up a webhook to listen for the payment_intent.succeeded event
      // and attach the PaymentMethod to a new Customer
      var customers = new CustomerService();
      var customer = customers.Create(new CustomerCreateOptions());

      var paymentIntents = new PaymentIntentService();
      var paymentIntent = paymentIntents.Create(new PaymentIntentCreateOptions
      {
        Amount = CalculateOrderAmount(request.Items),
        Currency = "usd",
      });
      // _shoppingCart.ClearShoppingCart();
      return Json(new { clientSecret = paymentIntent.ClientSecret });
    }
    private int CalculateOrderAmount(Item[] items)
    {
      // Replace this constant with a calculation of the order's amount
      // Calculate the order total on the server to prevent
      // people from directly manipulating the amount on the client
      return 1400;
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