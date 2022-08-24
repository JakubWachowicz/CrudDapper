using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.interfaces;

namespace CRUD.models
{
   public  class Employee:IEmployee
    {


        public string id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $" {id} {FirstName} {LastName} {Job} {Salary} {City} ";
        }
    }
}
