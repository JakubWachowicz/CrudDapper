using System;
using System.Data;
using Dapper;
using CRUD.events;


namespace CRUD.crudActions
{
    class RemoveAction
    {
        public static void RemoveEmployee(EventHandler<EmployeeRemovedEventArg> OnEmployeeRemoved)
        {
            Console.WriteLine("Podaj id pracownika, którego chcesz usunąć");
            int tempId = Convert.ToInt32(Console.ReadLine());
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {

                connection.Execute($"dbo.RemoveEmployee @id", new { id = tempId });
            }
            
            OnEmployeeRemoved?.Invoke(tempId, new EmployeeRemovedEventArg(tempId));
        }
    }
}

