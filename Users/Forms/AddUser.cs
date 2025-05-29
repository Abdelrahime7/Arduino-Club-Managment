using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WammeedBuisness;
namespace Wammedh1
{
    public partial class AddUser : Form
    {
        ClsBiUsers User;
        public AddUser()
        {
            InitializeComponent();
        }

       
       private void _clear()
        {
            TBUserFiName.Clear();
            TBUserLaName.Clear();
            TbUsername.Clear();
            TbUserPassword.Clear();
            TbUserCnfirPasword.Clear();
        }

        private void BtnAddUseer_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("you have empty or invalid fields", "Empty field", MessageBoxButtons.OK);

            }
            else
            {
                User = new ClsBiUsers(TBUserFiName.Text,TBUserLaName.Text,ClsGlobal.CurrentUser.UserID);
                User.UserNAME = TbUsername.Text;
                User.Password = TbUserPassword.Text;
                if (CbUserStutu.SelectedIndex==0)
                {
                    User.Stutu = true;
                }
                else
                {
                    User.Stutu = false;
                }
                if (User.Save())
                {
                    _clear();
                    MessageBox.Show("User Added Successfully","Done",MessageBoxButtons.OK);
                }

            }
        }

        private void TBUserFiName_Validating(object sender, CancelEventArgs e)
        {
            if (string .IsNullOrEmpty(TBUserFiName.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(TBUserFiName, "Please enter First Name ");
            }
        }

        private void TBUserLaName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TBUserLaName.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(TBUserLaName, "Please enter Last Name ");
            }

        }

        private void TbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbUsername.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(TbUsername, "Please enter UserName ");
            }
        }

       

        private void TbUserPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbUserPassword.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(TbUserPassword, "Please enter Password ");
            }
        }

        private void TbUserCnfirPasword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(TbUserCnfirPasword.Text)|| TbUserCnfirPasword.Text!= TbUserPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(TbUserPassword, "Please Confirm  Password ");
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void AddUser_Load(object sender, EventArgs e)
        {
            this.Width = AccuileFrm.MainContainer.Width;
        }
    }
}
