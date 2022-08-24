using System;
using System.Data;
using CRUD.models;
using Dapper;


namespace CRUD.crudActions
{
    public class UpdateAction
    {
        public static void UpdateEmployee()
        {
            Console.WriteLine("Podaj id pracownika, którego dane chcesz edytować");
            int tempId = Convert.ToInt32(Console.ReadLine());
            Employee employee = CreateAction.CreateEmployee();
            string _firstName = employee.FirstName;
            string _lastName = employee.LastName;
            string _job = employee.Job;
            decimal _salary = employee.Salary;
            string _city = employee.City;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {

                connection.Execute($"dbo.UpdateEmployee @id,@firstName,@lastName,@job,@salary,@city ", new { id = tempId, firstName = _firstName, lastName = _lastName, job = _job, salary = _salary, city = _city });
            }
        }
        public static void UpdateEmployeeInfo()
        {
            Console.WriteLine("Podaj id pracownika, którego dane dodatkowe chcesz edytować");
            int tempId = Convert.ToInt32(Console.ReadLine());
            EmployeeInfo employee = CreateAction.CreateEmployeeInfo();
            string _occupation = employee.Occupation;
            string _phoneNr = employee.PhoneNr;
            string _startedWorking = employee.StartedWorking;
            decimal _bonus = employee.Bonus;
            string _info = employee.Info;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {

                connection.Execute($"dbo.UpdateEmployeeInfo  @occupation,@phoneNr,@startedWorking,@bonus,@info", new { id = tempId, occupation = _occupation, phoneNr = _phoneNr, startedWorking = _startedWorking, bonus = _bonus, info = _info });
            }
        }
    }

}

