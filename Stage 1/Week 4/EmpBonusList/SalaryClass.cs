using System;

namespace EmployeeApp
{

  class Salary: Employee
    {        

 // set a constant for bonus percent
  const double bonusPct = .10;

        // This is the automatic property variable.  The get and set methods are being created too.
        public double SalaryAmt  // property
            { get; set; }
    
        // This is the default constructor when no values are being passed.
        public Salary () : base()  // use the parent constructor for the name and rating
        {
            SalaryAmt = 0;

        }

        // This is the constructor when three values are passed.
        public Salary (string FName, string LName, string PayType, double newSalaryAmt) : base(FName,LName,PayType) // use the parent constructor for the name and rating
        {
            SalaryAmt = newSalaryAmt;
        }
        
        // The following method demonstrates polymorphism.  This is the child class method that overrides the parent
        public override double bonusAmt()
        {
            return SalaryAmt * bonusPct;
        }



        // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
          //  return base.ToString() + " with a Salary of $" + SalaryAmt + " and a Bonus of $"+ SalaryAmt * bonusPct;
            return base.ToString() + ", " + SalaryAmt + ", " + SalaryAmt * bonusPct;
        }

    }// class Hourly
}// namespace EmployeeApp