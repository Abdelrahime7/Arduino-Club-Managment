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
using WammeedBuisness2;

namespace Wammedh1
{
    public partial class RetrivalProcessFrm : Form
    {
        ClsBiArduinoItems arduinoItems;
        public ClsBiBorrowings Borrowings;
        private int _BorrowingsID;
        public RetrivalProcessFrm()
        {
         
            InitializeComponent();
        }

        private void CreateItemStatistiqueTable(int _BorrowingsID)
        {

            DataTable ItemStatistique = new DataTable();
            ItemStatistique = ClsBiItemStatistique.GetItemStatistique(_BorrowingsID);
            if (ItemStatistique.Rows.Count>0)
            {
                DgvItemStatistique.DataSource = ItemStatistique;
                DgvItemStatistique.AutoSize = true;
                DgvItemStatistique.ColumnHeadersHeight = 30;

                DgvItemStatistique.Columns[0].HeaderText = "Borrowing ID";
                DgvItemStatistique.Columns[1].HeaderText = "Item Name";
                DgvItemStatistique.Columns[2].HeaderText = "Item Quantity";
                DgvItemStatistique.Columns[3].HeaderText = "Item Stutus";
                DgvItemStatistique.Columns[4].HeaderText = "Item ID";

            }



        }

        private void RetrivalProcessFrm_Load(object sender, EventArgs e)
        {
            this.Width = AccuileFrm.MainContainer.Width;
            RetContainer.Enabled = false;
            

        }

        private void BtnSearh_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(TbItemId.Text, out _BorrowingsID)))
            {
                MessageBox.Show("Borrowing ID Should Be A number");
            }
            else {

                Borrowings = ClsBiBorrowings.Find(_BorrowingsID);
                if (Borrowings != null)
                {
                    if (Borrowings.BorrowingStutu == "Retrieved")
                    {
                        MessageBox.Show(" Borrowing Process has been retrieved");
                    }
                    else
                    {
                        RetContainer.Enabled = true;
                        LbBorName.Text = Borrowings.Borrower.person.FirstName + " " + Borrowings.Borrower.person.LastName;
                        LbBorrowerCart.Text = Borrowings.Borrower.StudentCardID.ToString();
                        DpBorrwingDate.Value = Borrowings.BorrowingDate;
                        LBBorrStutus.Text = Borrowings.BorrowingStutu;
                        CreateItemStatistiqueTable(_BorrowingsID);
                    }



                }
                else
                {
                    MessageBox.Show($"There is No Borrowing Process following to ID ={_BorrowingsID}", "ID not Found", MessageBoxButtons.OK);
                }

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

        private void _RetrievItemQua()
        {
            int ItemID = 0;
           int Amount = 0;

            int rows = DgvItemStatistique.Rows.Count ;
            for (int i = 0; i < rows; i++)
            {
                ItemID = (int)DgvItemStatistique.Rows[i].Cells[4].Value;
                


                arduinoItems = ClsBiArduinoItems.Find(ItemID);

                Amount = (Byte)DgvItemStatistique.Rows[i].Cells[2].Value + arduinoItems.ItemNumber;

                ClsBiArduinoItems.UpdateItemQuantity(ItemID, Amount);

            }
        }
        private void _Refrech()
        {
           BtnRetrieve.Enabled = false; ;
            LbBorName.Text = "";
            LbBorrowerCart.Text = "";
            DpBorrwingDate.Value = DateTime.Now;
            LBBorrStutus.Text = "";

        }
        private void BtnEditItem_Click(object sender, EventArgs e)
        {
            ClsBiRetrievals retrievals = new ClsBiRetrievals();
            retrievals.BorrowingID = _BorrowingsID;
            retrievals.RetrivalDate = DateTime.Now;
            retrievals.UserID = ClsGlobal.CurrentUser.UserID;
            retrievals.Notes = TbRetrievalNtes.Text;
            if (MessageBox.Show("Are you sure to Retreive this Borrowing ?","Confirm",MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                if (retrievals.Save())

                {
                    _RetrievItemQua();
                    ClsBiBorrowings.ChangeBorrowingStutus(_BorrowingsID);

                    MessageBox.Show(" Retreival Process done Successfully !!", "Done", MessageBoxButtons.OK);
                    _Refrech();
                }
            }
            
            
        }

      
    }
}
