using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WammeedBuisness;

namespace Wammedh1
{
    public partial class EditUserFrm : Form
    {
        ClsBiUsers User;
        public EditUserFrm()
        {
            InitializeComponent();
        }

        private void EditUserFrm_Load(object sender, EventArgs e)
        {
            _refrech();
        }

        private void BtnSearh_Click(object sender, EventArgs e)
        {
            User = ClsBiUsers.Find(int.Parse(TbUserId.Text));
            if (User!=null)
            {
                BorrowerInfContainer.Enabled = true;
                UserContainerINFO.Enabled = true;

                TBUserFiName.Text = User.person.FirstName;
                TBUserLaName.Text = User.person.LastName;
                TbUsername.Text = User.UserNAME;
                TbUserPassword.Focus();
                if (User.Stutu)
                {
                    CBUserStutus.SelectedIndex = 0;
                }
                else
                    CBUserStutus.SelectedIndex = 1;

            }
            else
            {
                MessageBox.Show($"there is no User withe User ID = {TbUserId.Text}");
            }
        }

        private void _refrech()
        {
            this.Width = AccuileFrm.MainContainer.Width;
            BorrowerInfContainer.Enabled = false;
            UserContainerINFO.Enabled = false;
            TbUserId.Text = "";
            TBUserFiName.Text = "";
            TBUserLaName.Text = "";
            TbUsername.Text = "";
            TbUserPassword.Text = "";
            TbUserCnfirPasword.Text = "";

        }

        private void BtnEditUseer_Click(object sender, EventArgs e)
        {
            if (TbUserCnfirPasword.Text != TbUserPassword.Text)

            {
                TbUserCnfirPasword.Focus();
                errorProvider1.SetError(TbUserCnfirPasword, "passwords not matched");
                MessageBox.Show("Confirm your Password ", "Confirm", MessageBoxButtons.OK);
            }
            else
            {


                if (MessageBox.Show("Are you sure you want to Edit this user ??", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    User = new ClsBiUsers(int.Parse(TbUserId.Text), TbUsername.Text, TbUserPassword.Text, CBUserStutus.SelectedIndex == 0, User.PersonID, true);
                    if (User.Save())

                    {
                        MessageBox.Show("User Edited Successfully !!", "Done", MessageBoxButtons.OK);
                        _refrech();
                    }

                    else
                        MessageBox.Show("Something went wrong !!", "Failed", MessageBoxButtons.OK);
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
