// Name EmployeeClass.cs for use in EmployeeBonus program
// Class Description: Create a private method for retrieving data for Employee. 
//                    This is a parent class to HourlyClass and SalaryClass which are used to return additional data and calculate bonuses.

using System;

namespace EmployeeApp
{
  class Employee
    {        
        // Three pieces of data are being stored for each object
        // FName is a string value the employee first name
        // LName is a string value for employee last name
        // PayType is a string value for storing (H)ourly or (S)alary. Null indicates neither.
        // FName, LName, and PayType will be an automatic properties.

        // This is the instance variable so it must be declared.

        // It's private so only methods of the object can access it.
        // private string RName;  // restaurant name

        // This is the automatic property variable FName.
        public string FName  // property
            { get; set; }
        

        // This is the automatic property variable for LName. 
        public string LName  // property
            { get; set; }

        // This is the automatic property variable for PayType. 
        public string PayType  // property
            { get; set; }       



        // This is the default constructor when no values are being passed.
        public Employee ()
        {
            FName = null;
            LName = null;
            PayType = "";
        }

        // This is the constructor when two values are passed.
        public Employee (string newFName, string newLName, string newPayType)
        {
            FName = newFName;
            LName = newLName;
            PayType = newPayType;
        }
       

        // The following method demonstrates polymorphism.  This is the parent class method
        public virtual double bonusAmt()
        {
            return 0;  // those employees that are neither H or S Type
        }




               // This overrides ToString so an object can be printed out with the WriteLine.
          

        public override string ToString()
        {
            return "Employee: " + LName + ", " + FName + "  -  Pay Type: " + PayType;
        }

    }// class Employee
}// namespace EmployeeApp
