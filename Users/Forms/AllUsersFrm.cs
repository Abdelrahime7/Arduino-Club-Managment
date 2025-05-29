using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WAMEEDHLAST;
using WammeedBuisness;

namespace Wammedh1
{
    public partial class AllUsersFrm : Form
    {
        public AllUsersFrm()
        {
            InitializeComponent();
        }

        private void HandlingUserListView()
        {
            DataTable table = new DataTable();
            table = ClsBiUsers.GetAllUsers();
           DtgAllUsers.DataSource = table;
            if (DtgAllUsers.RowCount != 0)
            {


                DtgAllUsers.ColumnHeadersHeight = 30;
                LBUsersRecords.Text = (DtgAllUsers.RowCount-1).ToString();
                DtgAllUsers.Columns[0].HeaderText = "User ID";
                DtgAllUsers.Columns[1].HeaderText = "UserName";

                DtgAllUsers.Columns[2].HeaderText = "User Stutus";
                DtgAllUsers.Columns[3].HeaderText = "Person ID";


            }
        }

        private void AllUsersFrm_Load(object sender, EventArgs e)
        {
            this.Width = AccuileFrm.MainContainer.Width;
            HandlingUserListView();
        }

        private void seeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID =(int)DtgAllUsers.CurrentRow.Cells[0].Value;
            PesronDetailsFrm pesronDetailsFrm = new PesronDetailsFrm(userID);
            pesronDetailsFrm.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
