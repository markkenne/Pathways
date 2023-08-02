// Program.cs   Used to test Objects and Constructs  mk 8/1/23

using System;

namespace Cars
{
    class Program
  {
     // Main program
    static void Main(string[] args)

     {

      // call make and price constructor
      Car car1 = new Car("Bugatti", 50000);
      Console.WriteLine("Make: " + car1.Make);
      Console.WriteLine("Price: " + car1.Price);

      Car car2 = new Car("Green");
      Console.WriteLine("Color: " + car2.Color);

      Car car3 = new Car(1973,"Ford", "Pinto", "Tan", 200);
      Console.WriteLine("Best Value: " + car3.Year + " " + car3.Make+ " " + car3.Model+ " " + car3.Color+ " " + car3.Price);
     }

  }
}


      // Car myCar2 = new Car("green","CRV");

     // Car myCar2 = new Car("green","CRV");
      
//      Console.WriteLine(myCar1.getColor());
//      Console.WriteLine(myCar1.getModel());    

   //   Console.WriteLine(myCar2);
   //   Console.WriteLine(myCar2.getModel());      

//      myCar1.setColor("red");
//      myCar1.setModel("Mustang");

   //   Console.WriteLine(myCar1.getColor());
   //   Console.WriteLine(myCar1.getModel());          
    



