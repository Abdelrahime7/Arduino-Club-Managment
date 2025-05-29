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
    public partial class CrlBorrowerInfo : UserControl
    {
        public CrlBorrowerInfo()
        {
            InitializeComponent();
        }

        public void LoadC(ClsBiBorrowers BorrowerID)
        {
            if (BorrowerID!=null)
            {
                lbBorrowerID.Text = BorrowerID.BorrowerID.ToString();
                LbStudentCard.Text = BorrowerID.StudentCardID;
                LbBorrowerPhone.Text = BorrowerID.BorrowerPhone;
            }

        }

        private void CrlBorroerInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
