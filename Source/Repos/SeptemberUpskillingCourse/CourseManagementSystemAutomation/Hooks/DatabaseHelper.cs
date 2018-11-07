using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystemAutomation.Hooks
{
    public class DatabaseHelper
    {
        //database connection string
        string connectionString = "Data Source=DESKTOP-7BFDOSQ\\SQLEXPRESS;Initial Catalog=CourseManagementSystem.Models.SchoolContext;Integrated Security=True;MultipleActiveResultSets=True";
                                               
        public void ClearTable(string table)
        {
            string query = "";
            if (table.Equals("Person"))
            {
                query = "Delete from [dbo].[" + table + "] where Discriminator = 'Student'";
            }
            else
            {
                query = "Delete from [dbo].[" + table + "]";
            }            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {                
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }            
        }
    }
}
