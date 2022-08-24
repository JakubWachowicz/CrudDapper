using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CRUD.models;
using Dapper;

namespace CRUD.crudActions
{
    public class FiltrAction
    {
        public static void FiltrBylastName()
        {
            Console.WriteLine("podaj pierwsze litery pracownika którego chcesz wyszukać");
            string userCmd = Console.ReadLine();
            foreach (var item in GetFiltrByLastName(userCmd))
            {
                Console.WriteLine(item.ToString());
            }

        }
        public static List<Employee> GetFiltrByLastName(string lastName)
        {
            lastName += "%";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {
                string sql = $"dbo.FiltrByLastName @pattern";
                var output = connection.Query<Employee>(sql, new { pattern = lastName }).ToList();
                return output;
            }
        }


        public static void FiltrBy()
        {
            Console.WriteLine("podaj frazę");
            string userCmd = Console.ReadLine();
            foreach (var item in GetFiltrBy(userCmd))
            {
                Console.WriteLine(item.ToString());
            }

        }
        public static List<Employee> GetFiltrBy(string lastName)
        {
            lastName += "%";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
            {
                string sql = $"dbo.FiltrBy @pattern";
                var output = connection.Query<Employee>(sql, new { pattern = lastName }).ToList();
                return output;
            }
        }

    }

}

