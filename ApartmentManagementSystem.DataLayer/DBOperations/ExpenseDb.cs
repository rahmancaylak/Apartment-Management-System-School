using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApartmentManagementSystem.DataLayer.DBOperations;
using ApartmentManagementSystem.DataLayer;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ApartmentManagementSystem.DataLayer.Model;

namespace ApartmentManagementSystem.DataLayer.DBOperations
{
    public class ExpenseDb
    {
        public int numberOfEffectedRow;
        public DataTable GetAllExpense()
        {
            try
            {
                var con = DBHelper.GetConnectionString();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT * FROM Expense", con);
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
        public Expense AddNewExpense(Expense _expense)
        {
            try
            {
                var con = DBHelper.GetConnectionString();
                string insertQuery = @"INSERT INTO [Expense]
                                  (
                                      [Due]
                                     ,[HotWater]
                                     ,[ColdWater]
                                     ,[PoolMaintenance]
                                     ,[Gym]
                                     ,[SecurityExpense]
                                     ,[Garden]
                                     ,[InterestMaturityStart]
                                     ,[InterestRate]
                                  )
                                VALUES
                                    (
                                      @Due,
                                      @HotWater,
                                      @ColdWater,
                                      @PoolMaintenance,
                                      @Gym,
                                      @SecurityExpense,
                                      @Garden,
                                      @InterestMaturityStart,
                                      @InterestRate
                                    )";

                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.CommandText = insertQuery;
                cmdInsert.Connection = con;

                cmdInsert.Parameters.AddWithValue("@Due", _expense.Due);
                cmdInsert.Parameters.AddWithValue("@HotWater", _expense.HotWater);
                cmdInsert.Parameters.AddWithValue("@ColdWater", _expense.ColdWater);
                cmdInsert.Parameters.AddWithValue("@PoolMaintenance", _expense.PoolMaintenance);
                cmdInsert.Parameters.AddWithValue("@Gym", _expense.Gym);
                cmdInsert.Parameters.AddWithValue("@SecurityExpense", _expense.SecurityExpense);
                cmdInsert.Parameters.AddWithValue("@Garden", _expense.Garden);
                cmdInsert.Parameters.AddWithValue("@InterestMaturityStart", _expense.InterestMaturityStart);
                cmdInsert.Parameters.AddWithValue("@InterestRate", _expense.InterestRate);
                numberOfEffectedRow = cmdInsert.ExecuteNonQuery();

                if (numberOfEffectedRow > 0)
                {

                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 ExpenseID FROM Expense ORDER BY ExpenseID DESC", con);
                    var idObj = cmd.ExecuteScalar();
                    int id = 0;
                    if (Int32.TryParse(idObj.ToString(), out id))

                    {
                        _expense.ExpenseID = id;
                        return _expense;
                    }
                }

                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("======== Hata Çıktısı ========\n " + e);
                throw;
            }
        }
        public Expense UpdateExpense(Expense _expense)
        {
            numberOfEffectedRow = 0;
            try
            {
                var con = DBHelper.GetConnectionString();
                string updateCommand = @"
                                            UPDATE Expense
                                            SET Due = @Due,
                                                HotWater = @HotWater,
                                                ColdWater = @ColdWater,
                                                PoolMaintenance = @PoolMaintenance,
                                                Gym = @Gym,
                                                SecurityExpense = @SecurityExpense,
                                                Garden = @Garden,
                                                InterestMaturityStart = @InterestMaturityStart,
                                                InterestRate = @InterestRate
                                    WHERE ExpenseID = @ExpenseID ";

                SqlCommand cmd = new SqlCommand(updateCommand, con);

                cmd.Parameters.AddWithValue("@Due", _expense.Due);
                cmd.Parameters.AddWithValue("@HotWater", _expense.HotWater);
                cmd.Parameters.AddWithValue("@ColdWater", _expense.ColdWater);
                cmd.Parameters.AddWithValue("@PoolMaintenance", _expense.PoolMaintenance);
                cmd.Parameters.AddWithValue("@Gym", _expense.Gym);
                cmd.Parameters.AddWithValue("@SecurityExpense", _expense.SecurityExpense);
                cmd.Parameters.AddWithValue("@Garden", _expense.Garden);
                cmd.Parameters.AddWithValue("@InterestMaturityStart", _expense.InterestMaturityStart);
                cmd.Parameters.AddWithValue("@InterestRate", _expense.InterestRate);
                cmd.Parameters.AddWithValue("@ExpenseID", _expense.ExpenseID);
                var numberOfUpdatedRow = cmd.ExecuteNonQuery();

                if (numberOfUpdatedRow > 0)
                {
                    return _expense;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("======== Hata Çıktısı ========\n" + e);
                throw;
            }
        }
        public Expense DeleteExpense(Expense _expense)
        {
            try
            {
                var con = DBHelper.GetConnectionString();
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Expense WHERE ExpenseID = @ExpenseID", con);
                deleteCommand.Parameters.AddWithValue("@ExpenseID", Convert.ToInt32(_expense.ExpenseID));
                numberOfEffectedRow = deleteCommand.ExecuteNonQuery();
                if (numberOfEffectedRow > 0)
                {
                    return _expense;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
