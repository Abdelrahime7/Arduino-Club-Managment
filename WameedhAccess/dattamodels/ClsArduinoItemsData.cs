using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using WameedhAccess.dattamodels;


namespace WameedhDataAccess
{

    public class ClsArduinoItemsData : IDataProvider
    {

        static string Defaultconnection = "WAMEEDHLAST.Properties.Settings.WameedhDbConnectionString";
       static string  connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;

        public string getPrvider()
        {
            string Defaultconnection = "WAMEEDHLAST.Properties.Settings.WameedhDbConnectionString";
            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            return connectionstr;
        }

        public static int GetItemQuntity(int ItemID)
        {

            int ItemNumbr = 0;
           
            SqlConnection connection = new SqlConnection(connectionstr);
            string query = "SELECT* FROM ArduinoItems WHERE ItemID = @ItemID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);


         
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found

                    ItemNumbr = (int)reader["ItemNumber"];

                }
                else
                {
                    // The record was not found

                }

                     reader.Close();
                return ItemNumbr;
            
         }
        public static void UpdateItemQuantity(int ItemID, int Amount)
        {

           SqlConnection connection = new SqlConnection(connectionstr);

            string Querey = @" update ArduinoItems
                            set ItemNumber = @Amount where ItemID = @ItemID";


            SqlCommand command = new SqlCommand(Querey, connection);


            command.Parameters.AddWithValue("@ItemID", ItemID);

            command.Parameters.AddWithValue("@Amount", Amount);

            try
            {
                connection.Open();
                 command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

               
            }

            finally
            {
                connection.Close();
            }



        }
        public static bool GetArduinoItemsByID(int ItemID ,ref string ItemName, ref int ItemNumbr, 
            ref int UserID,ref DateTime AddingDate,ref bool IsIncluded)
            
        {
            bool isFound = false;


            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM ArduinoItems WHERE ItemID = @ItemID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);
            

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    // The record was found
                    isFound = true;
                    ItemName = (string)reader["ItemName"];
                    ItemNumbr = (int)reader["ItemNumber"];
                    UserID = (int)reader["UserID"];
                    if (reader["AddingDate"] == DBNull.Value)
                    {
                        AddingDate = new DateTime();
                    }
                    else
                    {
                        AddingDate = (DateTime)reader["AddingDate"];
                    }
                    if (reader["IsIncluded"] == DBNull.Value)
                    {
                        IsIncluded = false;
                    }
                    else
                    {
                        IsIncluded = (bool)reader["IsIncluded"];
                    }
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
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static int GetArduinoItemiDByName( string ItemName)

        {

            int ItemID = 0;


            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM ArduinoItems WHERE ItemName = @ItemName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemName", ItemName);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                   
                  return  ItemID = (int)reader["ItemID"];
                    //ItemNumbr = (int)reader["ItemNumber"];
                    //UserID = (int)reader["UserID"];

                    //AddingDate = (DateTime)reader["AddingDate"];


                }
                else
                {
                    // The record was not found
                    ItemID = -1;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Co nsole.WriteLine("Error: " + ex.Message);
                ItemID = -1;
            }
            finally
            {
                connection.Close();
            }

            return ItemID;
        }

        public static bool changeIndlucdingItemsStutus(int ItemID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Update  ArduinoItems              
                             set  IsIncluded =  1
                               
                            where ItemID=@ItemID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);
          



            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
        public static int AddNewArduinoItem( string ItemName, int ItemNumber, int UserID, DateTime AddingDate)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int ItemID = -1;


            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"INSERT INTO ArduinoItems
                           (ItemName,ItemNumber,UserID,AddingDate)
                            
                             VALUES (@ItemName,@ItemNumber,@UserID,@AddingDate);
                             
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemName", ItemName);
          //  command.Parameters.AddWithValue("ItemReference", ItemReference);
            command.Parameters.AddWithValue("@ItemNumber", ItemNumber);
            command.Parameters.AddWithValue("@AddingDate", AddingDate);
            command.Parameters.AddWithValue("@UserID", UserID);
            //  command.Parameters.AddWithValue("ItemReference", ItemReference);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ItemID = insertedID;
                }
            }

            catch (Exception ex)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }


            return ItemID;

        }
        public static bool UpdateArduinoItem(int ItemID,string ItemName, int ItemNumber, int UserID,DateTime AddingDate)

        {


            int rowsAffected = 0;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Update  ArduinoItems              
                             set  ItemName = @ItemName,
                                ItemNumber = @ItemNumber,
                                UserID = @UserID, 
                               AddingDate=@AddingDate
                            where ItemID=@ItemID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID",ItemID);
          // command.Parameters.AddWithValue("ItemReference",@ItemReference);
            command.Parameters.AddWithValue("@ItemName",ItemName);
            command.Parameters.AddWithValue("@ItemNumber",ItemNumber);
            command.Parameters.AddWithValue("@UserID",UserID);
            command.Parameters.AddWithValue("@AddingDate",AddingDate);




            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
        public static bool DeleteArduinoItems(int ItemID)
        {

            int rowsAffected = 0;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Delete ArduinoItems 
                                where ItemID = @ItemID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID",ItemID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
        public static bool IsArduinoItemsExist(int ItemID)
        {
            bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT Found=1 FROM ArduinoItems WHERE ItemID = @ItemID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;

                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static DataTable GetAllArduinoItems()
        {
            
            DataTable dt = new DataTable();
            
            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
           SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT * FROM ArduinoItems order by AddingDate Desc";


                SqlCommand command = new SqlCommand(query, connection);

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
                throw  new Exception(ex.Message);
                // Console.WriteLine(
                // "Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

      
    }
}
    



