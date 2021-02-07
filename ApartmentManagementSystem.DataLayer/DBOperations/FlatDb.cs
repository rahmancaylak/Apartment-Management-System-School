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
    public class FlatDb
    {
        public int numberOfEffectedRow;
        // Retrive Flat Table
        public DataTable GetAllFlat()
        {
            try
            {
                // open database connection
                var con = DBHelper.GetConnectionString();
                // Filling the data into the DataTable with a Select query.
                SqlDataAdapter adp = new SqlDataAdapter();
                // Retrieve all data from Flat table.
                adp.SelectCommand = new SqlCommand("SELECT * FROM Flat", con);
                // To transfer the incoming table to the DataTable, we first create it
                DataTable tbl = new DataTable();
                // And finally we fill in the DataTable.
                adp.Fill(tbl);
                return tbl;
            }
            catch (Exception e) // If problem happen, this code will work.
            {
                Console.WriteLine("======== Hata Çıktısı ========\n " + e);
                throw;
            }
        }
        // Insert new record to Flat table
        public Flat AddNewFlat(Flat _flat)
        {
            try
            {
                // open database connection
                var con = DBHelper.GetConnectionString();
                // And this is our Query very simple
                string insertQuery = @"INSERT INTO [Flat]
                                  (
                                      [FlatNo]
                                     ,[FlatOwner]
                                     ,[FlatOwnerName]
                                     ,[FlatOwnerLastName]
                                     ,[FlatTenantName]
                                     ,[FlatTenantLastName]
                                     ,[PaidMoney]
                                     ,[LastPaymentDate]
                                  )
                                VALUES
                                    (
                                      @FlatNo,
                                      @FlatOwner,
                                      @FlatOwnerName,
                                      @FlatOwnerLastName,
                                      @FlatTenantName,
                                      @FlatTenantLastName,
                                      @PaidMoney,
                                      @LastPaymentDate
                                    )";

                SqlCommand cmdInsert = new SqlCommand();
                // The query sentence to be run is written.
                cmdInsert.CommandText = insertQuery;
                cmdInsert.Connection = con;
                // We send that parameters, take this model variable.
                cmdInsert.Parameters.AddWithValue("@FlatNo", _flat.FlatNo);
                cmdInsert.Parameters.AddWithValue("@FlatOwner", _flat.FlatOwner);
                cmdInsert.Parameters.AddWithValue("@FlatOwnerName", _flat.FlatOwnerName);
                cmdInsert.Parameters.AddWithValue("@FlatOwnerLastName", _flat.FlatOwnerLastName);
                cmdInsert.Parameters.AddWithValue("@FlatTenantName", _flat.FlatTenantName);
                cmdInsert.Parameters.AddWithValue("@FlatTenantLastName", _flat.FlatTenantLastName);
                cmdInsert.Parameters.AddWithValue("@PaidMoney", _flat.PaidMoney);
                cmdInsert.Parameters.AddWithValue("@LastPaymentDate", _flat.LastPaymentDate);
                // This only work Update, Delete Insert...
                // When record successfully added, int number return.
                numberOfEffectedRow = cmdInsert.ExecuteNonQuery();

                if (numberOfEffectedRow > 0)
                {
                    // The SELECT TOP clause is used to specify the number of records to return. (w3school.com)
                    // It gives us Table maximum ID, this is very important.
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 FlatID FROM Flat ORDER BY FlatID DESC", con);
                    var idObj = cmd.ExecuteScalar();
                    int id = 0;
                    if (Int32.TryParse(idObj.ToString(), out id))

                    {
                        _flat.FlatID = id;
                        return _flat;
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
        public Flat UpdateFlat(Flat _flat)
        {
            numberOfEffectedRow = 0;
            try
            {
                var con = DBHelper.GetConnectionString();
                string updateCommand = @"
                                            UPDATE Flat
                                            SET FlatOwner = @FlatOwnerName,
                                                FlatOwnerName = @FlatOwnerName,
                                                FlatOwnerLastName = @FlatOwnerLastName,
                                                FlatTenantName = @FlatTenantName,
                                                FlatTenantLastName = @FlatTenantLastName,
                                                PaidMoney = @PaidMoney,
                                                LastPaymentDate = @LastPaymentDate
                                    WHERE FlatID = @FlatID";

                SqlCommand cmd = new SqlCommand(updateCommand, con);

                cmd.Parameters.AddWithValue("@FlatNo", _flat.FlatNo);
                cmd.Parameters.AddWithValue("@FlatOwner", _flat.FlatOwner);
                cmd.Parameters.AddWithValue("@FlatOwnerName", _flat.FlatOwnerName);
                cmd.Parameters.AddWithValue("@FlatOwnerLastName", _flat.FlatOwnerLastName);
                cmd.Parameters.AddWithValue("@FlatTenantName", _flat.FlatTenantName);
                cmd.Parameters.AddWithValue("@FlatTenantLastName", _flat.FlatTenantLastName);
                cmd.Parameters.AddWithValue("@PaidMoney", _flat.PaidMoney);
                cmd.Parameters.AddWithValue("@LastPaymentDate", _flat.LastPaymentDate);
                cmd.Parameters.AddWithValue("@FlatID", _flat.FlatID);
                var numberOfUpdatedRow = cmd.ExecuteNonQuery();

                if (numberOfUpdatedRow > 0)
                {
                    return _flat;
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
        public Flat DeleteFlat(Flat _flat)
        {
            try
            {
                var con = DBHelper.GetConnectionString();
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Flat WHERE FlatID = @FlatID", con);
                deleteCommand.Parameters.AddWithValue("@FlatID", Convert.ToInt32(_flat.FlatID));
                numberOfEffectedRow = deleteCommand.ExecuteNonQuery();
                if (numberOfEffectedRow > 0)
                {
                    return _flat;
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
