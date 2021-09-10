using System;
namespace resources.Orders 
{
  public record Order 
  {
    public int Id { get; set; } 
    public DateTime Created { get; set; }
  }
}