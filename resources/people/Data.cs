using System;
using System.Collections.Generic;
using System.Linq;

namespace resources.People {
  public class PeopleData 
  {
    static PeopleData() 
    {
      People = new List<People>(){ 
        new People { Id = 1, Name = "Chris" },
        new People { Id = 2, Name = "Jon" } 
      };
    }
    public static IList<People> People { get; set; }
  } 
}