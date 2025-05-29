using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WammeedBuisness;
using WammeedBuisness2;

namespace Wammedh1
{

    public partial class BorrwingsProcessFrm : Form
    {
        public enum Enmode { EnAdd = 1, EnEdit = 2 };
        public Enmode Mode;

        private bool IsExistedBorrwer;
        private bool IsProcessDone = false;
        private bool IsFirstAdding = true;
        private int BorrowingID;
        private int BorrDetailsIDIncr = 0;
        private int _Rows = 1;

        List<int> PrevItemsQuantity = new List<int>();
        List<int> LisitmeID = new List<int>();

        

        ClsBIPerson person;
        ClsBiBorrowers Borrower;
        ClsBiBorrowings Borrowing;

        ClsBIBorrowingDetails BorrowingDetails;

        int UserId = ClsGlobal.CurrentUser.UserID;


        public BorrwingsProcessFrm(Byte mode)
        {
            Mode = (Enmode)mode;
            InitializeComponent();
        }



        private void BorrwingsProcessFrm_Load(object sender, EventArgs e)
        {
            
            this.Width = AccuileFrm.MainContainer.Width;
            DgVItemsDetails.Enabled = false;
          DgVItemsDetails.Hide();
            BtnFinishe.Enabled = false;

            switch (Mode)
            {
                case Enmode.EnAdd:
                    DtBorrwingDate.Value = DateTime.Now;
                    BorrwingSearchCntainer.Hide();
                    BtnBorrowingEdit.Hide();
                    BtnBorrowingsDone.Enabled = false;
                    break;

                case Enmode.EnEdit:
                   

                    BtnBorrowingsDone.Hide();
                    PnlIteInfo.Enabled = false;
                    label8.Hide();
                    BorrwingSearchCntainer.Show();
                    BorrowingContainer.Enabled = false;

                    break;

            }
        }
        private void AddBorrower()
        {
            Borrower = ClsBiBorrowers.FindByCardID(TbBorrowerCardID.Text);
            if (Borrower == null)
            {

                IsExistedBorrwer = false;
                Borrower = new ClsBiBorrowers(TBborrwerFName.Text, TBborrwerLName.Text, UserId);

                Borrower.StudentCardID = TbBorrowerCardID.Text;
                Borrower.BorrowerPhone = TbBorrowerPhone.Text;
                Borrower.UserID = UserId;

                Borrower.Save();

            }
            else
            {
                IsExistedBorrwer = true;
            }

        }

        private bool AddBorrowing()
        {
            AddBorrower();
            if (Borrower != null)
            {
                Borrowing = new ClsBiBorrowings();
                Borrowing.BorrowerID = Borrower.BorrowerID;
                Borrowing.BorrowingDate = DtBorrwingDate.Value;
                Borrowing.UserID = UserId;
                Borrowing.BorrowingStutu = "Borrowed";

                return Borrowing.Save();

            }
            return false;
        }

  
        

        private void BtnClose_Click(object sender, EventArgs e)
        {
            

            if (IsProcessDone == true ||  Mode==Enmode.EnEdit)
            {
                this.Close();

            }
            else
            {


                if (MessageBox.Show("You want to Cancel this Process !! ", "Confirm", MessageBoxButtons.OKCancel)
                     == DialogResult.OK)
                {
                    if (Borrower != null)
                    {


                        for (int i = 0; i <= BorrDetailsIDIncr; i++)
                        {
                            ClsBIBorrowingDetails.Delete(BorrowingDetails.BorrowingDetailsID-i);
                           
                            _RetrievItemQuantity(PrevItemsQuantity[i], LisitmeID[i]);

                        }
                       

                        ClsBiBorrowings.Delete(Borrowing.BorrowingID);
                        if (!IsExistedBorrwer)
                        {
                            ClsBiBorrowers.Delete(Borrower.BorrowerID);
                            ClsBIPerson.Delete(Borrower.PersonID);
                        }

                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }


                }

            }


        }

