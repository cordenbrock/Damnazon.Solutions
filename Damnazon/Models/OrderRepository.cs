using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Damnazon.Models
{
  public class OrderRepository : IOrderRepository
  {
    private readonly DamnazonContext _db;
    private readonly ShoppingCart _shoppingCart;

    public OrderRepository(DamnazonContext db, ShoppingCart shoppingCart)
    {
      _db = db;
      _shoppingCart = shoppingCart;
    }

    public void CreateOrder(Order order)
    {
      order.OrderPlaced = DateTime.Now;
      order.OrderTotal = _shoppingCart.GetShoppingCartTotalPrice();
      _db.Orders.Add(order);
      _db.SaveChanges();
    
    var shoppingCartItems = _shoppingCart.GetAllShoppingCartItems();

    foreach(var shoppingCartItem in shoppingCartItems)
    {
      var orderDetail = new OrderDetail
      {
        Quantity = shoppingCartItem.Quantity,
        Price = shoppingCartItem.Product.ProductPrice,
        ProductId = shoppingCartItem.Product.ProductId,
        OrderId = order.OrderId
      };

      _db.OrderDetails.Add(orderDetail);
    }

    _db.SaveChanges();
    }
  }
}