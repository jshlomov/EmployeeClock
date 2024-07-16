using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.Model
{
    public class Employee
    {
        public string ID { get; set; }
        public string IdentityNumber { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"id: {ID} tz: {IdentityNumber} pass: {Password}";
        }
    }
}
