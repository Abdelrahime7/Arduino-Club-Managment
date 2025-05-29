using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WameedhDataAccess
{
    public class ClSPersonDatta
    {
        static string Defaultconnection = "WAMEEDHLAST.Properties.Settings.WameedhDbConnectionString";
        public static bool GetPersonByID(int PersonID, ref string  FirstName, ref string LastName,  ref int UserID)
        {
            bool isFound = false;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "SELECT* FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;


                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    if (reader["UserID"]== DBNull.Value)
                    {
                        UserID = -1;
                    }
                    else
                    {
                        UserID = (int)reader["UserID"];
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
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewPerson(string FirstName, string LastName, int UserID)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int PersonID = -1;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"INSERT INTO People
                          (FirstName,LastName,UserID)
                           
                             VALUES (@FirstName,@LastName,@UserID)
                                      
                                      
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@UserID", UserID);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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


            return PersonID;

        }
        public static bool UpdatePerson(int PersonID,string FirstName,string  LastName, int UserID)

        {

            int rowsAffected = 0;
            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Update  People  
                            set 
                                FirstName = @FirstName,
                                LastName = @LastName,
                                UserID = @UserID
                                
                            where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@UserID", UserID);



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
      
       public static bool Delete(int PersonID)
        {
            int rowsAffected = 0;


            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = @"Delete People 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static DataTable GetAllPerson()
        {

            DataTable dt = new DataTable();

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);

            string query = "select * from People  ";


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
