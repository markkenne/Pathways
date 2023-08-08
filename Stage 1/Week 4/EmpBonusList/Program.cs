using System;
using System.Collections.Generic;   // needed for Lists

namespace listAbstractClass
{
  class Program
  {
    static void Main(string[] args)
    {

        // Create a list of Employees
        List<Employee> employeeList = new List<Employee>();
        // Add an hourly employee
        employeeList.Add(new HourlyEmployee("Enge", "J.S.", "H", 25.00));
        // Add a salary employee
        employeeList.Add(new SalaryEmployee("Enge", "Alec", "S", 15000));
        // Add an employee? - Nope
        // employeeList.Add(new Employee("Test", "test", "test"));

        // Create a list of Hourly Employees
        List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();  
        // And, create a list of Salary Employees to test
        List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();  

        // Add a couple of hourly employees to the hourly list to test
        hourlyEmployeeList.Add(new HourlyEmployee ("Enge", "Colin", "H", 15.75));
        hourlyEmployeeList.Add(new HourlyEmployee ("Enge", "Elle", "H", 25.73));

        // Add a couple of salary employees to the salary list to test
        salaryEmployeeList.Add(new SalaryEmployee ("Enge", "Anthony", "S", 45250));
        salaryEmployeeList.Add(new SalaryEmployee ("Enge", "Molly", "S", 60000));

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

    } // end Main

  }  // end class Program

}  // end nameSspace





