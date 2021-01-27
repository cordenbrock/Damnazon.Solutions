using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Damnazon.Models
{
  public class ShoppingCart
  {
    private readonly DamnazonContext _db;
    public string OrderProductGuid { get; set; } // Trying OrderProduct; might need to change to shoppingCartItem if it doesn't work
    public List<OrderProduct> OrderProduct { get; set; }
    public ShoppingCart(DamnazonContext db)
    {
      _db = db;
    }

    public static ShoppingCart GetCart(IServiceProvider services)
    {
      ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

      var context = services.GetService<DamnazonContext>();
      string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
      session.SetString("CartId", cartId);

      return new ShoppingCart(context) { OrderProductGuid = cartId };
    }

    public void AddToCart(Product product, int quantity) {
      var orderProduct = _db.OrderProduct.SingleOrDefault(
        s => s.Product.ProductId == product.ProductId && s.OrderProductGuid == OrderProductGuid);

      if(orderProduct == null)
      {
        orderProduct = new OrderProduct
        {
          OrderProductGuid = OrderProductGuid,
          Product = product,
          Quantity = quantity
        };
      }
      else
      {
        orderProduct.Quantity++;
      }

      _db.SaveChanges();
    }

    // public int RemoveFromCart(Product product)
    // {
    //   var orderProduct = _db.OrderProduct.SingleOrDefault(
    //     s => s.Product.ProductId == product.ProductId && s.OrderProductGuid == OrderProductGuid);
      
    //   var localQuantity = 0;

    //   if(orderProduct != null)
    //   {
    //     if(orderProduct.Quantity > 1)
    //     {
    //       orderProduct.Quantity--;
    //       localQuantity = orderProduct.Quantity;
    //     }
    //     else
    //     {

    //     }
    //   }
    // }
  }
}