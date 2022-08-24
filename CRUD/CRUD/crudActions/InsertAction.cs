using System;
using System.Data;
using CRUD.models;
using Dapper;
using CRUD.events;


namespace CRUD.crudActions
{
    public class InsertAction

    {
       
        public static void InsertEmoloyee(Employee employee, EventHandler<EmployeeAddedEventArg> OnNewEmployeeAdded)
        {
            ResetIdentity();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {

                connection.Execute($"dbo.InsertEmployee @firstName,@lastName,@job,@salary,@city", employee);
               
            }
            OnNewEmployeeAdded?.Invoke(employee, new EmployeeAddedEventArg(employee.FirstName, employee.LastName));

        }
        public static void InsertEmoloyeeInfo(EmployeeInfo employeeInfo)
        {
            ResetIdentity();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {

                connection.Execute($"dbo.InsertEmployeeInfo @occupation,@phoneNr,@startedWorking,@bonus,@info", employeeInfo);
            }
        }
        public static void ResetIdentity()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {
                connection.Execute($"dbo.ResetIdentity");
            }
        }
       
    }
}
