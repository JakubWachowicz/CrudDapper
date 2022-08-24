using System;
namespace CRUD.events
{
    public class EmployeeRemovedEventArg : EventArgs
    {

        public int EmployeeId { get; set; }
        
        public EmployeeRemovedEventArg(int employeeId)
        {
            EmployeeId = employeeId;
            
        }


    }

}

