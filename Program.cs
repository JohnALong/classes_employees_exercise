using System;
using System.Collections.Generic;


public class Employee
{
    public Employee(string firstName, string lastName, string title, DateTime startTime)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.title = title;
        this.startTime = startTime;
    }

    // Some readonly properties (let's talk about gets, baby)
    public string firstName { get; set; }

    public string lastName { get; set; }

    public string title { get; set; }
    
    public DateTime startTime { get; set; }
}

public class Company
{
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company(string name, DateTime createdOn)
    {
        Name = name;
        CreatedOn = createdOn;
    }

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> Employees = new List<Employee>();
    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        Company NSS = new Company("NSS", DateTime.Now);      

        // Create three employees
        Employee brenda = new Employee("Brenda", "Long", "Lead Instructor", DateTime.Now);

        Employee kristen = new Employee("Kristen", "Norris", "Junior Instructor", DateTime.Now);

        Employee jeremiah = new Employee("Jeremiah", "Vasquez", "Student Relations", DateTime.Now);

        Employee chase = new Employee("Chase", "Fite", "TA", DateTime.Now);

        // Assign the employees to the company
        NSS.AddEmployee(jeremiah);
        NSS.AddEmployee(brenda);
        NSS.AddEmployee(kristen);
        NSS.AddEmployee(chase);
        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        foreach (Employee employee in NSS.Employees)
        {
            Console.WriteLine($"{employee.firstName} {employee.lastName} works for {NSS.Name} as {employee.title}, and has since {employee.startTime}");
        }
    }
}
