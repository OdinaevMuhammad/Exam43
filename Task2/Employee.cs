using System;
public class Employee
{
    private int id;
    private string FirstName;
    private string LastName;
    private int salary;

    public Employee(int _id , string firstName , string lastName, int _salary)
    {
        id = _id;
        FirstName = firstName;
        LastName = lastName;
        salary = _salary;
    }
    public int GetId()
    {
        return id;
    }
    public string GetFirstName()
    {
        return FirstName;
    }
    public string GetLastName()
    {
        return LastName;
    }
    public string GetName()
    {
        return $"{FirstName} {LastName}";
    }
    public int  GetSalary()
    {
        return salary;
    }
    public void SetSalary(int _salary)
    {
        salary = _salary;
    }
    public int GetAnnualSalary()
    {
        return salary * 12;
    }
    public int RaiseSalary(int percent)
    {
         salary = salary * (100 + percent) / 100;
         return salary;
    }
    public override string ToString()
    {
        return $"Employee {id}, name = {FirstName} {LastName}, {salary}";
    }
}