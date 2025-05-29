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
    public partial class EditBorrowerFRM : Form
    {
        ClsBiBorrowers biBorrowers;
        public EditBorrowerFRM()
        {
            InitializeComponent();
        }

        private void _Refesh()
        {
            TbCardid.Text = "";
            LbBorrowerID.Text = "";
            TbBorrowerPhone.Text = "";
            TBborrwerFName.Text = "";
            TBborrwerLName.Text = "";
            TbBorrowerCardID.Text = "";
        }
    

        private void EditBorrowerFRM_Load(object sender, EventArgs e)
        {
            this.Width = AccuileFrm.MainContainer.Width;
            BorrowerInfContainer.Enabled = false;
        }

      

        private void BtnSearh_Click(object sender, EventArgs e)
        {

            biBorrowers = ClsBiBorrowers.FindByCardID(TbCardid.Text);
            if (biBorrowers!=null)
            {
                BorrowerInfContainer.Enabled = true;
                LbBorrowerID.Text = biBorrowers.BorrowerID.ToString();
                TbBorrowerPhone.Text = biBorrowers.BorrowerPhone;
                TBborrwerFName.Text = biBorrowers.person.FirstName;
                TBborrwerLName.Text = biBorrowers.person.LastName;
                TbBorrowerCardID.Text = biBorrowers.StudentCardID;
                
            }
            else
            {
                MessageBox.Show($"There Is No Borrower has Student Card ID = {TbCardid.Text}", "NOT fOUND", MessageBoxButtons.OK);
            }

        }

        private void BtnEditBorrower_Click(object sender, EventArgs e)
        {
            biBorrowers = new ClsBiBorrowers(int.Parse(LbBorrowerID.Text), TbBorrowerCardID.Text, TbBorrowerPhone.Text,
                                           ClsGlobal.CurrentUser.UserID, biBorrowers.PersonID);
            if(biBorrowers!=null)
                {
                biBorrowers.person = new ClsBIPerson(biBorrowers.PersonID, TBborrwerFName.Text, TBborrwerLName.Text, ClsGlobal.CurrentUser.UserID);
                if (biBorrowers.person.Save()&& biBorrowers.Save())
                {

                    MessageBox.Show("Borrower Edited Successfully !!", "Done", MessageBoxButtons.OK);
                    _Refesh();
                }
            }
            else
            {
                MessageBox.Show("Something went Wrong !!", "Erorr", MessageBoxButtons.OK);
                _Refesh();
            }
        }

        private void BtnSearchClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
