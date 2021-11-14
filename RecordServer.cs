using System;
using System.Collections.Generic;

/// This class represents the Adaptee class. 
/// Assuming this is a legacy code and it maintains a list of employee and have only one 
/// functionality of return all the employees to the caller
public class RecordServer
{
    private List<Employee> _employees;

    public RecordServer()
    {
        InitializeEmployees();
    }

    public List<Employee> GetEmployees()
    {
        return _employees;
    }

    private void InitializeEmployees()
    {
        _employees = new List<Employee>
        {
            new Employee { Id = 1401, FirstName = "Michael" , LastName = "Lawson", Department = "Management"},
            new Employee { Id = 1024, FirstName = "Lindsay" , LastName = "Ferguson", Department = "Developer"},
            new Employee { Id = 2124, FirstName = "Tobias" , LastName = "Funke", Department = "IT"},
            new Employee { Id = 1004, FirstName = "Byron" , LastName = "Fields", Department = "IT-Lecturer"},
            new Employee { Id = 1232, FirstName = "George" , LastName = "Edwards", Department = "Developer"},
            new Employee { Id = 1001, FirstName = "Tony" , LastName = "Cash", Department = "Director"}
        };
    }
}