using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.interfaces
{
    internal interface IEmployeeInfo:IEmploeeDBElement
    {
        public string id { get; }
        public string Occupation { get; set; }
        public string PhoneNr { get; set; }
        public string StartedWorking { get; set; }
        public decimal Bonus { get; set; }
        public string Info { get; set; }

        public string ToString()
        {
            return $" {id} {Occupation} {PhoneNr} {StartedWorking} {Bonus} {Info} ";
        }
    }
}
