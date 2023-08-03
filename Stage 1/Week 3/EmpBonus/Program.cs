using System;

namespace EmployeeApp
{
  class Program
  {
    static void Main(string[] args)
    { 
      Employee Emp1 = new Employee();  //default properties test
      Employee Emp2 = new Employee("Mark", "Kenne", "S"); //3 input properties test FName, LName, PayType
      Console.WriteLine(Emp1);  // test Employee Class defaullts
      Console.WriteLine(Emp2);  // test Employee Class w three variables
      Console.WriteLine();

    }
  }
}