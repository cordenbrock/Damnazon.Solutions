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

    public OrderRepository(DamnazonContext db)
    {
      _db = db;
    }

    public void CreateOrder(Order order)
    {
      _db.Orders.Add(order);
      _db.SaveChanges();

    }
  }
}

// later note: Shopping cart integration w/ this model