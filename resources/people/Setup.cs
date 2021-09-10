using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace resources.People {
  public class PeopleRoutes 
  {
    public static void Setup(WebApplication app) 
    {
      app.MapGet("/people", () => PeopleData.People);
      app.MapGet("/people/{id}", (int id) => PeopleData.People.Where(o => o.Id == id).SingleOrDefault());
      app.MapPost("/people", (People people) => PeopleData.People.Add(people));
    }
  }
}