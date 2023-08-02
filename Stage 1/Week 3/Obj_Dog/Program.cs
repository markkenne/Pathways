
// C# program to illustrate the
// Initialization of an object
using System;
 
namespace Dogs
{
    class Program
      {     
    
 
       // Main Method
        static void Main(String[] args)
     {
         
        // Creating object
        Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
    //    Dog Scarlet = new Dog("Minature Australian Shepherd");
        Console.WriteLine(tuffy.ToString());
    //    Console.WriteLine(Scarlet.GetBreed());
     }
  }
}

