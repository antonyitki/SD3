using System;


/// Represents the IAdapter
/// This interface will allow the client to fetch an employee using employeeId
public interface IEmployeeService
{
    Employee GetEmployee(int employeeId);
}