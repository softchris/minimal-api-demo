using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using resources.Orders;
using resources.People;

namespace Routes
{
    public class RoutesBuilder 
    {
      public static void Setup(WebApplication app) 
      {
        OrderRoutes.Setup(app);
        PeopleRoutes.Setup(app);  
      }
    }
}