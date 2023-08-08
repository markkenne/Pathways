// EmpBonus2 Main Program

using System;

namespace EmployeeApp
{    
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmpArray = new List<Employee>();
            string line;
            StreamReader reader = new StreamReader("Employees.txt");

            for (int i = 0; i < 2; i++)
            {
                line = reader.ReadLine();
                string[] tokens = line.Split(' ');
                string fname = tokens[0];
                string lname = tokens[1];
                string paytype = tokens[3];
                double salary = Convert.ToDouble(tokens[5]);
                double hourlyrate = Convert.ToDouble(tokens[7]);
                double bonus = Convert.ToDouble(tokens[9]);

                if (paytype == "s")
                {
                    EmpArray.Add(new Salary(fname, lname, paytype, salary, bonus));
                }
                else
                {
                    EmpArray.Add(new Hourly(fname, lname, paytype, hourlyrate, bonus));
                }
            }

            foreach (Employee emp in EmpArray)
            {
                Console.WriteLine(emp.FName + " " + emp.LName + " - " + emp.PayType + " with a " + emp.PayType + " of " + emp.CalculateBonus());
            }

            reader.Close();
        }
    }
}
