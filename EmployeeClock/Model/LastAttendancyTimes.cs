using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.Model
{
    public class LastAttendancyTimes
    {
        public string Entry { get; set; }
        public string Exit { get; set; }

        public override string ToString()
        {
            return $"entry: {Entry}, exit: {Exit}";
        }
    }
}