        private void BtnBorrowingsDone_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to Add this Borrwing Process !! ", "Confirm", MessageBoxButtons.OKCancel)
               == DialogResult.OK)
            {
                if (ClsBiBorrowings.UpdatToSaveFinalVersin(Borrowing.BorrowingID, TbBorrowingNotes.Text, (byte)BorrowingDuration.Value))
                {
                    IsProcessDone = true;
                    MessageBox.Show(" Borrowing Process  completed successfully!! ", "Done", MessageBoxButtons.OK);
                    _Refrech();
                }
                else
                {
                    MessageBox.Show("Somthing Went wrong !! ", "Erorr", MessageBoxButtons.OK);

                }
            }
        }
    

    private void _Refrech()
    {
            BtnBorrowingsDone.Enabled = false;
            BtnFinishe.Enabled = false;

        //borrwer section:
        TBborrwerFName.Clear();
        TBborrwerLName.Clear();
        TbBorrowerCardID.Clear();
        TbBorrowerPhone.Clear();

        //ItemSection
        TbBItemName.Clear();
        NudItemQuantity.Value = 1;
        TbBItemStutus.Clear();

        //BorrowingSectin
        BorrowingDuration.Value = 1;
        TbBorrowingNotes.Clear();

    }





        private void TBborrwerLName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(TBborrwerLName.Text.Trim()))
            {

                errorProvider1.SetError(TBborrwerLName, "borrwer Last Name  cannot be empty!");
            }
        }



        private void TBborrwerFName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TBborrwerFName.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(TBborrwerFName, "borrwer First Name  cannot be empty!");
            }
        }
        private void TbBorrowerCardID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbBorrowerCardID.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(TbBorrowerCardID, "Borrower Student Card ID cannot be empty!");
            }
        }
        private void TbBorrowerPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbBorrowerPhone.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(TbBorrowerPhone, "borrwer Phone  cannot be empty!");
            }
        }

        private void TbBItemName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(TbBItemName.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(TbBItemName, "Items Name  cannot be empty!");
            }
        }
        private void TbBItemStutus_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(TbBItemStutus.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(TbBItemStutus, "Item Stutus  cannot be empty!");
            }
        }

        private void _PrevieusItemquantity()
        {
            LisitmeID.Add(BorrowingDetails.ItemID);
            PrevItemsQuantity.Add(BorrowingDetails.ArduinoItems.ItemNumber);
        }
       

        private void _RetrievItemQuantity(int Amount,int ItemID)

        {
            ClsBiArduinoItems.UpdateItemQuantity(ItemID, Amount);
        }
        private void _DecreadsItemQuantity(int itemID)

        {
         int Amount = 0;
          Amount = BorrowingDetails.ArduinoItems.ItemNumber - (byte) NudItemQuantity.Value;
            ClsBiArduinoItems.UpdateItemQuantity(itemID, Amount);
        }
        private void EditItemQuantity(int Amount, int ItemID)

        {
            ClsBiArduinoItems.UpdateItemQuantity(ItemID, Amount);
        }



        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            

            if (!this.ValidateChildren())
            {

                MessageBox.Show("you have  empty fields", "Erorr", MessageBoxButtons.OK);
            }
            else
            {
                BorrowingDetails = new ClsBIBorrowingDetails(TbBItemName.Text);

                if (BorrowingDetails.ArduinoItems == null)
                {
                    MessageBox.Show("There  is no item with this name", "not found", MessageBoxButtons.OK);
                }
                else
                {


                    if ((byte)NudItemQuantity.Value > BorrowingDetails.ArduinoItems.ItemNumber)
                    {
                        MessageBox.Show($"we have just {BorrowingDetails.ArduinoItems.ItemNumber} instance from this Item :)", "Ecxeeds", MessageBoxButtons.OK);

                    }


                    else

                    {


                        if (IsFirstAdding)
                        {
                            AddBorrowing();
                        }

                       
                        BorrowingDetails.BorrowingID = Borrowing.BorrowingID;
                        BorrowingDetails.ItemStutu = TbBItemStutus.Text;


                        BorrowingDetails.ItemQuantity = (byte)NudItemQuantity.Value;


                        if (BorrowingDetails.Save())
                        {
                            
                            _PrevieusItemquantity();
                            _DecreadsItemQuantity(BorrowingDetails.ArduinoItems.ItemID);

                            ClsBiArduinoItems item = ClsBiArduinoItems.Find(BorrowingDetails.ArduinoItems.ItemID);
                            item.ChangeItemIncludedStutus(item.ItemID);

                            if (MessageBox.Show(@"item Adedd Successfully!!Are you want to add Another item ??", "Confirm", MessageBoxButtons.YesNo)
                                                 
                                == DialogResult.Yes)

                            {
                                BtnFinishe.Enabled = true;
                                BorrDetailsIDIncr++;
                                IsFirstAdding = false;
                                TbBItemName.Clear();
                                TbBItemStutus.Clear();
                                NudItemQuantity.Value = 1;

                            }
                            else
                            {
                                BtnBorrowingsDone.Enabled = true;
                                BtnAddItem.Enabled = false;
                            }


                        }
                        else
                        {
                            MessageBox.Show("Somthing Went wrong !! Item not Added", "Erorr", MessageBoxButtons.OK);

                        }
                    }


                }
            
            }

        }

        //edite section:

        private int _SpecificationItemRows(int BorrwingID)
        {
           return ClsBIBorrowingDetails.GetItemsRowsInBorrowingDetails(BorrowingID);
        }

        private void _GetBorrowingInfo(int BorrwingID)
        {
            BorrwingSearchCntainer.Enabled =false;
            BorrwingSearchCntainer.Hide();

            try
            {
               
                    //Borrower:
                    TBborrwerFName.Text = Borrowing.Borrower.person.FirstName;
                    TBborrwerLName.Text = Borrowing.Borrower.person.LastName;
                    TbBorrowerCardID.Text = Borrowing.Borrower.StudentCardID.ToString();
                    TbBorrowerPhone.Text = Borrowing.Borrower.BorrowerPhone;

                //Item:
                _Rows = _SpecificationItemRows(BorrwingID);
               
               
                
                    if (_Rows > 1)
                    {
                    EditItemsQua.Enabled = true;
                    EditItemsQua.Visible = true;

                        PnlIteInfo.Enabled = false;
                     //   PnlIteInfo.Hide();
                       

                        DgVItemsDetails.Show();
                        DgVItemsDetails.Enabled = true;
                        DataTable table = ClsBIBorrowingDetails.GetItemsBorrowingDetails(BorrwingID);

                        if (table!=null)
                        {
                            DgVItemsDetails.DataSource = table;
                        
                            DgVItemsDetails.ColumnHeadersHeight = 30;
                          

                        }
                    DtBorrwingDate.Value = Borrowing.BorrowingDate;
                    TbBorrowingNotes.Text = Borrowing.Notes;
                    BorrowingDuration.Value = Borrowing.BorrowingDuration;



                     }
                    else
                    {
                    BtnEditITEMqua.Enabled = true;
                    BtnEditITEMqua.Visible = true;

                    _Rows = 1;
                        BorrowingDetails = ClsBIBorrowingDetails.FindByBorrowingID(BorrwingID);
                    BtnEditITEMqua.Enabled = true;
                    BtnEditITEMqua.Visible = true;

                    if (BorrowingDetails != null)
                        {
                            TbBItemName.Text = BorrowingDetails.ArduinoItems.ItemName;
                            TbBItemStutus.Text = BorrowingDetails.ItemStutu;
                            NudItemQuantity.Value = BorrowingDetails.ItemQuantity;
                        NudItemQuantity.Enabled = false;

                        }
                        else
                        {
                            MessageBox.Show("There is no Item suits this BorrowingID");
                            TbBItemName.Text = "";
                            TbBItemStutus.Text = "";
                            NudItemQuantity.Value = 1;

                        }
                        //Borrwing Details:

                        DtBorrwingDate.Value = Borrowing.BorrowingDate;
                        TbBorrowingNotes.Text = Borrowing.Notes;
                        BorrowingDuration.Value = Borrowing.BorrowingDuration;

                    }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnSearh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbBorrowingID.Text))
            {
                MessageBox.Show(" Please Enter BorrowingID ");
            }

            else
            {


                if (!int.TryParse(TbBorrowingID.Text, out BorrowingID))
                {
                    MessageBox.Show($"Borrowing ID should be a number");


                }
                else
                {
                      Borrowing = ClsBiBorrowings.Find(int.Parse(TbBorrowingID.Text));


                    if (Borrowing == null)
                    {
                        MessageBox.Show($"There Is No BorrowingID = {TbBorrowingID.Text}");
                    }
                    else
                    {
                        if (Borrowing.BorrowingStutu == "Retrivered")
                        {
                            MessageBox.Show("you can't edit a Retivered Borrowing !!", "invalid", MessageBoxButtons.OK);
                        }
                        else
                        {


                            BtnAddItem.Enabled = false;
                          
                            _GetBorrowingInfo(BorrowingID);
                            

                           // PnlIteInfo.Enabled = true;
                            BorrowingContainer.Enabled = true;

                        }
                    }
                }
            }
          
        }

        private void BtnSearchClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Edite ()
        {

       

            if (person.Save() && Borrower.Save() && BorrowingDetails.Save() && Borrowing.Save())
            {
                return true;
            }
            else
                return false;
            
               
                

           

           
        }

        private void EditBorrowerBorowing()
        {
           
            Borrowing = ClsBiBorrowings.Find(BorrowingID);
            person = new ClsBIPerson(Borrowing.Borrower.PersonID, TBborrwerFName.Text, TBborrwerLName.Text, ClsGlobal.CurrentUser.UserID);
            //edit borrower
            Borrower = new ClsBiBorrowers(Borrowing.BorrowerID, TbBorrowerCardID.Text, TbBorrowerPhone.Text, ClsGlobal.CurrentUser.UserID, person.PersonID, true);
            //Edit Borrowing
            Borrowing = new ClsBiBorrowings(BorrowingID, Borrower.BorrowerID, "Borrowed", TbBorrowingNotes.Text, DtBorrwingDate.Value
                                           , ClsGlobal.CurrentUser.UserID, (byte)BorrowingDuration.Value, true);
        }

       

        private void BtnBorrowingEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You sure you want to Edit this Borrowing Process ?? ", "Confirm ", MessageBoxButtons.OKCancel) ==
                            DialogResult.OK)
            {
                BorrowingDetails = ClsBIBorrowingDetails.FindByBorrowingID(Borrowing.BorrowingID);
               ClsBiArduinoItems arduinoItem = ClsBiArduinoItems.Find(BorrowingDetails.ItemID);
                EditBorrowerBorowing();

                if (_Rows == 1)

                {
                    _OneRowCase(arduinoItem);
                }
                else
                {
                    _MultiRowsCase();

                }
            }
            
        }
         
        private void _OneRowCase(ClsBiArduinoItems arduinoItem)
        {
            bool scipIt = false;

            if (PnlIteInfo.Enabled)
            {
                int BorrowingQua = ClsBIBorrowingDetails.GetItemqUABorrowingDetails(BorrowingDetails.BorrowingDetailsID);
                if (NudItemQuantity.Value == BorrowingQua)
                {
                    scipIt = true;
                }


                if (arduinoItem.ItemNumber == 0)
                {

                    if (NudItemQuantity.Value > BorrowingQua)
                    {
                        MessageBox.Show($"we have just {BorrowingQua}  instance from Item ID = {BorrowingDetails.ItemID} :) ", "ecxeeds ", MessageBoxButtons.OK);
                        return;
                    }

                }
                if (arduinoItem.ItemNumber > 0)
                {

                    if (NudItemQuantity.Value > arduinoItem.ItemNumber+ BorrowingQua)
                    {
                        MessageBox.Show($"we have just {arduinoItem.ItemNumber + BorrowingQua}  instance from Item ID = {BorrowingDetails.ItemID} :) ", "ecxeeds ", MessageBoxButtons.OK);
                        return;
                    }

                }



            }

            if (!scipIt)
            {
                fIxItemQuantity((int)NudItemQuantity.Value, BorrowingDetails.ItemID);
                BorrowingDetails = new ClsBIBorrowingDetails(BorrowingDetails.BorrowingDetailsID, Borrowing.BorrowingID, BorrowingDetails.ItemID,
                                                     (byte)NudItemQuantity.Value, TbBItemStutus.Text, true);
            }
           


            if (Edite())
            {
                MessageBox.Show($" Borrowing Process Edited Successfully ", "Done ", MessageBoxButtons.OK);
                this.Close();
            }

        }
        private void _MultiRowsCase()
        {
            for (int i = 1; i <= _Rows; i++)
            {
                int BorrowingDetailiD = 0; int ItemID = 0; string ItemName = ""; byte ItemQuantit = 0;
                string ItemStutus = ""; int BorrowingID = 0;
                bool Scipit=false;

                if (DgVItemsDetails.DataSource != null)
                {

                    BorrowingDetailiD = (int)DgVItemsDetails.Rows[i - 1].Cells[0].Value;

                    ItemID = (int)DgVItemsDetails.Rows[i - 1].Cells[1].Value;
                    ItemName = DgVItemsDetails.Rows[i - 1].Cells[2].Value.ToString();
                    ItemQuantit = (byte)DgVItemsDetails.Rows[i - 1].Cells[3].Value;
                    ItemStutus = DgVItemsDetails.Rows[i - 1].Cells[4].Value.ToString();
                    BorrowingID = (int)DgVItemsDetails.Rows[i - 1].Cells[5].Value;

                    int BorrowingQua = ClsBIBorrowingDetails.GetItemqUABorrowingDetails(BorrowingDetailiD);
                 ClsBiArduinoItems   arduinoItem = ClsBiArduinoItems.Find(ItemID);

                    if (DgVItemsDetails.Enabled)
                    {

                        if (ItemQuantit == BorrowingQua )
                        {
                             Scipit = true;   
                        }

                        if (arduinoItem.ItemNumber == 0)
                        {
                            if (ItemQuantit > BorrowingQua)
                            {

                                MessageBox.Show($"we have just {BorrowingQua}  instance from Item ID = {ItemID} :) ", "ecxeeds ", MessageBoxButtons.OK);
                                return;
                            }
                        }
                        if (arduinoItem.ItemNumber > 0)

                        {
                            if (ItemQuantit > arduinoItem.ItemNumber + BorrowingQua)
                            {

                                MessageBox.Show($"we have just {arduinoItem.ItemNumber + BorrowingQua}  instance from Item ID = {ItemID} :) ", "ecxeeds ", MessageBoxButtons.OK);
                                return;
                            }

                        }

                    }

                    if (!Scipit)
                    {


                        BorrowingDetails = new ClsBIBorrowingDetails(BorrowingDetailiD, BorrowingID, ItemID, ItemQuantit, ItemStutus, true);

                        fIxItemQuantity(ItemQuantit, ItemID, true);


                        BorrowingDetails.Save();
                    }

                    if (Edite())
                    {
                        if (i == _Rows)
                        {
                            MessageBox.Show($"Edit  Borrowing Process Completed Successfully  ", "Done ", MessageBoxButtons.OK);
                            this.Close();
                        }

                    }
                }

            }
        }

        private void BtnFinishe_Click(object sender, EventArgs e)
        {
            BtnBorrowingsDone.Enabled = true;
            BtnAddItem.Enabled = false;
        }

        private int GetItemNumber(int itemID)
        {
            return ClsBIBorrowingDetails.GetItemqUABorrowingDetails(BorrowingDetails.BorrowingDetailsID);     
        }

        private void fIxItemQuantity(int EditQuantity,int ItemID,bool multi=false)
        {
            int CurentQuantity = 0;
           
            int ProcessQuantity = 0;

     ClsBiArduinoItems ArduinoItems = ClsBiArduinoItems.Find(ItemID);


            CurentQuantity = ArduinoItems.ItemNumber;
          

            ProcessQuantity = BorrowingDetails.ItemQuantity;
            if (multi)
            {

                ProcessQuantity = GetItemNumber(BorrowingDetails.BorrowingDetailsID); ;
            }

            if (ProcessQuantity> EditQuantity)

            {
                CurentQuantity = CurentQuantity + (ProcessQuantity - EditQuantity);
            }
            if (ProcessQuantity < EditQuantity&& CurentQuantity!=0)

            {
                CurentQuantity = CurentQuantity - (EditQuantity - ProcessQuantity);
            }
            EditItemQuantity(CurentQuantity, BorrowingDetails.ItemID);

        }

       

        private void BtnEditITEMqua_Click(object sender, EventArgs e)
        {
            PnlIteInfo.Enabled= true;
            NudItemQuantity.Enabled = true;
        }

        private void EditItemsQua_Click(object sender, EventArgs e)
        {
            PnlIteInfo.Enabled = true;
            DgVItemsDetails.Enabled = true;
        }

      
    }
}
