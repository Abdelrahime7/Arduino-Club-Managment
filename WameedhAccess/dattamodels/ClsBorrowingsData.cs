using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WameedhDataAccess
{
    public class ClsBorrowingsData
    {
        static string Defaultconnection = "WAMEEDHLAST.Properties.Settings.WameedhDbConnectionString";
        public static void ChangeBorrowinigStutuS(int BorrowingID)
        {

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Update Borrowings 
                             set BorrowingStutu = 'Retrieved'
                             where BorrowingID=@BorrowingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            finally
            {
                connection.Close();
            }

        }
        public static bool GetBorrowingsByID(int BorrowingID,ref int BorrowerID,ref  string BorrowingStutu,ref  string Notes,ref DateTime BorrowingDate,ref Byte BorrowingDuration,ref int UserID)
        {
            
            bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);
            string query = "SELECT* FROM Borrowings WHERE BorrowingID = @BorrowingID";

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
                    
                
                        BorrowerID = (int)reader["BorrowerID"];
                   
                   
                    BorrowingDate = (DateTime)reader["BorrowingDate"];
                    BorrowingStutu = (string)reader["BorrowingStutu"];

                    if (reader["Notes"] == DBNull.Value)
                    {
                        Notes = "";
                    }
                    else
                    {
                        Notes = (string)reader["Notes"];
                    }
                    if (reader["BorrowingDuration"]== DBNull.Value)
                    {
                        BorrowingDuration = 0;
                    }
                    else
                    {
                        BorrowingDuration = (Byte)reader["BorrowingDuration"];
                    }


                    
                    UserID = (int)reader["UserID"];


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
        public static int AddNewBorrowing(  int BorrowerID, string BorrowingStutu, string Notes, DateTime BorrowingDate, int BorrowingDuration, int UserID)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int BorrowingsID = -1;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"INSERT INTO Borrowings
                           (BorrowerID,BorrowingDate,UserID ,BorrowingStutu)
                          
                             VALUES (@BorrowerID,@BorrowingDate,@UserID ,@BorrowingStutu);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowerID", BorrowerID);
            command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
            command.Parameters.AddWithValue("@BorrowingStutu", BorrowingStutu);
            command.Parameters.AddWithValue("@UserID", UserID);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BorrowingsID = insertedID;
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


            return BorrowingsID;
        }
            
        public static bool UpdateBorrowings( int BorrowingID, int BorrowerID,  string BorrowingStutu, string Notes, DateTime BorrowingDate,  int BorrowingDuration, int UserID)

        {

                    int rowsAffected = 0;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);


            string query = @"Update  Borrowings  
                            set BorrowingDate = @BorrowingDate,
                                BorrowerID = @BorrowerID,
                            BorrowingStutu=@BorrowingStutu,
                               BorrowingDuration=@BorrowingDuration,
                                Notes = @Notes,
                                UserID=@UserID
                            where BorrowingID=@BorrowingID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@BorrowerID", BorrowerID);
                    command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
                    command.Parameters.AddWithValue("@BorrowingDuration", BorrowingDuration);
                    command.Parameters.AddWithValue("@BorrowingStutu", BorrowingStutu);
                    command.Parameters.AddWithValue("@Notes", Notes);
                    command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);




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
        public static bool UpdateBorrowingToSave(int BorrowingID, string Notes, byte BorrowingDuration)

        {

            int rowsAffected = 0;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Update  Borrowings  
                            set   BorrowingDuration=@BorrowingDuration,
                                  Notes = @Notes
                                  where BorrowingID=@BorrowingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);
            command.Parameters.AddWithValue("@BorrowingDuration", BorrowingDuration);
            command.Parameters.AddWithValue("@Notes", Notes);



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

        public static bool DeleteBorrowings(int BorrowingID)
                {

                    int rowsAffected = 0;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Delete Borrowings 
                                where BorrowingID = @BorrowingID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@BorrowingID", BorrowingID);

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
        public static bool IsBorrowingsExist(int BorrowingID)
                {
                    bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT Found=1 FROM Borrowings WHERE BorrowingID = @BorrowingID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@BorrowingID", BorrowingID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        isFound = reader.HasRows;

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine("Error: " + ex.Message);
                        isFound = false;
                
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return isFound;
                }
        public static DataTable GetAllBorrowings()
                {

                    DataTable dt = new DataTable();

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "select * from Borrowings  order by BorrowingID desc";


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
                        // Console.WriteLine("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return dt;

                }


    }

}
    
