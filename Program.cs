using System;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeService service = new EmployeeService();
            var employee = service.GetEmployee(1401);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1024);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(2124);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1232);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1202);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1001);
            PrintEmployeeDetails(employee);
            Console.Read();
        }


        static void PrintEmployeeDetails(Employee employee)
        {
            if (employee != null)
                Console.WriteLine(employee);
            else
                Console.WriteLine("Employee not found");
        }
    }
}