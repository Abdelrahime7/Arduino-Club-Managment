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
    public class ClsRetrievalsData
    {
        static string Defaultconnection = "WAMEEDHLAST.Properties.Settings.WameedhDbConnectionString";


        public static bool GetRetrievalsByID(int RetrievalID,ref int BorrowingID,ref string Notes,ref DateTime RetrivalDate, ref int UserID)
        {
            bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM Retrievals WHERE RetrievalID = @RetrievalID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RetrievalID", RetrievalID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    BorrowingID = (int)reader["BorrowingID"];
                   
                    Notes = (string)reader["Notes"];
                    RetrievalID = (int)reader["RetrievalID"];
                    RetrivalDate = (DateTime)reader["RetrivalDate"];
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
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static int AddNewRetrievals(int BorrowingID, string Notes, DateTime RetrivalDate, int UserID)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int RetrievalID = -1;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"INSERT INTO Retrievals 
                             (  BorrowingID,  Notes,  RetrivalDate,   UserID)
                            
                           
                             VALUES (@BorrowingID,@Notes,@RetrivalDate,@UserID);
                             
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);
           
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@RetrivalDate", RetrivalDate);
            command.Parameters.AddWithValue("@UserID", UserID);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    RetrievalID = insertedID;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
            }

        
            return RetrievalID;

        
        }
        public static bool UpdateRetrievals(int RetrievalID,  int BorrowingID,  string Notes, DateTime RetrivalDate,  int UserID)

                {

                    int rowsAffected = 0;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Update  Retrievals  
                            set 
                                BorrowingID = @BorrowingID,
                                Notes = @Notes,
                                RetrivalDate = @RetrivalDate, 
                                UserID=@UserID
                            where RetrievalID=@RetrievalID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@BorrowingID", BorrowingID);
                   
                    command.Parameters.AddWithValue("@Notes", Notes);
                    command.Parameters.AddWithValue("@RetrivalDate", RetrivalDate);
                    command.Parameters.AddWithValue("@UserID", UserID);



                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {

                        return false;
                throw ex;
                    }

                    finally
                    {
                        connection.Close();
                    }

                    return (rowsAffected > 0);
                }
          
       public static bool DeleteRetrievals(int RetrievalID)
                {

                    int rowsAffected = 0;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Delete Retrievals 
                                where RetrievalID = @RetrievalID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@RetrievalID", RetrievalID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                throw ex;
                    }
                    finally
                    {

                        connection.Close();

                    }

                    return (rowsAffected > 0);

                }
       public static bool IsRetrievalsExist(int RetrievalID)
                {
                    bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT Found=1 FROM Retrievals WHERE RetrievalID = @RetrievalID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@RetrievalID", RetrievalID);

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
                throw ex;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return isFound;
                }
        public static DataTable GetAllRetrievals()
                {

                    DataTable dt = new DataTable();

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "select * from Retrievals order by RetrievalID desc";


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
    