/* Employee Bonus Calculator - List Version
   Programmer: Mark Kenne
   First - Last Update:  08/08/2023
   Program Description -  Demonstrate use of Class inheritance and polymorphism using a parent class of Employee and two child Classes (Hourly and Salary).
  
   Requirements:                      
  (1) An list of Employees
  (2) List holds values of Employee's first name, last name, and Pay Type in each case and a pay rate or amount based on PayType
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
  
  Algorithm:
  (1) Create an Employee.cs class file
    (1a) Create 3 properties using the get-set automatic method
     (1a1) FName
     (1a2) LName
     (1a3) PayType
    (1b) Create construct for default, no value passed
    (1c) Create construct for 3 string FName, LName, PayType passed
  (2) Test Employee Class in main by printing the elements to screen with test data
  (3) Create an Hourly.cs class file
    (3a) Create an HourlyRate property using the get-set automatic method
    (3b) Create a polymorphc field for bonusAmt
    (3c) Create a constant for the bonusHours set to 80
    (3d) BonusHrs times hourlyRate = bonusAmt
    (3d) Create construct for default, no value passed
    (3e) Create construct for 3 string FName, LName, PayType passed
  (4) Create an Salary.cs class file
    (4a) Create an salaryAmt property using the get-set automatic method
    (4b) Create a polymorphc field for bonusAmt
    (4c) Create a constant for the bonusPct set to 10
    (4d) bonusPct times salaryAmt = bonusAmt
    (4d) Create construct for default, no value passed
    (4e) Create construct for 3 string FName, LName, PayType passed    
  (5) Test Salary and Hourly Classs in main by printing the elements to screen with test data  
    (5a) Test default construct
    (5b) Test for 3 string FName, LName, PayType passed 
  (6) Create a menu system with CRUD with Q, and optional Load and Save
    (6a) Test that menu function by toing screen prints at each menu item use
    (6b) Test that program quits on Q use
  (7) As L and save are developed later, create an Initialize menu for starting array
  (8) On I loop the default construct for Employye thru the length of the array (25) to initialize all rows
  (9) Create a Read array loop for use on Menu choice R
    (9a) Print the contents of the array to the screen on use
  (10) Build the Create portion of program
    (10a)  Check for an open slot in the array to write to
      (10a1) If no slot found tell user there is no room 
      (10a2) If slot found set a variable to the index for that row for later use
    (10b) Input the 3 fields used in Employee, separately
      (10b1) FName, LName, PayType 
    (10c) Branch on PayType to get child fields
      (10c1) On Paytype of C input the Salary Amount from user
      (10c2) On Paytype of H input the Hourly Amount from user
    (10d) Use the constructs for variables to get bonus amount from
       (10d1) Salary Construct or
       (10d2) Hourly construct
    (10e) Print the new array row to the screen    
  (11) Build the Update portion of program
    (11a) Input the LName to update from the user  
    (11a)  Check for an instance of that LName in the array
          (11a1) If not found tell user there is no match
    (11a2) If found set a variable to the index for that row for later use
    (11b) Input the 3 fields used in Employee, separately to allow changes
      (11b1) FName, LName, PayType 
    (11c) Branch on PayType to get child fields
      (11c1) On Paytype of C input the Salary Amount from user
      (11c2) On Paytype of H input the Hourly Amount from user
    (11d) Use the constructs  for variables to get bonus amount from
       (11d1) Salary Construct or
       (11d2) Hourly construct
    (11e) Print the updated array row to the screen
    (12) Build the Delete portion of program
    (12a) Input the LName to delete from the user  
    (12a1)  Check for an instance of that LName in the array
          (12a1a) If not found tell user there is no match
          (12a1b) If found set a variable to the index for that row for later use
    (12b) Prompt the user to see if they are sure they want to delete(y/n) 
    (12c) if user inputs N, then tell user Delete cancelled and exit area
    (12d) if Y, use the default Employee constructor with that index to clear array row contents
    (12e) return to menu
  (13) Build the Save portion of program
    (13a) Using StreamWriter, set the filename to Employees.txt
    (13b) For the length of the array write each array row to the file
    (13c) close Filewriter
    (13d) return to menu    
  (14) Build the Load portion of program
    (14a) Using StreamReader, set the filename to Employees.txt
    (14b) For the length of the array write read each file row to the array
    (14c) close Filereader
    (14d) return to menu



using System;
using System.IO;
using System.Text;

namespace EmployeeApp
{
  class Program
   {
 
        static void Main(string[] args)
       { 

         // Declare variables
         bool userChoice;
         string? userChoiceString;
         //const int arraySize=25;
        // bool arrayInit = false;
         Employee[] EmpArray=new Employee[25];
         string fileName = "Employees.txt";
         //int count;
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
           
              //  TODO: If the option is a I or i then add load text file  IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII

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
                       // Console.WriteLine("index item: " + index + "  " + EmpArray[index]); 
                        Console.WriteLine( index + "  " + EmpArray[index]);   
                       }
                   }
                  //   arrayInit = true;
                     Console.WriteLine("Array initialized.") ;
               } // end of I area

              //  TODO: Else if the option is a L or l then add load text file  LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL

              else if (userChoiceString=="L" || userChoiceString=="l")

     { // Begin L execution here
             
        try
        {
          // Create a StreamReader object for the file.
            StreamReader reader = new StreamReader("employees.txt");

            // Create an array to store the employee data.
            string[] empArray = new string[10];

            // Iterate over the lines in the file.
            int i = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                // Split the line into the employee's data.
                string[] data = line.Split(',');

                // Add the employee data to the array.
                for (int j = 0; j < data.Length; j++)
                {
                    empArray[i * data.Length + j] = data[j];
                }

                i++;
                line = reader.ReadLine();
            }
             // Close the StreamReader object.
              reader.Close();
        }
        catch (Exception e)
                  {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }

      } // end of L area

              //  TODO: Else if the option is a S or s then save the array to text file SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS

              else if (userChoiceString=="S" || userChoiceString=="s")
               { // Begin S execution here
                 // Console.WriteLine("In the S/s area");

                // loop the file creation process  
                using (StreamWriter fileStr = File.CreateText(fileName)) 
                        for (int i = 0; i < EmpArray.GetLength(0); i++)
                        {
                         fileStr.WriteLine (EmpArray[i]);
                        }
                   // Close the text file.
                        //reader.Close();
                     // linefeed 
                        Console.WriteLine("");
                        Console.WriteLine("Employee.txt has been saved");
               } // end of S area

              //  TODO: Else if the option is a C or c then add a name to the array (if there's room)  CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC

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
                      // debug print   Console.WriteLine("index item: " + index + "  " + EmpArray[index]); 
                        userow = index; //used to save row to array later
                      // debug print   Console.WriteLine("Found null at index "+ userow);
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
                   Console.WriteLine();
                  // debug print  Console.WriteLine(inpFName);
                   Console.WriteLine("Please input the new Employee's Last Name:");
                   inpLName = Console.ReadLine();
                   Console.WriteLine();
                 // debug print    Console.WriteLine(inpLName);   
                   Console.WriteLine("Please input an Employee Type as S for Salary or H for Hourly, or ENTER for unknown.");
                   inpPayType = Console.ReadLine();
                   Console.WriteLine();
                  // debug print   Console.WriteLine(inpPayType);

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

              //  TODO: Else if the option is a R or r then print the array to the screen without nulls   RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR

              else if (userChoiceString=="R" || userChoiceString=="r")   
               { 
                 // Begin R execution here
                 // print each Employee to test the property gets and the toString

                 for (int index = 0; index < (EmpArray.Length -1); index++)
                   {
                   if (!((EmpArray[index].LName) == null))
                 
                    {
                     Console.WriteLine("index item: " + index + "  " + EmpArray[index]); 
                       
                    }
                   }
                     Console.WriteLine();
               } // end of R area

              //  TODO: Else if the option is a U or u then update a name in the array   UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU

              else if (userChoiceString=="U" || userChoiceString=="u")
               { // Begin U execution here
               // Console.WriteLine("In the U/u area");

               // Search for a Last name and update any piece of data 

               // Create some variables
                  string? searchname = ""; // user input string for last name
                  bool foundrow =  false;  // searched string is found (true) or not (false)
                  string? newLName = "";  // holds the updated  last name string
                  string? newFName = "";  // holds the updated  first name string
                  string? newPayType = ""; // holds the updated pay type string
                  string? dollarAmount = "0"; // holds the updated sal or hourly amount as string
                  double  inpAmount = 0; // holds the updated sal or hourly amount as integer
                  int userow = 0;  // holds the array index number for the row found and used           
               // input a last name string   
                  Console.WriteLine("Input a Last name to Update:" );
                  searchname = Console.ReadLine();

               // Search the array for Last Name input
                 for (int i = 0; i < EmpArray.Length; i++)
                   {
                     if (EmpArray[i].LName == searchname)
                        {
                         foundrow = true; // a row matches search
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
                  //  if (newPayType == "")  //testing
                  //  {newPayType = EmpArray[userow].PayType}
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

              //  TODO: Else if the option is a D or d then delete an Employee  DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD

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


              //  TODO: Else if the option is a Q or q then quit the program  QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ

              else if (userChoiceString=="Q" || userChoiceString=="q") 
               { // Begin Q execution here
                 Console.WriteLine("Good-bye!");
                 Console.WriteLine();
               }
           } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));


       } // end main
   }  // end program
} // end namespace

*/