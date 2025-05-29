using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WameedhDataAccess;
using WammeedBuisness;

namespace WammeedBuisness2
{
    public class ClsBIBorrowingDetails
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int BorrowingDetailsID { get; set; }
        public int BorrowingID { get; set; }
        public int ItemID { get; set; }
        public Byte ItemQuantity { get; set; }
        public string ItemStutu { get; set; }
        public ClsBiArduinoItems ArduinoItems;


        public ClsBIBorrowingDetails(string ItemName)
        {
            this.ItemID = ClsBiArduinoItems.FindIDByName(ItemName);
            ArduinoItems = ClsBiArduinoItems.Find(ItemID);
            this.BorrowingDetailsID = -1;
            this.BorrowingID = -1;
            this.ItemQuantity = 1;
            this.ItemStutu = "";


            Mode = enMode.AddNew;
        }

        public ClsBIBorrowingDetails(int BorrowingDetailsID, int BorrowingID, int ItemID, Byte ItemQuantity, string ItemStutu,bool Edite=false)
        {
            this.BorrowingDetailsID = BorrowingDetailsID;
            this.BorrowingID = BorrowingID;
            this.ItemID = ItemID;
            this.ItemQuantity = ItemQuantity;
            this.ItemStutu = ItemStutu;
            if (!Edite)
            {
                ArduinoItems = ClsBiArduinoItems.Find(ItemID);
            }
           
            Mode = enMode.Update;

        }

        public static int GetItemqUABorrowingDetails(int BorrwingDetailID)
        {
            return ClsBorrowingDetailsDatta.GetAllItemqUANTBorrowingDetails(BorrwingDetailID);
        }

        public static DataTable GetItemsBorrowingDetails(int BorrwinID)
        {
            return ClsBorrowingDetailsDatta.GetAllItemsBorrowingDetailsByBorrowingID(BorrwinID);
        }
        public static int GetItemsRowsInBorrowingDetails(int BorrowingID)
        {

            return ClsBorrowingDetailsDatta.GetItemRowsInBorrowingDetail(BorrowingID);
        
        }
        private bool _AddNewBorrowingDetails()
        {

            this.BorrowingDetailsID = ClsBorrowingDetailsDatta.AddNewBorrowingDetails(this.BorrowingID, this.ItemID, this.ItemQuantity, this.ItemStutu);
            return (this.BorrowingDetailsID != -1);
        }
        private bool _UpdateBorrowing()
        {

            return ClsBorrowingDetailsDatta.UpdateBorrowings(this.BorrowingDetailsID, this.BorrowingID, this.ItemID, this.ItemQuantity, this.ItemStutu);
        }
        public static ClsBIBorrowingDetails Find(int BorrowingDetailsID)
        {

            int ItemID = -1; int BorrowingID = -1;
            Byte itemQuantity = 0; string ItemStutu = "";

            if (ClsBorrowingDetailsDatta.GetBorrowingDetailsByID(BorrowingDetailsID, ref BorrowingID, ref ItemID, ref itemQuantity, ref ItemStutu))

                return new ClsBIBorrowingDetails(BorrowingDetailsID,BorrowingID, ItemID, itemQuantity, ItemStutu);
            else
                return null;

        }
        public static ClsBIBorrowingDetails FindByBorrowingID(int BorrowingID)
        {

            int ItemID = -1; int BorrowingDetailsID = -1;
            Byte itemQuantity = 0; string ItemStutu = "";

            if (ClsBorrowingDetailsDatta.GetBorrowingDetailsByBorrowingID(BorrowingID, ref BorrowingDetailsID, ref ItemID, ref itemQuantity, ref ItemStutu))

                return new ClsBIBorrowingDetails(BorrowingDetailsID,BorrowingID, ItemID, itemQuantity, ItemStutu);
            else
                return null;

        }

      
        public static DataTable GetAllBorrowingsDetByBBorrowingiD(int BorrowingID)
        {
            return ClsBorrowingDetailsDatta.GetAllBorrowingDetailsByBorrowingID(BorrowingID);

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBorrowingDetails())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateBorrowing();

            }

            return false;
        }

        public static void Delete(int BorrowingDetailsId)
        {
            ClsBorrowingDetailsDatta.DeleteBorrowings(BorrowingDetailsId);
        }
    }

}