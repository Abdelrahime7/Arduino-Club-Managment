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

namespace WAMEEDHLAST
{
    public partial class CrlBorrowingsInfo : UserControl
    {
        public CrlBorrowingsInfo()
        {
            InitializeComponent();
        }


        public void LoadC(ClsBiBorrowings Borrowing)
        {
            if (Borrowing!=null)
            {
                lbBorrowingID.Text = Borrowing.BorrowingID.ToString();
                lbBorrowingDtae.Text = Borrowing.BorrowingDate.ToString();
                lbBorrowingStutus.Text = Borrowing.BorrowingStutu;
                LbBorrowingDuration.Text = Borrowing.BorrowingDuration.ToString();

            }
        }
     
    }
}
