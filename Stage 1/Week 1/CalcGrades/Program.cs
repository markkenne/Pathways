/* Program Description: Calculate Grades. The instructor needs to calculate individual student grades for another class.
   Programmer: Mark Kenne
   Last Update:  07/21/2023
   Requirements:
   (1) Number of students in class obtained from user, with minimum of 1.
   (2) Per student, a Name, obtained from user.
   (3) Per student, 5 homework grades between 0-100, obtained from user.
   (4) Per student, 3 quiz grades between 0-100, obtained from user.
   (5) Per student, 2 exam grades between 0-100, obtained from user.
   (6) Averages of the scores for each homework, quiz, and exam group. 
   (7) Weighted score  as 50% of homework avg, 30% of quiz avg and 20% of exam avg.
   (8) Numeric Grade Score based on weighted average
   (9) Letter Grade based on Numenric Grade, where  >90 = A; >80= B; >70 = C; >60 =D; < 60 = F
   (10) Display all results
    
   Algorithm:
   (1) Do
       1a. Prompt for a valid integer as studentCount
       1b. Obtain the integer
       1c. If integer not valid or less than 1
           1c1. Provide an error message
       While the integer is not valid
   (2) For Each studentCount 
       2a1. Create Homework, Quiz, and Exam Total variables as INTs and set to 0
       2a2. Create Homework, Quiz, and Exam Average variables as INTs and set to 0
       2a3. Create a weighted score variable as INT and set to 0
       2a3. Create a Letter Grade variable as string and set to U (unknown) 
   (3) Get Scores
        3a. For each Homework (5)
            3a1. Obtain and validate Homework score (0-100 valid)
            3a2. Add Homework score to Homework Total
            3a3. Divide Homework Total by 5 and set Homework Average  
        3b. For each Quiz (3)
            3b1. Obtain and validate a Quiz score (0-100 valid)
            3b2. Add Quiz score to Quiz Total
            3b3. Divide Quiz Total by 5 and set Quiz Average 
        3c. For each Exam (2)
            3c1. Obtain and validate an Exam score (0-100 valid)
            3c2. Add Exam score to Exam Total
            3c3. Divide Exam Total by 5 and set Exam Average 
    (4) Calculate Weighted Score 
        4a. Multiply Homework Average *.5 and add to Weighted Score
        4b. Multiply Quiz Average *.3 and add to Weighted Score
        4a. Multiply Exam Average *.2 and add to Weighted Score
    (5) Using Weighted score Calculate Letter Grade using switch-based method
        Weighted Score >90 then A
        Weighted Score >80 then B
        Weighted Score >70 then C
        Weighted Score >60 then D
        Defalt then F
    (6) Output for each student:
        6a. Name
        6b. Homework Avg
        6c. Quiz Avg
        6d. Exam Avg
        6e. Final Avg  (weighted Score)
        6f. Final Grade
*/        

  using System;
  namespace GradeCalculator
{
  class Program
  {
// method to Validate that input is numeric and within the passed minimum and maximum thresholds
       
public static bool IsNumericInRange(string input, int inpMin, int inpMax)
    {
        int number;
        if(!int.TryParse(input, out number))
        {
         Console.WriteLine("Error: What you entered is either not a number or was less than "+ inpMin + " or greater than " + inpMax);
            return false;
        }
return number >= inpMin && number <= inpMax;
    }       
       
// switch method to retrieve a letter grade from a passed weighted score
    public static string GetGrade(double scoreWeighted)
    {
        switch (scoreWeighted)
        {
            case > 90: return  "A";
            case > 80: return  "B";
            case > 70: return  "C";
            case > 60: return  "D";
            default:   return  "F";
        }
    }
    // Main program below 
static void Main(string[] args)
    {

    // Set prompt, totals, and averages variables    
      string? input;
      bool numCheck;
      string inpName = "Student Count";
      int inpMin = 1;
      int inpMax = 10;
      int studentCount = 0;
      int hwScore = 0;
      int hwTotal = 0;
      int hwAvg = 0;
      int quizScore = 0;
      int quizTotal = 0;
      int quizAvg = 0;
      int examScore = 0;
      int examTotal = 0;
      int examAvg = 0;
      double scoreWeighted = 0;

    // prompt for the input of Student Count
    do 
      {
        Console.WriteLine("Enter your " + (inpName) + " as a number greater or equal to " + inpMin + " and less than " + inpMax) ;
        input = Console.ReadLine();
        
        //validate student count is both a number and within range
        numCheck = IsNumericInRange(input,inpMin,inpMax);

      }
    while (numCheck != true);

    // Set  studentCount variable and display (for now, remove later)
       studentCount = Int32.Parse(input);
       Console.WriteLine("Student count is " + studentCount); 
    
    //Set a loop counter as i and perform student inputs 
       for (int i = 0; i < studentCount; i++)
    
    //All Student input score looping starts here
    { 
       int studId = i+1;
    // Prompt for a Student Name
       Console.WriteLine("please Enter a Full Name for student " + studId);
       string? inpStudName = Console.ReadLine();
       Console.WriteLine("You entered " + inpStudName + " as student " +  studId);

   // Start score as inputs in 3 sections (Homework, Quizes, and Exams)
   // Set/reset the math variables on each student 
    inpMin = 0;
    inpMax = 100;
    hwScore = 0;
    hwTotal = 0;
    hwAvg = 0; 
    quizScore = 0;
    quizTotal = 0;
    quizAvg = 0;
    examScore = 0;
    examTotal = 0;
    examAvg = 0;
    scoreWeighted = 0;
       
   // Loop to get 5 Homework scores for student
    inpName = "Homework Score";
    for (int hwCt = 0; hwCt < 5; hwCt++)
  
    // inputs of Homework Score
    do 
      {
        int hwNum = hwCt + 1;
        Console.WriteLine("Enter your " + (inpName) + " #" + hwNum + " for "+ inpStudName + " as a number between " + inpMin + " and " + inpMax);
        input = Console.ReadLine();
        
    // validate the input is numeric and within range
        numCheck = IsNumericInRange(input,inpMin,inpMax);
        if (numCheck is true) 
        {
        hwScore = Int32.Parse(input);
        hwTotal = hwTotal + hwScore;
        }
        else {}
      }
    while (numCheck != true);

  // calc and display average for homework
    hwAvg = hwTotal/5;
    Console.WriteLine("Total of " + inpName + " is " + hwTotal + " divided by 5 = " + inpName + " Average of " + hwAvg);
    Console.WriteLine(" "); // add LF

   // Loop to get 3 Quiz scores for student
    inpName = "Quiz Score";
    for (int quizCt = 0; quizCt < 3; quizCt++)
  
  // input the Quiz Scores
     do 
      {
        int quizNum = quizCt + 1;
        Console.WriteLine("Enter your " + inpName + " #" + quizNum + " for "+ inpStudName + " as a number between " + inpMin + " and " + inpMax);
        input = Console.ReadLine();
    
  //validate the input is numeric and within range
        numCheck = IsNumericInRange(input,inpMin,inpMax);
        if (numCheck is true) 
        {
        quizScore = Int32.Parse(input);
        quizTotal = quizTotal + quizScore;
        }
        else {}
      }
     while (numCheck != true);

  // calc and display average for quizes     
    quizAvg = quizTotal/3;
    Console.WriteLine("Total of " + inpName + " is " + quizTotal + " divided by 3 = a " + inpName + " Average of " + quizAvg);
    Console.WriteLine(" "); // add LF
  
  // Loop to get 3 Exam scores for student
    inpName = "Exam Score";
    for (int examCt = 0; examCt < 2; examCt++)
  
  // input exam Score
    do 
      {
        int examNum = examCt + 1;
        Console.WriteLine("Enter your " + (inpName) + " #" + examNum + " for "+ inpStudName + " as a number between " + inpMin + " and " + inpMax);
        input = Console.ReadLine();

  //validate the input is numeric and within range      
        numCheck = IsNumericInRange(input,inpMin,inpMax);
        if (numCheck is true) 
        {
        examScore = Int32.Parse(input);
        examTotal = examTotal + examScore;
        }
        else {}
      }
    while (numCheck != true);

  // calc and display average for exams
    examAvg = examTotal/2;
    Console.WriteLine("Total of " + inpName + " is " + examTotal + " divided by 2 = a " + inpName + " Average of " + quizAvg);
    Console.WriteLine(" "); // add LF
   
  // Calculate the final Weighted Average
    scoreWeighted = (hwAvg * 0.5) + (quizAvg * 0.3) + (examAvg * 0.2) ;
  //Console.WriteLine( "Final average for " + inpStudName + " is: " + scoreWeighted); 

  // Calculate the final Grade from the scoreWeighted Average
    string grade = GetGrade(scoreWeighted);
  // Console.WriteLine("The Final Grade for " + inpStudName + " is: " + GetGrade(scoreWeighted));
  
  // Final Output per requirement: display the student's name, homework average, quiz average, exam average, final average and final grade.
    Console.WriteLine("Student #" +  studId + "       Name: " + inpStudName ); 
    Console.WriteLine("      has a Homework Average of " + hwAvg ); 
    Console.WriteLine("              a Quiz Average of " + quizAvg ); 
    Console.WriteLine("             an Exam Average of " + examAvg );
    Console.WriteLine("resulting in a Final Average of " + scoreWeighted); 
    Console.WriteLine("           and a Final Grade of " + GetGrade(scoreWeighted)); 
    }
  }
 }
}