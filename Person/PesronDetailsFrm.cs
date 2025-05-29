using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using WammeedBuisness;

namespace WAMEEDHLAST
{
    public partial class PesronDetailsFrm : Form
    {
        private int _UserID = 0;
        ClsBiUsers User;
        public PesronDetailsFrm(int UsrerId )
        {
            this._UserID = UsrerId;
            InitializeComponent();
        }

      

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesronDetailsFrm_Load(object sender, EventArgs e)
        {
            User = ClsBiUsers.Find(_UserID);

         

            if (User!=null)
            {

                crlPersnInfo1.LoadC(User.person);
                LbUsername.Text = User.UserNAME;
                if (User.Stutu)
                {
                    LbIsActive.Text = "Yes";

                }
                else
                    LbIsActive.Text = "No";
            }

        }
        
    }
}
