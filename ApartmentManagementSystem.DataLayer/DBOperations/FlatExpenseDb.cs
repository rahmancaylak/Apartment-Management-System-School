using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataLayer.DBOperations
{
    public class FlatExpenseDb
    {
        public DataTable GetAllFlatExpense()
        {
            try
            {
                var con = DBHelper.GetConnectionString();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT * FROM FlatExpense", con);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                return tbl;
            }
            catch (Exception e)
            {
                Console.WriteLine("======== Hata Çıktısı ========\n " + e);
                throw;
            }
        }
    }
}
