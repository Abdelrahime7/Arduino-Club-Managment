using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WammeedBuisness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Wammedh1
{
    public partial class LoginFRm : Form
    {
        public LoginFRm()
        {
           
            InitializeComponent();

        }

      
           
           
       

        private void HandleRememberMeLogin(string FilePath,string UserName, string Password)
        {

            if (CbRememberMe.Checked)
            {

                using (StreamWriter Writer = new StreamWriter(FilePath))
                {

                    Writer.WriteLine(UserName);
                    Writer.WriteLine(Password);

                    Writer.Close();
                }

            }
            else
            {
                using (StreamWriter Writer = new StreamWriter(FilePath))
                {

                    Writer.WriteLine("");
                    Writer.Close();

                }

            }
        }
        

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

      
        private void LoginFRm_Load(object sender, EventArgs e)
        {
            string UserName = "";string Passwrd = "";
            guna2ShadowForm1.SetShadowForm(this);

            if (ClsGlobal.GetUserInfoFromFile(ref UserName ,ref Passwrd))

            {
                TbUserName.Text = UserName;
                TbPassword.Text = Passwrd;
                CbRememberMe.Checked = true;
            }
            else
                CbRememberMe.Checked = false;
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Pleas Enter UserName And Password", "Empty field", MessageBoxButtons.OK);

            }
            else
            {

                string UserName = TbUserName.Text;
                string Password = TbPassword.Text;
                string FilePath = "User Inform.txt";
                ClsBiUsers User = ClsBiUsers.FindUserByUserNameAndPassword(UserName, Password);

                if (User != null)

                {
                    ClsGlobal.CurrentUser = User;
                    HandleRememberMeLogin(FilePath, UserName, Password);

                    this.Hide();
                    AccuileFrm Accueil = new AccuileFrm(this);
                    Accueil.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserName And Password","Wrong Information", MessageBoxButtons.OK);
                }
            }
        }

        private void TbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbUserName.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(TbUserName, "UserName cannot be empty!");
            }
        }

        private void TbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbPassword.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(TbPassword, "Password cannot be empty!");
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
