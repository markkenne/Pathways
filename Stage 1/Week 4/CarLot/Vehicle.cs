using System;

namespace VehicleApp
{
  
    class Vehicle  : IConsignRate, IGetCommission
    //class Vehicle : IConsignRate
    {
        public string type  // property
        { get; set; }
        public string make // property
        { get; set; }
        public string model // property
        { get; set; }
        public int year // property
        { get; set; }
        public double price // property
        { get; set; }

 

        public Vehicle()       // default constructor
        {
            type = "";
            make = "";
            model = "";
            year = 0;
            price = 0;
        }

        public Vehicle(string newType, string newMake, string newModel, int newYear, double newPrice)       // another constructor
        {
            type = newType;
            make = newMake;
            model = newModel;
            year = newYear;
            price = newPrice;

        }

       public virtual void SetConsignmentRate(double newConsignmentRate)  // interface method
        {
            // nothing to do here
        } 

        public virtual double GetConsignmentRate()
        {
            // nothing to do here
            return -1;
        }
        public virtual double GetCommission()
        {
            // nothing to do here
            return -1;
        }
 
        public override string ToString()
        {
            return "Vehicle: " + year + ", "  + make + ", "  + model + " | Type: " + type + " | Price: $" + price;
        } 
   } 
}   