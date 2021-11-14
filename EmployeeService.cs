﻿using System;
using System.Linq;


/// Represents the Adapter class.
/// This class create the instance of Adaptee class and serves the client via composition
public class EmployeeService : IEmployeeService
{
    #region Private member
    RecordServer recordServer;
    #endregion

    #region Constructor
    public EmployeeService()
    {
        recordServer = new RecordServer();
    }
    #endregion


    #region IAdapter - Implemented Member

    /// <summary>
    /// This method fetches the list of employee from the record server
    /// and return the employee based on the employeeId
    /// </summary>
    /// <param name="employeeId"></param>
    /// <returns></returns>
    public Employee GetEmployee(int employeeId)
    {
        var allEmployees = recordServer.GetEmployees();
        return allEmployees.FirstOrDefault(e => e.Id == employeeId);
    }
    #endregion
}