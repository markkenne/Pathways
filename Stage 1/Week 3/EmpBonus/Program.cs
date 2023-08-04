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
         const int arraySize=25;
         bool arrayInit = false;
         Employee[] EmpArray=new Employee[25];
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
                 // Console.WriteLine("In the I/i area");
                 // above again Employee[] EmpArray=new Employee[25];
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
                     arrayInit = true;
                     Console.WriteLine("Array initialized.") ;
               } // end of I area

              //  TODO: Else if the option is a L or l then add load text file

              else if (userChoiceString=="L" || userChoiceString=="l")

               { // Begin L execution here
                  Console.WriteLine("In the L/l area, nothing here yet.");
               } // end of L area

              //  TODO: Else if the option is a S or s then save the array to text file

              else if (userChoiceString=="S" || userChoiceString=="s")
               { // Begin S execution here
                 Console.WriteLine("In the S/s area");
               } // end of S area

              //  TODO: Else if the option is a C or c then add a name to the array (if there's room)  

              else if (userChoiceString=="C" || userChoiceString=="c")
               { // Begin C execution here
                 // Console.WriteLine("In the C/c area");

                // init variables for Create
                   string? inpFName = "";
                   string? inpLName = "";
                   string? inpPayType = "";
                   double  inpAmount = 0;
                   string dollarAmount = "0";
                   int userow = 0;
                // Find an empty row to save in      
                   for (int index = 0; index < EmpArray.Length; index++)
                     {
                      if (((EmpArray[index].LName) == null))
                       {
                        Console.WriteLine("index item: " + index + "  " + EmpArray[index]); 
                        userow = index; //used to save row to array later
                        Console.WriteLine("Found null at index "+ userow);
                        break; // have one, thats enough 
                       }
                      else if (!((EmpArray[index].LName) == null))//exit with no room message
                       { 
                        Console.WriteLine("");
                      //not working yet...  Console.WriteLine("Your list is full. Either Delete one or Update an existing entry.");
                        Console.WriteLine("");
                       }
                     Console.WriteLine();
                    }
                
                // Input Employee data to Create an entry
                   Console.WriteLine("Please input the new Employee's First Name:");
                   inpFName = Console.ReadLine();
                   Console.WriteLine(inpFName);
                   Console.WriteLine("Please input the new Employee's Last Name:");
                   inpLName = Console.ReadLine();
                   Console.WriteLine(inpLName);   
                   Console.WriteLine("Please input an Employee Type as S for Salary or H for Hourly, or ENTER for unknown.");
                   inpPayType = Console.ReadLine();
                   Console.WriteLine(inpPayType);

                // Take care of the child for Salary Class
                   if (inpPayType=="S" || inpPayType=="s")
                     {
                      Console.WriteLine("Please input the new Employee's Annual Salary: ");
                      dollarAmount = Console.ReadLine();
                      inpAmount = double.Parse(dollarAmount);
                      Console.WriteLine("The amount is: " + inpAmount);

                      // now create row to save to array using Salary
                      Salary  EmpTemp = new Salary  (inpFName, inpLName, inpPayType, inpAmount);
                      Console.WriteLine(EmpTemp);  // test print Hourly Class w three variables
                      EmpArray[userow] = EmpTemp;                
                     }

                // Take care of the child for Hourly Class
                   if (inpPayType=="H" || inpPayType=="h")
                     {
                      Console.WriteLine("Please input the new Employee's Hourly Rate: ");
                      dollarAmount = Console.ReadLine();
                      inpAmount = double.Parse(dollarAmount);
                      Console.WriteLine("The amount is: " + inpAmount);

                // now create row to save to array using Hourly
                      Hourly  EmpTemp = new Hourly  (inpFName, inpLName, inpPayType, inpAmount);
                      Console.WriteLine(EmpTemp);  // test print Hourly Class w three variables  
                      EmpArray[userow] = EmpTemp;
                     }
 
    }  // End of c area      

              //  TODO: Else if the option is a R or r then print the array to the screen without nulls 

              else if (userChoiceString=="R" || userChoiceString=="r")   
               { 
                 // Begin R execution here
                 // print each Employee to test the property gets and the toString

                 for (int index = 0; index < EmpArray.Length; index++)
                   {
                    if (!((EmpArray[index].LName) == null))
                    {
                     Console.WriteLine("index item: " + index + "  " + EmpArray[index]);   
                    }
                   }
                     Console.WriteLine();
               } // end of R area

              //  TODO: Else if the option is a U or u then update a name in the array   

              else if (userChoiceString=="U" || userChoiceString=="u")
               { // Begin U execution here
               // Console.WriteLine("In the U/u area");

               // Search for a Last name and update any piece of data 

               // Create some variables
                  string? searchname = "";
                  bool foundrow =  false;
                  string newLName = "";
                  string newFName = "";
                  string newPayType = "";
                  double  inpAmount = 0;
                  string dollarAmount = "0";
                  int userow = 0;                
               // input a last name string   
                  Console.WriteLine("Input a Last name to Update:" );
                  searchname = Console.ReadLine();

               // Search the array for Last Name input
                 for (int i = 0; i < EmpArray.Length; i++)
                   {
                     if (EmpArray[i].LName == searchname)
                        {
                         foundrow = true; 
                         userow = i;
                         Console.WriteLine(EmpArray[i].LName + " at row: " + i);
                        } 
                  //   When not found, tell user
                   }
                    if (foundrow == false)
                     {
                       Console.WriteLine("Last Name of " + searchname + " was not found." );
                     }    
               // Do the updates when name is found
                  Console.WriteLine("foundrow = " + foundrow);
                  if (foundrow == true)
                   {
                    Console.WriteLine("The Last Name is currently : " + EmpArray[userow].LName + " Enter the correct LAST name or ENTER to move on.");
                    newLName = Console.ReadLine();
                    Console.WriteLine("The First Name is currently : " + EmpArray[userow].FName + " Enter the correct FIRST name or ENTER to move on.");
                    newFName = Console.ReadLine();
                    Console.WriteLine("The Pay Type is currently : " + EmpArray[userow].PayType + " Enter the correct PAY TYPE as (H)ourly or (S)alary or ENTER to move on.");
                    newPayType = Console.ReadLine();
                   }
               // TODO the ENTER routine needs to be coded above

               // Take care of the child for Salary Class
                  if (newPayType=="S" || newPayType=="s")
                   {
                    Console.WriteLine("Please input the new Employee's Annual Salary: ");
                    dollarAmount = Console.ReadLine();
                    inpAmount = double.Parse(dollarAmount);
                    Console.WriteLine("The amount is: " + inpAmount);

                 // now create row to save to array using Salary
                    Salary  EmpTemp = new Salary  (newFName, newLName, newPayType, inpAmount);
                    Console.WriteLine(EmpTemp);  // test print Hourly Class w three variables
                    EmpArray[userow] = EmpTemp;                
                   }

                // Take care of the child for Hourly Class
                  if (newPayType=="H" || newPayType=="h")
                   {
                    Console.WriteLine("Please input the new Employee's Hourly Rate: ");
                    dollarAmount = Console.ReadLine();
                    inpAmount = double.Parse(dollarAmount);
                    Console.WriteLine("The amount is: " + inpAmount);

                // create row to save to array using Hourly
                    Hourly  EmpTemp = new Hourly  (newFName, newLName, newPayType, inpAmount);
                    Console.WriteLine(EmpTemp);  // test print Hourly Class w three variables  
                    EmpArray[userow] = EmpTemp;
                   }

               } // end of U area

              //  TODO: Else if the option is a D or d then delete an Employee

              else if (userChoiceString=="D" || userChoiceString=="d")
               { // Begin D execution here
                 // Console.WriteLine("In the D/d area");

                // delete variables
                   string? deletename = "";
                   bool deleterowfound = false;
                   int delrow = 0;
                   string? stryn = "n";

               // input a last name string to delete row  
                 Console.WriteLine("Input an Employee Last Name to Delete:" );
                 deletename = Console.ReadLine();

                 for (int i = 0; i < EmpArray.Length; i++)
                   {
                   // Search for Last name to delete
                      if (EmpArray[i].LName == deletename)
                        {
                         deleterowfound = true; 
                         delrow = i;
                         Console.WriteLine("Row " + i + ", named " + deletename + ", has been found,  and will be deleted.");
                        // Make sure user wants to delete
                           Console.WriteLine("Are you sure? y/n");
                           stryn = Console.ReadLine();
                            if (stryn == "y"|| stryn=="Y")
                             {
                            // Delete by initializing the line using default method
                               Console.WriteLine("Deleted "+ EmpArray[i].LName + " at row: " + i);
                               EmpArray[delrow] = new Employee();
                             }
                          else //user cancels delete
                         {
                           Console.WriteLine("Canceled Delete");
                         }
                     
                       } 
                    //  This last name not found
                  }
                    if (deleterowfound == false)
                     {
                       Console.WriteLine("Last Name of " + deletename + " was not found." );
                     }    
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


