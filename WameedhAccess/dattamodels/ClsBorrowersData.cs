using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace WameedhDataAccess
{
    public class ClsBorrowersData
    {
       static string  Defaultconnection = "WAMEEDHLAST.Properties.Settings.WameedhDbConnectionString";
        public static bool GetBorrowersByID( int BorrowerID,  ref string BorrowerPhone, ref string StudentCardID, ref int UserID, ref int PersonID)
        {
            bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM Borrowers WHERE BorrowerID = @BorrowerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowerID", BorrowerID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    BorrowerID = (int)reader["BorrowerID"];
                    BorrowerPhone = (string)reader["BorrowerPhone"];
                    PersonID = (int)reader["PersonID"];
                    StudentCardID = (string)reader["StudentCardID"];
                    
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
        public static bool GetBorrowersByStudentCardID(string StudentCardID, ref string BorrowerPhone, ref int BorrowerID, ref int UserID, ref int PersonID)
        {
            bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM Borrowers WHERE StudentCardID = @StudentCardID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentCardID", StudentCardID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    BorrowerID = (int)reader["BorrowerID"];
                    BorrowerPhone = (string)reader["BorrowerPhone"];
                    PersonID = (int)reader["PersonID"];

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

        public static int AddNewBorrower(  string BorrowerPhone, string StudentCardID, int UserID,int PersonID)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int BorrowerID = -1;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"INSERT INTO Borrowers
                          (BorrowerPhone,StudentCardID,UserID, PersonID)
                           
                             VALUES (@BorrowerPhone,
                                      @StudentCardID,@UserID,@PersonID);
                                      
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BorrowerPhone", BorrowerPhone);
            command.Parameters.AddWithValue("@StudentCardID", StudentCardID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID",PersonID);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BorrowerID = insertedID;
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


            return BorrowerID;

        }
        public static bool UpdateBorrower( int BorrowerID,  string BorrowerPhone,  string StudentCardID, int UserID,int PersonID)

                {

                    int rowsAffected = 0;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Update  Borrowers  
                            set 
                                BorrowerPhone = @BorrowerPhone,
                                StudentCardID = @StudentCardID, 
                                UserID = @UserID,
                                PersonID = @PersonID

                                
                            where BorrowerID=@BorrowerID";

                    SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BorrowerID", BorrowerID);

            command.Parameters.AddWithValue("@BorrowerPhone",BorrowerPhone);
             command.Parameters.AddWithValue("@StudentCardID",StudentCardID);
            command.Parameters.AddWithValue("@PersonID",PersonID);

            command.Parameters.AddWithValue("@UserID",UserID);



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
       public static bool DeleteBorrowers(int BorrowerID)
                {

                    int rowsAffected = 0;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Delete Borrowers 
                                where BorrowerID = @BorrowerID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@BorrowerID", BorrowerID);

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
       public static bool IsBorrowersExist(int BorrowerID)
                {
                    bool isFound = false;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT Found=1 FROM Borrowers WHERE BorrowerID = @BorrowerID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@BorrowerID", BorrowerID);

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
                throw new Exception(ex.Message);

                     }
                  finally
                    {
                        connection.Close();
                    }

                    return isFound;
                }
                public static DataTable GetAllBorrowers()
                {

                    DataTable dt = new DataTable();

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "select *from Borrowers order by BorrowerID ";


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
                throw new Exception(ex.Message);
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
