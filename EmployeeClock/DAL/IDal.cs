using EmployeeClock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.DAL
{
    public interface IDal
    {
        public Employee GetEmployeeByIdentityNumber(string id, string password);
        public LastAttendancyTimes GetEmployeeLastAttendancyTimes(string id);
        public int CreateNewEntry(string id);
        public int CreateNewExit(string id);
        public int ChangePassword(string id, string password);
    }
}
