using EmployeeClock.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.DAL
{



    //התבקשנו לשנות את כל בגישה לדטה לגישה יותר מאובטחת ולהעביר כמה שיותר לוגיקה ל - אס קיו אל
    //לכן פתחתי מחלקה חדשה לממש את האינטרפייס  של הגישה לנתונים בדרך שונה
    //כדי להשתמש במחלקה זו צריך להחליף ב PROGRAM את המימוש של האינטרפייס ל DalCorrect
    //בינתיים המחלקה הזאת לא ממומשת עד הסוף. לא הספקתי
    public class DalCorrect : IDal
    {
        DBContext dbContext;
        public DalCorrect(DBContext db)
        {
            dbContext = db;
        }


        public int ChangePassword(string id, string password)
        {
            throw new NotImplementedException();
        }

        public int CreateNewEntry(string id)
        {
            throw new NotImplementedException();
        }

        public int CreateNewExit(string id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByIdentityNumber(string id, string password)
        {
            try
            {
                string query = @$"SELECT e.ID, EmployeeNat, CONVERT(VARCHAR, EmployeePassword) AS pass 
                                      FROM Employees e join Passwords p ON e.ID = p.EmployeeID
                                      WHERE e.EmployeeNat = @ID AND p.EmployeePassword = @Password AND p.IsActive = 1 ";
                DataTable? employee = dbContext.MakeQuery(query, new SqlParameter[] 
                { 
                    new SqlParameter("@ID", id), 
                    new SqlParameter("@Password", password) 
                });
                Employee result = ConvertEmployeeFromDB(employee);
                return result;
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException();
            };
        }

        public LastAttendancyTimes GetEmployeeLastAttendancyTimes(string id)
        {
            throw new NotImplementedException();
        }

        private Employee ConvertEmployeeFromDB(DataTable dt)
        {
            return new Employee()
            {
                ID = dt.Rows[0]["ID"].ToString(),
                IdentityNumber = dt.Rows[0]["EmployeeNat"].ToString(),
                Password = dt.Rows[0]["pass"].ToString()
            };
        }

        private LastAttendancyTimes ConvertEntryAndExitFromDB(DataTable dt)
        {
            return new LastAttendancyTimes()
            {
                Entry = dt.Rows[0]["EntryTime"].ToString(),
                Exit = dt.Rows[0]["ExitTime"].ToString()
            };
        }
    }
}
