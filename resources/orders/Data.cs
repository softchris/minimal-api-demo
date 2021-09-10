using System;
using System.Collections.Generic;
using System.Linq;

namespace resources.Orders {
  public class OrderData 
  {
    static OrderData() 
    {
      Orders = new List<Order>(){ 
        new Order{ Id = 1, Created = DateTime.Now },
        new Order{ Id = 2, Created = DateTime.Now } 
      };
    }
    public static IList<Order> Orders { get; set; }
  } 
}