using System;

using System.Windows.Forms;
using WAMEEDHLAST;
using WammeedBuisness;
namespace Wammedh1
{
    public partial class AddEditForm : Form
    {
        ClsBiArduinoItems ArduinoItems;
        public enum Enmode { EnAdd=1,EnEdit=2};
        public Enmode Mode;
        public AddEditForm(byte _Mode)
        {
             Mode = (Enmode)_Mode;
            InitializeComponent();
        }

        private void clear()
        {
            TbItemName.Text = "";
            NuPArduinoQua.Value = 1;
        
            TbItemRef.Text = "";
        }

        private void AddEditItem ()
        {
            switch(Mode)
            {
                case Enmode.EnAdd:
                    ArduinoItems = new ClsBiArduinoItems();

                  //  ArduinoItems.ItemReference = int.Parse(TbItemRef.Text);
                    ArduinoItems.ItemName = TbItemName.Text;
                    ArduinoItems.ItemNumber =(int) NuPArduinoQua.Value;
                    ArduinoItems.UserID = ClsGlobal.CurrentUser.UserID;
                    ArduinoItems.AddingDate = ItemDatePiker.Value;
                   if( ArduinoItems.Save())
                    {
                        clear();
                        MessageBox.Show($"Item Added Successfuly with ID :{ArduinoItems.ItemID}", "Done!", MessageBoxButtons.OK); ;
                    }
                    else
                    {
                        MessageBox.Show($"Something Went Wrong   ","Erorr"  , MessageBoxButtons.OK,MessageBoxIcon.Error); ;

                    }

                    break;
                case Enmode.EnEdit:
                    ArduinoItems.ItemReference = int.Parse(TbItemRef.Text);

                    ArduinoItems.ItemName = TbItemName.Text;
                   ArduinoItems.ItemNumber =(int) NuPArduinoQua.Value;
                   ArduinoItems.AddingDate = ItemDatePiker.Value;

                    if (MessageBox.Show($"Are You want to Edite this Item !! ", "Confirm", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)

                    {

                        if (ArduinoItems.Save())
                        {

                            MessageBox.Show($"Item Edited Successfuly !! ", "Done!", MessageBoxButtons.OK);
                            _Refresh();
                        }
                        else
                        {
                            MessageBox.Show($"Something Went Wrong   ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

                        }
                    }
                   
                    
                    break;
                   
            }
          
        }

        private void _Refresh()
        {

            this.Width = AccuileFrm.MainContainer.Width;
            switch (Mode)
            {
                case Enmode.EnAdd:
                    ItemDatePiker.MinDate = DateTime.Now;
                    ItemDatePiker.Enabled = false;
                    LbTIte.Text = "Add";
                    BtnEditItem.Hide();
                    BtnSearh.Enabled = false;
                    LbitmeID.Enabled = false;
                    TbItemId.Enabled = false;
                    LbIteID.Hide();
                    label6.Hide();

                    break;
                case Enmode.EnEdit:
                    LbIteID.Show();
                    label6.Show();

                    AddContainer.Enabled = false;
                    ItemDatePiker.Enabled = false;
                    LbTIte.Text = "Edit";
                    BtnAddItem.Hide();
                    break;
            }
        }
      
        private void MainForm_Load(object sender, EventArgs e)

        {

            _Refresh();

        }

     

       

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddItem_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbItemName.Text))
            {
                AddEditItem();
            }
            else
            {
                MessageBox.Show("Item Name Missed !!","Missed Information",MessageBoxButtons.OK);
            }
           

        }

        private void BtnEditItem_Click_1(object sender, EventArgs e)
        {
            AddEditItem();

        }

        private void BtnSearh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbItemId.Text))
            {
                if (int.TryParse(TbItemId.Text,out int id))
                {


                    if (ClsBiArduinoItems.Find(int.Parse(TbItemId.Text)) != null)
                    {
                        searchContainer.Enabled = false;
                        AddContainer.Enabled = true;
                        LbIteID.Text = TbItemId.Text;
                        ArduinoItems = ClsBiArduinoItems.Find(int.Parse(TbItemId.Text));
                        TbItemId.Text = ArduinoItems.ItemID.ToString();
                        TbItemName.Text = ArduinoItems.ItemName;
                        NuPArduinoQua.Minimum = 0;
                        NuPArduinoQua.Value = ArduinoItems.ItemNumber;
                        TbItemRef.Text = ArduinoItems.ItemReference.ToString();
                        ItemDatePiker.Value = ArduinoItems.AddingDate;
                    }
                    else
                    {
                        MessageBox.Show($"no Item withe  ID = {TbItemId.Text} ", "Wrong ID", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show($" Item ID Should Be number  ", "failed", MessageBoxButtons.OK);
                }


            }
            else
            {

                MessageBox.Show("Item ID Missed !!", "Missed Information", MessageBoxButtons.OK);
                _Refresh();
            }

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ClsBIPerson person = new ClsBIPerson(4, "nourallll", "ounissi", 1);
            person.Save();
        }
    }
}
