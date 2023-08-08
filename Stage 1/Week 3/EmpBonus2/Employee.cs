// EmpBonus2 Employee Class

using System;

namespace EmployeeApp
{
    public class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string PayType { get; set; }

        public Employee(string fname, string lname, string paytype)
        {
            this.FName = fname;
            this.LName = lname;
            this.PayType = paytype;
        }
    }
}   