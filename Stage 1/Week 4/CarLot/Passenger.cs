using System;

namespace VehicleApp
{
   // class Passenger : Vehicle, IConsignRate  this is in Vehicle already so no need to implement here
    class Passenger : Vehicle
    //, IGetCommission
    {
       public double consignmentRate  // property
            { get; set; }


        public Passenger() : base()      // default constructor
        {
            consignmentRate =  0;
        }

        public Passenger(string newType, string newMake, string newModel, int newYear, double newPrice, double newconsignmentRate) : base (newType, newMake, newModel, newYear, newPrice)       // another constructor
        {
            SetConsignmentRate(newconsignmentRate);
        }

        public override double GetCommission() // interface method
        {
           // return consignmentRate * 80;
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