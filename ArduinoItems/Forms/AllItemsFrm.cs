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
    public partial class ShowAllItemsFrm : Form
    {
        public ShowAllItemsFrm()
        {
            InitializeComponent();
        }

        private void HandlingItemListView()
        {
            DataTable table = new DataTable();
            table = ClsBiArduinoItems.GetAllArduinoItems();

            DtgAllItems.DataSource = table;
            if (DtgAllItems.RowCount != 0)
            {


                DtgAllItems.ColumnHeadersHeight = 30;
                LBAllitemRecords.Text = (DtgAllItems.RowCount).ToString();
                DtgAllItems.Columns[0].HeaderText = "Item ID";
                DtgAllItems.Columns[1].HeaderText = "Item Name";
                DtgAllItems.Columns[2].HeaderText = "Item Quantity";
                DtgAllItems.Columns[3].HeaderText = "Adding By UserID";
                DtgAllItems.Columns[4].HeaderText = "Item Reference";
                DtgAllItems.Columns[5].HeaderText = "Adding Date";
            }
        }
        private void ShowAllItemsFrm_Load(object sender, EventArgs e)
        {
            this.Width = AccuileFrm.MainContainer.Width;
            HandlingItemListView();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
