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
    public partial class RetrivalinfoFrm : Form
    {
        ClsBiRetrievals Retrievals;
        ClsBiBorrowings Borrowings;
         private int _RetrivalID = 0;
        public RetrivalinfoFrm(int RetrievalID)
        {

            this._RetrivalID = RetrievalID;
            InitializeComponent();
        }

        private void RetrivalinfoFrm_Load(object sender, EventArgs e)
        {
            Retrievals = ClsBiRetrievals.Find(_RetrivalID);
            if (Retrievals!=null)
            {
                LbUserID.Text = Retrievals.UserID.ToString();
                LbretrivalID.Text = Retrievals.RetrievalID.ToString();
                LbRetrievalDate.Text = Retrievals.RetrivalDate.ToString();

                Borrowings = ClsBiBorrowings.Find(Retrievals.BorrowingID);
                if (Borrowings!=null)
                {
                    crlPersnInfo1.LoadC(Borrowings.Borrower.person);
                    crlBorroerInfo1.LoadC(Borrowings.Borrower);
                    crlBorrowingsInfo1.LoadC(Borrowings);
                }
               
            }
           

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnItemDetail_Click(object sender, EventArgs e)
        {
            BorrwingItemDetailsFrm borrwingItemDetail = new BorrwingItemDetailsFrm(Borrowings.BorrowingID);

            borrwingItemDetail.Show();
            this.Close();
        }
    }
}
