// EmpBonus2 Salary Class

using System;

namespace EmployeeApp
{    
    public class Salary : Employee
    {
        public double Salary { get; set; }
        public double HrBonus { get; set; }

        public Salary(string fname, string lname, string paytype, double salary, double bonus) : base(fname, lname, paytype)
        {
            this.Salary = salary;
            this.HrBonus = bonus;
        }

        public double CalculateBonus()
        {
            if (this.PayType == "s")
            {
                return this.Salary * 0.1;
            }
            else
            {
                return 0;
            }
        }
    }
}    