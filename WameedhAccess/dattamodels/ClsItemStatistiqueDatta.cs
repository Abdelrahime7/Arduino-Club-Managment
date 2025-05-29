using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WameedhDataAccess

{
   public class ClsItemStatistiqueDatta
    {
        static string Defaultconnection = "WAMEEDHLAST.Properties.Settings.WameedhDbConnectionString";
        public static DataTable GetItemStatistique(int _BorrowingID)
        {
            DataTable dt = new DataTable();

            string connectionstr = ConfigurationManager.ConnectionStrings[Defaultconnection].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstr);


            string query = "SELECT * FROM ItemStatistique where ItemStatistique.[Borrowing ID]=@BorrowingID ";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BorrowingID", _BorrowingID);


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
