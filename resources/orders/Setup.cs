using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace resources.Orders {
  public class OrderRoutes 
  {
    public static void Setup(WebApplication app) 
    {
      app.MapGet("/orders", () => OrderData.Orders);
      app.MapGet("/orders/{id}", (int id) => OrderData.Orders.Where(o => o.Id == id).SingleOrDefault());
      app.MapPost("/orders", (Order order) => OrderData.Orders.Add(order));
    }
  }
}