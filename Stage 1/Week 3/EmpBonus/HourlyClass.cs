using System;

namespace EmployeeApp
{
  class Hourly: Employee
    {        

        // This is the automatic property variable.  The get and set methods are being created too.
        public double HourlyRate  // property
            { get; set; }
        

        // This is the default constructor when no values are being passed.
        public Hourly () : base()  // use the parent constructor for the name and rating
        {
            HourlyRate = -1;

        }

        // This is the constructor when three values are passed.
        public Hourly (string FName, string LName, string PayType, double newHourlyRate) : base(FName,LName,PayType) // use the parent constructor for the name and rating
        {
            HourlyRate = newHourlyRate;
        }
        
        // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return base.ToString() + " with an Hourly Rate of $" + HourlyRate;
        }

    }// class Hourly
}// namespace EmployeeApp