// Movies List

using System;

namespace listAbstractClass
{
    abstract class Movie   // this is an abstract class so it can't be instantiated (objects of this type can't be created)
    {
        public string movieName  // property
            { get; set; }

        public string dirName  // property director
            { get; set; }

        public string actorName  //property
            { get; set; }    


        public Movie()       // default constructor
        {
            movieName = "";
            dirName = "";
            actorName = "";
        }

        public Employee(string newLastName, string newFirstName, string newEmployeeType)       // another constructor
        {
            movieName = newMovieName;
            dirName = newDirName;
            actorName = newActorName;
        }

        public abstract double Year();  // this is the abstract method that all children must implement

        public override string ToString()
        {
            return "Employee: " + lastName + ", " + firstName + " | Type: " + employeeType;
        }

    }  // end class Employee

}  //end namespace listInterface


/* array version
using System;

namespace listAbstractClass
{
    abstract class Employee   // this is an abstract class so it can't be instantiated (objects of this type can't be created)
    {
        public string lastName  // property
            { get; set; }

        public string firstName  // property
            { get; set; }

        public string employeeType  //property
            { get; set; }    


        public Employee()       // default constructor
        {
            lastName = "";
            firstName = "";
            employeeType = "";
        }

        public Employee(string newLastName, string newFirstName, string newEmployeeType)       // another constructor
        {
            lastName = newLastName;
            firstName = newFirstName;
            employeeType = newEmployeeType;
        }

        public abstract double GetBonus();  // this is the abstract method that all children must implement

        public override string ToString()
        {
            return "Employee: " + lastName + ", " + firstName + " | Type: " + employeeType;
        }

    }  // end class Employee

}  //end namespace listInterface
*/