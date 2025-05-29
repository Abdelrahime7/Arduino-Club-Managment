using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Configuration;

namespace WameedhDataAccess

{
    public class ClsBorrowingDetailsDatta
    {
        static string Defaultconnection = "WAMEEDHLAST.Properties.Settings.WameedhDbConnectionString";
        public static int GetItemRowsInBorrowingDetail(int BorrowingID)
        {
            int rows = 1;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string Querey = "select COUNT(BorrowingID) from BorrowingDetails where BorrowingID=@BorrowingID";
            SqlCommand command = new SqlCommand(Querey, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    rows = insertedID;
                }

               
            }
            catch(Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return rows; 

        }
        public static bool GetBorrowingDetailsByID(int BorrwingDetailID, ref int BorrowingID, ref int ItemID, ref byte ItemQuantity, ref string ItemStutu)
        {

            bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM BorrowingDetails WHERE BorrwingDetailID = @BorrwingDetailID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrwingDetailID", BorrwingDetailID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    BorrowingID = (int)reader["BorrowingID"];
                    ItemID = (int)reader["ItemID"];
                    BorrowingID = (int)reader["BorrowingID"];
                    ItemQuantity = (byte)reader["ItemQuantity"];
                    ItemStutu = (string)reader["ItemStutu"];


                }
                else
                {
                    // The record was not found
                    isFound = false;

                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Co nsole.WriteLine("Error: " + ex.Message);
                isFound = false;
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetBorrowingDetailsByBorrowingID(int BorrowingID , ref int BorrwingDetailID, ref int ItemID, ref byte ItemQuantity, ref string ItemStutu)
        {
            
            bool isFound = false;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM BorrowingDetails WHERE BorrowingID = @BorrowingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    BorrwingDetailID = (int)reader["BorrwingDetailID"];
                    ItemID = (int)reader["ItemID"];
                    BorrowingID = (int)reader["BorrowingID"];
                    ItemQuantity = (byte)reader["ItemQuantity"];
                    ItemStutu = (string)reader["ItemStutu"];


                }
                else
                {
                    // The record was not found
                    isFound = false;

                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Co nsole.WriteLine("Error: " + ex.Message);
                isFound = false;
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewBorrowingDetails(int BorrowingID,  int ItemID,  byte ItemQuantity,  string ItemStutu)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int BorrowingDetailsID = -1;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"INSERT INTO BorrowingDetails
                           ( BorrowingID, ItemID,  ItemQuantity,  ItemStutu)
                            
                          
                             VALUES (@BorrowingID,@ItemID,@ItemQuantity,@ItemStutu);
                                  
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID",BorrowingID);
            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@ItemQuantity", ItemQuantity);
            command.Parameters.AddWithValue("@ItemStutu", ItemStutu);
           



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BorrowingDetailsID = insertedID;
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                connection.Close();
            }


            return BorrowingDetailsID;
        }

        public static bool UpdateBorrowings(int BorrwingDetailID,  int BorrowingID,  int ItemID, byte ItemQuantity,  string ItemStutu)

        {

            int rowsAffected = 0;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Update  BorrowingDetails  
                            set BorrowingID = @BorrowingID,
           
                                ItemID = @ItemID,
                                ItemQuantity = @ItemQuantity, 
                                ItemStutu = @ItemStutu
                                
                            where BorrwingDetailID=@BorrwingDetailID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);
            command.Parameters.AddWithValue("@ItemQuantity", ItemQuantity);
            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@ItemStutu", ItemStutu);
            command.Parameters.AddWithValue("@BorrwingDetailID", BorrwingDetailID);





            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                return false;
                throw new Exception(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
        public static bool DeleteBorrowings(int BorrwingDetailID)
        {

            int rowsAffected = 0;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Delete BorrowingDetails 
                                where BorrwingDetailID = @BorrwingDetailID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrwingDetailID", BorrwingDetailID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
      
        public static DataTable GetAllBorrowingDetailsByBorrowingID(int BorrowingID)
        {

            DataTable dt = new DataTable();

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "select * from BorrowingDetails where BorrowingID=@BorrowingID order by BorrowingID";

            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static DataTable GetAllItemsBorrowingDetailsByBorrowingID(int BorrowingID)
        {

            DataTable dt = new DataTable();

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"select  * from (select BorrowingDetails.BorrwingDetailID,ArduinoItems.ItemID,ArduinoItems.ItemName,
                                            BorrowingDetails.ItemQuantity,BorrowingDetails.ItemStutu,BorrowingDetails.BorrowingID
                                            from ArduinoItems inner join BorrowingDetails 
                                            ON BorrowingDetails.ItemID=ArduinoItems.ItemID)
                                            as a where a.BorrowingID=@BorrowingID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static int  GetAllItemqUANTBorrowingDetails( int BorrwingDetailID)
        {

            int ItemQuantity = 0;



            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT ItemQuantity FROM BorrowingDetails WHERE BorrwingDetailID = @BorrwingDetailID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrwingDetailID", BorrwingDetailID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                   
                    
                    ItemQuantity = (byte)reader["ItemQuantity"];
                


                }
                else
                {
                    // The record was not found
                   

                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Co nsole.WriteLine("Error: " + ex.Message);
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ItemQuantity;

        }


    }
}
