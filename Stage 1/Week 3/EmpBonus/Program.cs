using System;

namespace EmployeeApp
{
  class Program
  {
    static void Main(string[] args)
    { 
      Console.WriteLine();
      Employee Emp1 = new Employee();  //default properties test
      Employee Emp2 = new Employee("Mark", "Kenne", "S"); //3 input properties test FName, LName, PayType
      Hourly   Emp3 = new Hourly  ("July", "Smith", "H", 20.00); //4 input properties test FName, LName, PayType and Hourly w output incuding HrlyRate and bonus
      Hourly   Emp4 = new Hourly  ("July", "Smith", "H", 31.55); //4 input properties test FName, LName, PayType and Hourly w output incuding HrlyRate and bonus
      Salary   Emp5 = new Salary  ("Jimmy", "Jones", "S", 100000.00); //4 input properties test FName, LName, PayType and Salary w output incuding Salary and bonus

      Console.WriteLine(Emp1);  // test Employee Class defaullts
      Console.WriteLine(Emp2);  // test Employee Class w three variables
      Console.WriteLine(Emp3);  // test Hourly Class w three variables     
      Console.WriteLine(Emp4);  // test Hourly Class w three variables
      Console.WriteLine(Emp5);  // test Salary Class w four variables

      Console.WriteLine();

    }
  }
}