public class Employee
{
    public int Salary;
    public string Name;
    
    public string Job;

    public Employee() 
    { 
    }

    public Employee(int hourly)
    {
        Salary = hourly;
    }
    public Employee(int hourly, int numberOfWeeks)
    {
        Salary = (hourly * 2080)/ numberOfWeeks;
    }

    public Employee(string lastName, string firstName)
    {
        Name = (lastName + ", " + firstName);
    }

    public Employee(string jobname)
    {
        Job = jobname;
    }


}