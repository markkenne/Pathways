using System;
using System.Collections.Generic;   // needed for Lists

namespace listAbstractClass
{
  class Program
  {
    static void Main(string[] args)
    {
        // Initialize Lists
        // Create a list of Employees
        List<Employee> employeeList = new List<Employee>();
        // Create a list of Hourly Employees
        List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();  
        // And, create a list of Salary Employees
        List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();    


      List<string> menuOptions = new List<string>();

      menuOptions.Add("L - Load Lists with Sample Data");   
      menuOptions.Add("C - Create a New Employee");
      menuOptions.Add("R - Read the Employee List");
      menuOptions.Add("U - Update an Employee");
      menuOptions.Add("D - Delete an Employee");
      menuOptions.Add("Q - Quit");


bool isMenuLooping = true;

while (isMenuLooping)
{


     Console.WriteLine("Please select an option:");
     foreach (var option in menuOptions)
          {
        Console.WriteLine(option);
          }
string menuchoice = Console.ReadLine();
// Console.WriteLine(menuchoice);
string menuchoiceUp = menuchoice.ToUpper();
// direct the program to the menu choice using switch/case
switch (menuchoiceUp)
{
  case "L":  // TODO LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL
    // Load sample data to list.
     Console.WriteLine("Loading Sample data:");
        // Create a list of Employees
      //  List<Employee> employeeList = new List<Employee>();
        // Add an hourly employee
        employeeList.Add(new HourlyEmployee("Enge", "J.S.", "H", 25.00));
        // Add a salary employee
        employeeList.Add(new SalaryEmployee("Enge", "Alec", "S", 15000));
        // Add an employee? - Nope
        // employeeList.Add(new Employee("Test", "test", "test"));

        // Create a list of Hourly Employees
       // List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();  
        // And, create a list of Salary Employees to test
        //List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();  

        // Add a couple of hourly employees to the hourly list to test
        hourlyEmployeeList.Add(new HourlyEmployee ("Enge", "Colin", "H", 15.75));
        hourlyEmployeeList.Add(new HourlyEmployee ("Enge", "Elle", "H", 25.73));

        // Add a couple of salary employees to the salary list to test
        salaryEmployeeList.Add(new SalaryEmployee ("Enge", "Anthony", "S", 45250));
        salaryEmployeeList.Add(new SalaryEmployee ("Enge", "Molly", "S", 60000));

        Console.WriteLine();
    break;  // end of Load

case "C":  // TODO CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
    // Create a new item.
     Console.WriteLine("In the Create area");
        // Create a list of Employees
  

    Console.WriteLine();
    break;   // end of Create

  case "R":  // TODO RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
    // Read an existing item.
    Console.WriteLine("Reading List:");
        // Print the employee list
        foreach (Employee anEmployee in employeeList)
            {
                Console.WriteLine(anEmployee);
            }  // end foreach  

        // Print the hourly list
        foreach (HourlyEmployee anEmployee in hourlyEmployeeList)
        {
            Console.WriteLine(anEmployee);
        }  // end foreach  

        // Print the salary list
        foreach (SalaryEmployee anEmployee in salaryEmployeeList)
        {
            Console.WriteLine(anEmployee);
        }  // end foreach      
    Console.WriteLine();
    break; // end of Read
  case "U":  // TODO UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
    // Update an existing item.
     Console.WriteLine("In the Update area");
     Console.WriteLine();
    break; // end of Update
  case "D": // TODO DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
    // Delete an existing item.
     Console.WriteLine("In the Delete area");
     Console.WriteLine();
    break; // end of Delete
  case "Q": // TODO QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
    // Quit the application.
    // Console.WriteLine("In the Quit area");
    isMenuLooping = false; // user chose Q so quit the looping
    Console.WriteLine("You chose Quit. Good Bye...");
    Console.WriteLine();
    break; // end of Quit
  default:
    // Invalid option. Loop to menu choices.
    Console.WriteLine("Invalid Option. Please try again.");
    Console.WriteLine();
    break; // end of Menu 

}  //end menu loop
} // end menu while


     } // end main
  }  // end program
} // end namespace

