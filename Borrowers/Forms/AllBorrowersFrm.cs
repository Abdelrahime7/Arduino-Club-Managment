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
    public partial class AllBorrowersFrm : Form
    {
        public AllBorrowersFrm()
        {
            InitializeComponent();
        }

        private void HandlingItemListView()
        {
            DataTable table = new DataTable();
            table = ClsBiBorrowers.GetAllBorrowers();
            DatGridAllborwers.DataSource = table;
            if (DatGridAllborwers.RowCount != 0)
            {


                DatGridAllborwers.ColumnHeadersHeight = 30;

                LBBorrwersRecords.Text = (DatGridAllborwers.RowCount-1).ToString();

                DatGridAllborwers.Columns[0].HeaderText = "Borrower ID";

                DatGridAllborwers.Columns[1].HeaderText = "Student Card ID";
                DatGridAllborwers.Columns[1].Width = 180;

                DatGridAllborwers.Columns[2].HeaderText = "Phone Number";
                DatGridAllborwers.Columns[2].Width = 180;

                DatGridAllborwers.Columns[3].HeaderText = " User ID";
                DatGridAllborwers.Columns[4].HeaderText = "Person ID";
            }
        }

        private void AllBorrowersFrm_Load(object sender, EventArgs e)
        {
            this.Width = AccuileFrm.MainContainer.Width;
            HandlingItemListView();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)DatGridAllborwers.CurrentRow.Cells[0].Value;
            BorrowerDetailsFrm borrowerDetails = new BorrowerDetailsFrm(userID);
            borrowerDetails.Show();
        }
    }
}
