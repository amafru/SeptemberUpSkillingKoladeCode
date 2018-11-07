using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApiAutomation.Hooks
{
    public class DatabaseHelper
    {
        //database connection string
        string connectionString = "Data Source=DESKTOP-7BFDOSQ\\SQLEXPRESS;Initial Catalog=TaskManagementApiContext-20180716192646;Integrated Security=True;MultipleActiveResultSets=True";

        public void ClearTable(string table)
        {            
            string query = "Delete from [dbo].[" + table + "]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void PopulateOneRecordToProjectTable()
        {
            string query = @"INSERT INTO Projects([Name]) 
                             VALUES('Load Testing')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void PopulateMultipleRecordsToProjectTable()
        {
            string query1 = @"INSERT INTO Projects([Name]) 
                             VALUES('Test Automation')";

            string query2 = @"INSERT INTO Projects([Name]) 
                             VALUES('Manual Testing')";

            string query3 = @"INSERT INTO Projects([Name]) 
                             VALUES('Unit Testing')";

            string query4 = @"INSERT INTO Projects([Name]) 
                             VALUES('API Testing')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = query1;
                    command.ExecuteNonQuery();
                    command.CommandText = query2;
                    command.ExecuteNonQuery();
                    command.CommandText = query3;
                    command.ExecuteNonQuery();
                    command.CommandText = query4;
                    command.ExecuteNonQuery();
                }
            }
        }

        public int SelectARecordFromProjectTable()
        {
            int result = 0;
            string query = "Select Id from [dbo].[Projects]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    result = (Int32)(command.ExecuteScalar());
                }
            }

            return result;
        }
    }
}
