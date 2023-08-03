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

      
         // Declare variables
         bool userChoice;
         string userChoiceString;
         //const int arraySize=24;
         //string[,] array = new string[arraySize, arraySize];
         string fileName = "Employees.txt";

        // Repeat main loop
         do
           {
             //comment
             // TODO: Get a valid input
              do
                 {
                  //  Initialize variables
                  userChoice = false;

                  //  TODO: Provide the user a menu of options

                  Console.WriteLine();
                  Console.WriteLine("Please select an option: ");
                  Console.WriteLine("L: Load the text data file into an array.");
                  Console.WriteLine("S: Store the current Employee information in text file.");
                  Console.WriteLine("C: Add an Employee.");
                  Console.WriteLine("R: Print a list of all Employees and their calculated bonuses.");
                  Console.WriteLine("U: Update information on an Employee.");
                  Console.WriteLine("D: Delete an Employee.");
                  Console.WriteLine("I: Initialize or clear the array.");
                  Console.WriteLine("Q: Quit the program.");

                  //  TODO: Get a user option (valid means its on the menu)

                  userChoiceString = Console.ReadLine();

                  userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                              userChoiceString == "I" || userChoiceString == "i" ||
                              userChoiceString == "S" || userChoiceString == "s" ||                              
                              userChoiceString == "C" || userChoiceString == "c" ||
                              userChoiceString == "R" || userChoiceString == "r" ||
                              userChoiceString == "U" || userChoiceString == "u" ||
                              userChoiceString == "D" || userChoiceString == "d" ||
                              userChoiceString == "Q" || userChoiceString == "q");

                  if (!userChoice)
                    {
                      Console.WriteLine("Please enter a valid option.");
                    }

                  } while (!userChoice);  // end of user choice input
              //  TODO: If the option is a I or i then add load text file

              if (userChoiceString=="I" || userChoiceString=="i")

               { // Begin I execution here
                  Console.WriteLine("In the I/i area");
                  Employee[] EmpArray=new Employee[25];
                  // Create an array of employees and initialize
                  for (int index = 0; index < EmpArray.Length; index++)
                   {
                     EmpArray[index] = new Employee();
                   }
                   // print to screen on initial only
                  for (int index = 0; index < EmpArray.Length; index++)
                   {
                     //if (!((EmpArray[index].LName) == null))
                     if (((EmpArray[index].LName) == null))
                       {
                        Console.WriteLine("index item: " + index + "  " + EmpArray[index]);   
                       }
                   }
                     Console.WriteLine("Array initialized.") ;
               } // end of I area

              //  TODO: Else if the option is a L or l then add load text file

              else if (userChoiceString=="L" || userChoiceString=="l")

               { // Begin L execution here
                  Console.WriteLine("In the L/l area");
               } // end of L area

              //  TODO: Else if the option is a S or s then save the array to text file

              else if (userChoiceString=="S" || userChoiceString=="s")
               { // Begin S execution here
                 Console.WriteLine("In the S/s area");
               } // end of S area

              //  TODO: Else if the option is a C or c then add a name to the array (if there's room)

              else if (userChoiceString=="C" || userChoiceString=="c")
               { // Begin C execution here
                 Console.WriteLine("In the C/c area");
               } // end of C area

              //  TODO: Else if the option is a R or r then print the array to the screen without nulls

              else if (userChoiceString=="R" || userChoiceString=="r")
               { // Begin R execution here
                 Console.WriteLine("In the R/r area");
               } // end of R area

              //  TODO: Else if the option is a U or c then update a name in the array

              else if (userChoiceString=="U" || userChoiceString=="u")
               { // Begin U execution here
                 Console.WriteLine("In the U/u area");
               } // end of U area

              //  TODO: Else if the option is a D or d then delete an Employee

              else if (userChoiceString=="D" || userChoiceString=="d")
               { // Begin D execution here
                 Console.WriteLine("In the D/d area");
               } //end of D area               

              //  TODO: Else if the option is a Q or q then quit the program

              else if (userChoiceString=="Q" || userChoiceString=="q") 
               { // Begin Q execution here
                 Console.WriteLine("Good-bye!");
                 Console.WriteLine();
               }
           } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));


       } // end main
   }  // end program
} // end namespace





/*




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
       */
