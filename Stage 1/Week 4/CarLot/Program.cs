// CarLot application 
using System;
using System.Collections.Generic;   // needed for Lists

namespace VehicleApp
{
  class Program
  {
    static void Main(string[] args)
    { 

        // Create a list of Vehicles
        List<Vehicle> vehicleList = new List<Vehicle>();

        // Add a couple of Vehicles to the list to test
        vehicleList.Add(new Vehicle ("Car", "Ford", "Mustang", 2020, 38000));
        vehicleList.Add(new Vehicle ("Truck", "Ford", "F-150", 2010, 18000));    
       // vehicleList.Add(new Vehicle()); // test default

       // Add a couple of Passenger vehicles to the list to test
        vehicleList.Add(new Passenger ("Car", "Toyota", "Prius", 2010, 12000, .20));
        vehicleList.Add(new Passenger ("Car", "Ford", "Focus", 2012, 8000, .20));    
        vehicleList.Add(new Passenger()); // test default

       // Add a couple of Truck vehicles to the list to test
        vehicleList.Add(new Truck ("Truck", "Toyota", "Tundra", 2016, 22000, .10));
        vehicleList.Add(new Truck ("Truck", "Chevy", "Colorado", 2014, 16000, .10));    
        vehicleList.Add(new Truck()); // test default


       
        // Print the list
        foreach (Vehicle aVehicle in vehicleList)
        {
            Console.Write(aVehicle);
            Console.WriteLine(", and by the way, Commission was " + aVehicle.GetCommission());
        }  // end foreach  


    }
}  // end of class program
} //end of namespace
