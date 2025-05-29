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
    public class ClsUsersData
    {
        static string Defaultconnection = "WAMEEDHLAST.Properties.Settings.WameedhDbConnectionString";

        public static bool GetUsersByID(int UserID, ref string UserNAME, ref string Password, ref bool Stutu,ref int PersonID)
        {
            bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    Password = (string)reader["Password"];
                    Stutu = (bool)reader["Stutu"];
                    UserID = (int)reader["UserID"];
                    UserNAME = (string)reader["UserNAME"];
                    PersonID = (int)reader["PersonID"];



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
        public static bool GetUsersByUserNameAndPasswrd(string UserNAME, string Password,  ref int UserID,  ref bool Stutu,ref int PersonID)
        {
            bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM Users WHERE UserNAME = @UserNAME and Password=@Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserNAME", UserNAME);
            command.Parameters.AddWithValue("@Password", Password);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                  
                    
                    UserID = (int)reader["UserID"];
                   Stutu = (bool)reader["Stutu"];


                    PersonID = (int)reader["PersonID"];





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

        public static int AddNewUsers( string UserNAME, string Password, bool Stutu,int PersonID)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int UserID = -1;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"INSERT INTO Users 
               (UserNAME, Password, Stutu,PersonID)
                          
                             VALUES (
                                      @UserNAME,
                                      @Password,@Stutu,@PersonID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Stutu", Stutu);
            command.Parameters.AddWithValue("@UserNAME", UserNAME);
            command.Parameters.AddWithValue("@PersonID", PersonID);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }


            return UserID;
        }
            
                public static bool UpdateUsers(int UserID, string UserNAME, string Password,bool Stutu)

                {

                    int rowsAffected = 0;

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Update  Users  
                            set UserNAME = @UserNAME,
                                Password = @Password,
                                Stutu = @Stutu
                               
                            where UserID=@UserID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Stutu", Stutu);
                    command.Parameters.AddWithValue("@UserNAME", UserNAME);
            command.Parameters.AddWithValue("@UserID",UserID);




            try
            {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch 
                    {

                        return false;
                    }

                    finally
                    {
                        connection.Close();
                    }

                    return (rowsAffected > 0);
                }
                public static bool DeleteUsers(int UserID)
                {

                    int rowsAffected = 0;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Delete Users 
                                where UserID = @UserID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@UserID", UserID);

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
                public static bool IsUsersExist(string UserNAME, string Password)
                {
                    bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query =@"SELECT Found=1 FROM Users WHERE UserNAME = @UserNAME 
                                   and Password=@Password";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@UserNAME", UserNAME);
                    command.Parameters.AddWithValue("@Password", Password);


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
                public static DataTable GetAllUsers()
                {

                    DataTable dt = new DataTable();

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "select userid ,UserNAME, Stutu,PersonID  from Users Order by UserID DESC";


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
   

