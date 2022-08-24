using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CRUD.models;
using Dapper;


namespace CRUD.crudActions
{
    public class ReadAction

    {
        public static void ReadAllEmployee()
        {
            foreach (var employee in GetEmployees())
            {
                Console.WriteLine(employee.ToString());
            }
        }
        public static void ReadAllEmployeeFullInfo()
        {
            foreach (var employeeFullInfo in GetEmployeesFullInfo())
            {
                Console.WriteLine(employeeFullInfo.ToString());
            }
        }
        public static void ReadAllEmployeeInfo()
        {
            foreach (var employeeInfo in GetEmployeeInfo())
            {
                Console.WriteLine(employeeInfo.ToString());
            }
        }
        public static List<Employee> GetEmployees(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {
                var output = connection.Query<Employee>($"dbo.SelectEmployeesByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }
        public static List<EmployeeFullInfo> GetEmployeesFullInfo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {
                string sql = @"select e.*,ei.* 
                              from dbo.Employee e
                              left join dbo.EmployeeInfo ei
                               on e.id= ei.id";
                var output = connection.Query<EmployeeFullInfo>(sql).ToList();
                return output;
            }
        }

        public static List<EmployeeInfo> GetEmployeeInfo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {
                string sql = @"select *
                              from dbo.EmployeeInfo" ;
                var output = connection.Query<EmployeeInfo>(sql).ToList();
                return output;
            }
        }

        public static List<Employee> GetEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {
                var output = connection.Query<Employee>($"dbo.SelectAllEmployees").ToList();
                return output;
            }
        }
    }
}
