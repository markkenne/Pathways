/* Employee Bonus Calculator
   Programmer: Mark Kenne
   Last Update:  08/03/2023
   Program Description -  Demonstrate use of Class inheritance and polymorphism using a parent class of Employee and two child Classes (Hourly and Salary).
  
   Requirements:                      
  (1) An array of Employees with a length of 25
  (2) Array holds values of Employee's first name, last name, and Pay Type in each case and a pay rate or amount based on PayType
  (3) Ability to calculate the annual bonus based on the Type. If H then 80 hours times rate, if Salary then 10% of salary amount
  (4) Ability to print the hourly rate or salary amount with bonus using the ToString method
  (5) A menu to operate the CRUD method (Create, Read, Update, and Delete) in regards to the array.
  (6) A menu item Q to exit the program
  (7) A procedure to Create a new row in the array
  (8) A procedure to Read all rows in the array and print them without showing null rows
  (9) A procedure to Update a row in the array
  (10) A procedure to Delete a row in the array
  (11) A procedure to Initialize the array and create all rows with null values 
  (12) Optional procedure to Load the data array from a text file
  (13) Optional procedure to Save the data array to a text file



*/
using System;

namespace EmployeeApp
{
  class Program
  {
    static void Main(string[] args)
    { 
    
// Test the three Classes - Employee parent and child Hourly and child Salary     
      Console.WriteLine();
      Employee Emp1 = new Employee();  //default properties test Employee
      Employee Emp2 = new Employee("Mark", "Kenne", "S"); //3 input properties test FName, LName, PayType
      Hourly   Emp6 = new Hourly(); //default properties test Hourly
      Hourly   Emp3 = new Hourly  ("July", "Smith", "H", 20.00); //4 input properties test FName, LName, PayType and Hourly w output incuding HrlyRate and bonus
      Hourly   Emp4 = new Hourly  ("Mary", "Kay", "H", 31.55); //4 input properties test FName, LName, PayType and Hourly w output incuding HrlyRate and bonus
      Salary   Emp7 = new Salary(); //default properties test Salary      
      Salary   Emp5 = new Salary  ("Jimmy", "Jones", "S", 100000.00); //4 input properties test FName, LName, PayType and Salary w output incuding Salary and bonus

      Console.WriteLine(Emp1);  // test Employee Class defaullts
      Console.WriteLine(Emp2);  // test Employee Class w three variables
      Console.WriteLine(Emp3);  // test Hourly Class w three variables     
      Console.WriteLine(Emp4);  // test Hourly Class w three variables
      Console.WriteLine(Emp5);  // test Salary Class w four variables
      Console.WriteLine(Emp6);  // test Hourly Class defaullts
      Console.WriteLine(Emp7);  // test Salary Class defaullts
     
      Console.WriteLine();

        // Declare and instantiate the array of Restaurant objects
        Employee[] EmpArray=new Employee[25];
// Create an array of employees and initialize
        for (int index = 0; index < EmpArray.Length; index++)
        {
            EmpArray[index] = new Employee();
        }

        // Load in some test data to test both ways to assign values

        EmpArray[1] = Emp1;
        EmpArray[2] = Emp2;
        EmpArray[3] = Emp3;
        EmpArray[4] = Emp4;
        EmpArray[5] = Emp5;
        EmpArray[6] = Emp6;


        // print each Employee to test the property gets and the toString

        for (int index = 0; index < EmpArray.Length; index++)
        {
            if (!((EmpArray[index].LName) == null))
            {

             Console.WriteLine("index item: " + index + "  " + EmpArray[index]);   
            }
                
        }






    }
  }
}