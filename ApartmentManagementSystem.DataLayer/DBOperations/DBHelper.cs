using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ApartmentManagementSystem.DataLayer;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataLayer.DBOperations
{
    class DBHelper
    {
        public static SqlConnection GetConnectionString() {
            // SQL server offers two types of login. These are called SQL Server Authentication
            // and Windows Authentication.
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ApartmentManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }
    }
}
