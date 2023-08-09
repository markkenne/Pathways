using System;

namespace VehicleApp
{
interface IConsignRate
{
  void SetConsignmentRate(double newConsignmentRate);  // interface method pass new amount from main, 
                                                       // pass as newConsignmentRate to Passenger, 
                                                       // or ConsignmentRate in Truck to become ConsignmentRate via overide
  double GetConsignmentRate(); // a second interface method
}
}