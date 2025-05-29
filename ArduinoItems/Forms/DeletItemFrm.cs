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
    
    public partial class DeletItemFrm : Form
    {
        ClsBiArduinoItems ArduinoItems;
        public DeletItemFrm()
        {
            InitializeComponent();
        }
        private void _Refresh()
        {
            this.Width = AccuileFrm.MainContainer.Width;
            BtnDelete.Enabled = false;
           
            TbItemId.Text = "";
            LbItemName.Text = "????";
            LbItemREF.Text = "????";
        }

         

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure You want to delete this Item :{LbItemName.Text} ", "Confirm", MessageBoxButtons.OKCancel)
                 == DialogResult.OK)
            {
                ArduinoItems =ClsBiArduinoItems.Find( ClsBiArduinoItems.FindIDByName(LbItemName.Text));
               if(ArduinoItems.IsIncluded)
                {
                    MessageBox.Show($"the Item with ID:{TbItemId.Text} is included in borrowing Process !! ", "Pervent", MessageBoxButtons.OK);
                    return;
                }
                if (ClsBiArduinoItems.DeletItem(int.Parse(TbItemId.Text)))
                {
                    
                    MessageBox.Show($"the Item with ID:{TbItemId.Text} was Deleted successfuly !! ", "Done!!", MessageBoxButtons.OK);
                    _Refresh();
                }
            }
        }


        private void DeletItemFrm_Load(object sender, EventArgs e)
        {

            _Refresh();
        }

        private void BtnSearh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbItemId.Text))
            {
                int ItemID = 0;
                if (!int.TryParse(TbItemId.Text, out ItemID))
                {
                    MessageBox.Show($" ItemID wrong Format ", "Wrong ID", MessageBoxButtons.OK);
                }
                else
                {
                    if (ClsBiArduinoItems.Find(int.Parse(TbItemId.Text)) != null)
                    {
                        BtnDelete.Enabled = true;
                        SearchContainer.Enabled = false;

                        ArduinoItems = ClsBiArduinoItems.Find(int.Parse(TbItemId.Text));


                        LBItemID.Text = ArduinoItems.ItemID.ToString();
                        LbItemName.Text = ArduinoItems.ItemName;
                        LbItemREF.Text = ArduinoItems.ItemReference.ToString();
                    }
                    else
                    {
                        MessageBox.Show($"no Item with this ID:{TbItemId.Text} ", "Wrong ID", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                
                    MessageBox.Show("Item ID Missed !!", "Missed Information", MessageBoxButtons.OK);
                _Refresh();
            }
        }

       
    }
}
