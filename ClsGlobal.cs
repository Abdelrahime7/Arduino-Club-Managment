using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WammeedBuisness;

namespace Wammedh1
{
    internal static class ClsGlobal
    {
        public static ClsBiUsers CurrentUser;
        public static bool GetUserInfoFromFile(ref string UserName, ref string Password)
        {


            try
            {
                //gets the current project's directory
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath = currentDirectory + "\\User Inform.txt";

                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        UserName = reader.ReadLine();
                        Password = reader.ReadLine();

                        if (string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password))
                        {
                            reader.Close();
                            return false;
                        }
                        reader.Close();
                        return true;
                        
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }


        }

    }
}
