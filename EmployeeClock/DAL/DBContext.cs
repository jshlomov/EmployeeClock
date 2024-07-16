using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.Extensions.Configuration;

namespace EmployeeClock.DAL
{
    public class DBContext
    {
        public readonly string _connectionString;

        public DBContext()
        {
            // SET SECRETS.JSON TO COPY ALWAYS AFTER ADDING!!
            IConfiguration builder = new ConfigurationBuilder()
                .AddJsonFile("secrets.json", optional: true) // Add secrets.json
                .Build();
            // Read a value from the configuration
            _connectionString = builder["ConnectionString"];
        }

        public DBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable MakeQuery(string query)
        {
            DataTable output = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryStr"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataTable MakeQuery(string queryStr, SqlParameter[] parameters)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        // Further error handling
                    }
                }
            }
            return output;
        }

        /// <summary>
        /// make query like update and insert or delete that dont return anything 
        /// without sql injection
        /// </summary>
        /// <param name="query"></param>
        /// <returns>num of rows the was effected</returns>
        public int ExecuteNonQuery(string query)
        {
            int output;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        output = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return output;
        }

        /// <summary>
        /// make query with sql injection
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns>result data table</returns>
        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int output;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    //command.Parameters.AddWithValue("@EmployeeID", 12); להכניס פרמטר ספציפי
                    try
                    {
                        connection.Open();
                        output = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return output;
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            object output;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    //command.Parameters.AddWithValue("@EmployeeID", 12); להכניס פרמטר ספציפי
                    try
                    {
                        connection.Open();
                        output = command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return output;
        }
    }
}
