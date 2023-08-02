﻿using System;

namespace restaurantAPP
{
  class Program
  {
    static void Main(string[] args)
    { 
      Restaurant R1 = new Restaurant();
      Restaurant R2 = new Restaurant("Misty's", 4);
      Console.WriteLine(R1);  // test Rest Class defaullts
      Console.WriteLine(R2);  // test Rest w two variables
      Console.WriteLine();

    }
  }
}