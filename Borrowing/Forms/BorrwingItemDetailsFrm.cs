using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WammeedBuisness2;

namespace WAMEEDHLAST
{
    public partial class BorrwingItemDetailsFrm : Form
    {
        private int _BorrwingID = 0;
        public BorrwingItemDetailsFrm(int BorrwingID)
        {
            _BorrwingID = BorrwingID;
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrwingItemDetailsFrm_Load(object sender, EventArgs e)
        {
            DataTable table = ClsBIBorrowingDetails.GetItemsBorrowingDetails(_BorrwingID);
            if (table!=null)
            {
                LbBrrowingID.Text = _BorrwingID.ToString();
                DgvBrrowinDetails.DataSource = table;
                DgvBrrowinDetails.ColumnHeadersHeight = 30;
            }
        }
    }
}
