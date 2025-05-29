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
    public partial class AllBorrowingsFRM : Form
    {
        BindingSource binding = new BindingSource();

        public AllBorrowingsFRM()
        {
            InitializeComponent();
        }
        private void _HandleDgvFormat()
        {
            DataTable table = new DataTable();
            table = ClsBiBorrowings.GetAllBorrowings();
            binding.DataSource = table;
            DTGAllBorrowings.DataSource = binding;
            if (DTGAllBorrowings.RowCount != 0)
            {


                DTGAllBorrowings.ColumnHeadersHeight = 30;
                LBBorrwingsRecords.Text = (DTGAllBorrowings.RowCount-1).ToString();
                DTGAllBorrowings.Columns[0].HeaderText = "BorrowingID";
                DTGAllBorrowings.Columns[1].HeaderText = "Borrower ID";
                DTGAllBorrowings.Columns[2].HeaderText = "Notes";

                DTGAllBorrowings.Columns[3].HeaderText = "Borrowing Date";
                DTGAllBorrowings.Columns[3].Width = 160;

                DTGAllBorrowings.Columns[4].HeaderText = "Created By User ";
                DTGAllBorrowings.Columns[4].Width = 150;

                DTGAllBorrowings.Columns[5].HeaderText = "Borrowing Stutus";
                DTGAllBorrowings.Columns[5].Width = 160;

                DTGAllBorrowings.Columns[6].HeaderText = " Duration";
                DTGAllBorrowings.Columns[6].Width = 100;

            }
            else
            {
                CbBorrowingStutus.Enabled = false;
            }

        }

        private void AllBorrowingsFRM_Load(object sender, EventArgs e)
        {
            this.Width = AccuileFrm.MainContainer.Width;
            _HandleDgvFormat();
        }

        private void DatGridAllBorowingsPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BorrowingID = 0;
            BorrowingID =(int) DTGAllBorrowings.CurrentRow.Cells[0].Value;
            BorroeingDetailsFRM borroeingDetails = new BorroeingDetailsFRM(BorrowingID);
            borroeingDetails.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbBorrowingStutus.SelectedIndex == 1)
            {
                string filter = "Borrowed";
                binding.Filter = $"BorrowingStutu like'%{filter}%'";


            }
          else  if (CbBorrowingStutus.SelectedIndex == 2)
            {
                string filter = "Retrieved";
                binding.Filter = $"BorrowingStutu like'%{filter}%'";


            }
            else
            {
                binding.RemoveFilter();
            }

        }
    }
}
