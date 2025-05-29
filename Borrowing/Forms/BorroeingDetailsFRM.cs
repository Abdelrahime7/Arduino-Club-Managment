using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WammeedBuisness;

namespace WAMEEDHLAST
{
    public partial class BorroeingDetailsFRM : Form
    {
        private int _BorroeingID = 0;
        ClsBiBorrowings Borrowings;
        public BorroeingDetailsFRM(int BorrowingID)
        {
            this._BorroeingID = BorrowingID;
            InitializeComponent();
        }




        private void BorroeingDetailsFRM_Load(object sender, EventArgs e)
        {
            Borrowings = ClsBiBorrowings.Find(_BorroeingID);
            if (Borrowings!=null)
            {
                crlPersnInfo1.LoadC(Borrowings.Borrower.person);
                crlBorroerInfo1.LoadC(Borrowings.Borrower);
                crlBorrowingsInfo1.LoadC(Borrowings);
            }
         
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnItemDetail_Click(object sender, EventArgs e)
        {
            BorrwingItemDetailsFrm borrwingItemDetail = new BorrwingItemDetailsFrm(_BorroeingID);
            borrwingItemDetail.Show();
            this.Close();
        }
    }
}
