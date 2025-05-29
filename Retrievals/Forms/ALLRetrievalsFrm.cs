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
    public partial class ALLRetrievalsFrm : Form
    {
        public ALLRetrievalsFrm()
        {
            InitializeComponent();
        }


        private void HandlinListView()
        {
            DataTable table = new DataTable();
            table = ClsBiRetrievals.GetAllRetrievals();
            DatGridAllRetrivals.DataSource = table;
            if (DatGridAllRetrivals.RowCount !=0)
            {
                DatGridAllRetrivals.ColumnHeadersHeight = 30;
                lbRetievalsRecrd.Text = (DatGridAllRetrivals.RowCount).ToString();
                DatGridAllRetrivals.Columns[0].HeaderText = "Retrieval ID";
                DatGridAllRetrivals.Columns[1].HeaderText = "Borrowing ID";
                DatGridAllRetrivals.Columns[2].HeaderText = "Notes";
                DatGridAllRetrivals.Columns[3].HeaderText = "Retrieval Date";
                DatGridAllRetrivals.Columns[4].HeaderText = "Retrieved By";
            }
            else
            {
                MessageBox.Show("there Is No Retrieval Process yet !!","oops",MessageBoxButtons.OK);
            }
          



        }

        private void ALLRetrievalsFrm_Load(object sender, EventArgs e)
        {
            this.Width = AccuileFrm.MainContainer.Width;
            HandlinListView();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seeDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RetirvalsId = 0;
            RetirvalsId =(int) DatGridAllRetrivals.CurrentRow.Cells[0].Value;
            RetrivalinfoFrm retrivalinfo = new RetrivalinfoFrm(RetirvalsId);
            retrivalinfo.Show();

        }
    }
}
