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
    public partial class DeleteUserFrm : Form
    {
        ClsBiUsers User;
        public DeleteUserFrm()
        {
            InitializeComponent();
        }

        private void BtnSearh_Click(object sender, EventArgs e)
        {
            User = ClsBiUsers.Find(int.Parse(TbUserd.Text));
            if (User != null)
            {
                BtnDeleteUseer.Enabled = true;
               
              LBuserFname.Text = User.person.FirstName;
                lbUserLname.Text = User.person.LastName;
                LbUserName.Text = User.UserNAME;
               
                if (User.Stutu)
                {
                    LbUserStutus.Text = "On";
                }
                else
                    LbUserStutus.Text = "Off";

            }
            else
            {
                MessageBox.Show($"there is no User withe User ID = {TbUserd.Text}");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddUseer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User  !!", "Cnfirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (ClsBiUsers.Delete(User.UserID))
                {
                    MessageBox.Show("User deleted Successfully !!", "done", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("something  wrong happend !!", "Failed", MessageBoxButtons.OK);
                }
            }
        }

        private void DeleteUserFrm_Load(object sender, EventArgs e)
        {
            this.Width = AccuileFrm.MainContainer.Width;
            BtnDeleteUseer.Enabled = false;

        }

        private void LBuserFname_Click(object sender, EventArgs e)
        {

        }

        private void LbUserStutus_Click(object sender, EventArgs e)
        {

        }
    }
}
