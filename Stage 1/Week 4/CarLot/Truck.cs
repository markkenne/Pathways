using System;

namespace VehicleApp
{
   // class Passenger : Vehicle, IConsignRate allready implemented in Vehicle so not needed here
    class Truck : Vehicle
    //, IGetCommission
    {
       public double consignmentRate  // property
            { get; set; }


        public Truck() : base()      // default constructor
        {
            consignmentRate =  0;
        }

        public Truck(string newType, string newMake, string newModel, int newYear, double newPrice, double newconsignmentRate) : base (newType, newMake, newModel, newYear, newPrice)       // another constructor
        {
            SetConsignmentRate(newconsignmentRate);
        }

        public override double GetCommission() // interface method
        {
            //return consignmentRate * 60;
            return consignmentRate * price;
        }

        public override void SetConsignmentRate(double newconsignmentRate)  // interface method
        {
            consignmentRate = newconsignmentRate;
        }

        public override double GetConsignmentRate()
        {
            return consignmentRate;
        }

        public override string ToString()
        {
            return base.ToString() + " | consignment rate:" + consignmentRate + " | Commision: $" + GetCommission();
        }

    }
}