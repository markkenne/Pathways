// EmpBonus2 Hourly Class
using System;

namespace EmployeeApp
{    
    public class Hourly : Employee
    {
        public double HourlyRate { get; set; }
        public double Bonus { get; set; }

        public Hourly(string fname, string lname, string paytype, double hourlyrate, double bonus) : base(fname, lname, paytype)
        {
            this.HourlyRate = hourlyrate;
            this.Bonus = bonus;
        }

        public double CalculateBonus()
        {
            if (this.PayType == "h")
            {
                return this.HourlyRate * 40 * 0.1;
            }
            else
            {
                return 0;
            }
        }
    }
}    