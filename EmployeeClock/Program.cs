
using EmployeeClock.DAL;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;


namespace EmployeeClock
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IDal dal = new Dal(new DBContext());
            new View.FormHandler(dal);
            Application.Run();
        }
    }
}