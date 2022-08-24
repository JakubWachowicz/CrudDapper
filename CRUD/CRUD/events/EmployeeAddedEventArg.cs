using System;
namespace CRUD.events
{
    public class EmployeeAddedEventArg : EventArgs
    {
        public string EmployeeFirstNameName { get; set; }
        public string EmployeeLastName { get; set; }
        public EmployeeAddedEventArg(string employeeFirstNameName, string employeeLastName)
        {
            EmployeeFirstNameName = employeeFirstNameName;
            EmployeeLastName = employeeLastName;
            
        }

       
    }

}

