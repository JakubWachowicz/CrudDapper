using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUD.interfaces;

namespace CRUD.models
{
    public class EmployeeFullInfo : IEmployee, IEmployeeInfo
    {
        public string id { get; }

        public string Occupation { get; set; }
        public string PhoneNr { get  ; set  ; }
        public string StartedWorking { get  ; set  ; }
        public decimal Bonus { get  ; set  ; }
        public string Info { get  ; set  ; }
        public string FirstName { get  ; set  ; }
        public string LastName { get  ; set  ; }
        public string Job { get  ; set  ; }
        public decimal Salary { get  ; set  ; }
        public string City { get  ; set  ; }

        public override string ToString()
        {
            return $" {id} {FirstName} {LastName} {Job} {Salary} {City} {Occupation} {PhoneNr} {StartedWorking} {Bonus} {Info}";
        }

    }
}
