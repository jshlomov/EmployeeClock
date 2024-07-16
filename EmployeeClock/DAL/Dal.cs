using EmployeeClock.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.DAL
{
    public class Dal : IDal
    {
        DBContext db;

        public Dal(DBContext db)
        {
            this.db = db;
        }

        public Employee GetEmployeeByIdentityNumber(string id, string password)
        {
            try
            {
                string querySelect = "SELECT e.ID, EmployeeNat, CONVERT(VARCHAR, EmployeePassword) AS pass";
                string queryFrom = "FROM Employees e join Passwords p ON e.ID = p.EmployeeID";
                string queryWhere = $"WHERE e.EmployeeNat = '{id}' AND p.EmployeePassword = '{password}' AND p.IsActive = 1 ";
                string query = $"{querySelect} {queryFrom} {queryWhere}";
                DataTable? employee = db.MakeQuery(query);
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
            try
            {
                string querySelect = "SELECT TOP(1) EmployeeCode, EntryTime, ExitTime";
                string queryFrom = "FROM EmployeeAttendance";
                string queryWhere = $"WHERE EmployeeCode = '{id}' ORDER BY ID DESC;";
                string query = $"{querySelect} {queryFrom} {queryWhere}";
                DataTable? output = db.MakeQuery(query);
                LastAttendancyTimes lastEntryAndExit = ConvertEntryAndExitFromDB(output);
                return lastEntryAndExit;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("Attendancy not found");
            }
        }

        public int CreateNewEntry(string id)
        {
            try
            {
                string query = @$"INSERT INTO EmployeeAttendance (EmployeeCode, EntryTime, ExitTime)
                                (SELECT TOP(1) {id}, GETDATE(), NULL
                                FROM EmployeeAttendance
                                WHERE NOT EXISTS 
                                (SELECT * FROM EmployeeAttendance
                                WHERE EmployeeCode = {id} AND ExitTime IS NULL));";
                int result = db.ExecuteNonQuery(query);
                if (result != 0) return result;
                else throw new ArgumentException("תקלה, לא הוגדרה יציאה");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CreateNewExit(string id)
        {
            try
            {
                string query = @$"UPDATE EmployeeAttendance SET ExitTime = GETDATE() 
                                WHERE EmployeeCode = '{id}' AND ExitTime IS NULL;";
                int result = db.ExecuteNonQuery(query);
                if (result != 0) return result;
                else throw new Exception("לא הגדרת כניסה");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ChangePassword(string id, string password)
        {
            try
            {
                string query = @$"BEGIN TRANSACTION
                                UPDATE Passwords
                                SET IsActive = 0 
                                WHERE EmployeeID = '{id}' AND IsActive = 1;

                                INSERT INTO Passwords (EmployeeID, EmployeePassword, ExpiryDate, IsActive)
                                VALUES ('{id}', convert(varbinary, '{password}'), getdate(), 1)
                                COMMIT TRANSACTION;";
                int result = db.ExecuteNonQuery(query);
                if (result != 0) return result;
                else throw new Exception("פרטים לא נכונים");
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
