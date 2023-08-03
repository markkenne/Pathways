using System;

namespace EmployeeApp
{
 

  class Hourly: Employee
    {        

  // set a constant for bonus hours to pay
  const double bonusHrs = 80;

        // This is the automatic property variable.  The get and set methods are being created too.
        public double HourlyRate  // property
            { get; set; }
        



        // This is the default constructor when no values are being passed.
        public Hourly () : base()  // use the parent constructor for the name and rating
        {
            HourlyRate = 0;

        }

        // This is the constructor when three values are passed.
        public Hourly (string FName, string LName, string PayType, double newHourlyRate) : base(FName,LName,PayType) // use the parent constructor for the name and rating
        {
            HourlyRate = newHourlyRate;
        }
        
        // The following method demonstrates polymorphism.  This is the child class method that overrides the parent
        public override double bonusAmt()
        {
            return HourlyRate * bonusHrs;
        }



        // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return base.ToString() + " with an Hourly Rate of $" + HourlyRate + " and a Bonus of $"+ HourlyRate * bonusHrs;
        }

    }// class Hourly
}// namespace EmployeeApp