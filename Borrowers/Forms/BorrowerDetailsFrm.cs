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
    public partial class BorrowerDetailsFrm : Form
    {
        private int _BorrowerId = 0;
        ClsBiBorrowers Borrowers;
        public BorrowerDetailsFrm(int BorowerID)
        {
            this._BorrowerId = BorowerID;
            InitializeComponent();
        }

        private void BorrowerDetailsFrm_Load(object sender, EventArgs e)
        {
            Borrowers = ClsBiBorrowers.Find(_BorrowerId);
            if (Borrowers!=null)
            {

                crlPersnInfo1.LoadC(Borrowers.person);
                crlBorroerInfo1.LoadC(Borrowers);
            }

           
        }

      

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crlBorroerInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
