using System;
using System.Data;
using System.Runtime.CompilerServices;
using WameedhDataAccess;

namespace WammeedBuisness
{
    public class ClsBiArduinoItems
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemReference { get; set; }

        public DateTime AddingDate { get; set; }
        public int ItemNumber { get; set; }
        public int UserID { get; set; }

         public bool IsIncluded { get; set; }
        public ClsBiArduinoItems()
        {
            this.ItemID =-1;
            this.ItemReference = -1;
            this.ItemName ="" ;
            this.ItemNumber =-1 ;
            this.UserID = -1;
            this.AddingDate = new DateTime();
        
             Mode = enMode.AddNew;

        }

        public static  int GetItemQuantity(int IteMID)
        {
           return  ClsArduinoItemsData.GetItemQuntity(IteMID);
        } 
        public static void UpdateItemQuantity(int ItemID,int Amount)
        {
            ClsArduinoItemsData.UpdateItemQuantity(ItemID, Amount);
        }
        public ClsBiArduinoItems(int ItemID, string ItemName, int ItemNumber, int UserID,DateTime AddingDate,bool IsIncluded)
        {
            this.ItemID = ItemID;
           // this.ItemReference = ItemReference;
            this.ItemName = ItemName;
            this.ItemNumber = ItemNumber;
            this.UserID = UserID;
            this.AddingDate = AddingDate;
            this.IsIncluded = IsIncluded;
            Mode = enMode.Update;
        }
        private bool _AddNewArduinoItem()
        {
            this.ItemID = ClsArduinoItemsData.AddNewArduinoItem(this.ItemName, this.ItemNumber,this.UserID,this.AddingDate);
            return (this.ItemID != -1);
        }
        private bool _UpdateArduinoItem()
        {

            return ClsArduinoItemsData.UpdateArduinoItem(this.ItemID,this.ItemName, this.ItemNumber,this.UserID,this.AddingDate);
        }

        public bool ChangeItemIncludedStutus(int ItemID)
        {
            IsIncluded= ClsArduinoItemsData.changeIndlucdingItemsStutus(ItemID);
            return IsIncluded;
        }

        public static bool DeletItem(int ItemID)
        {
            return ClsArduinoItemsData.DeleteArduinoItems(ItemID);
        }
        public static ClsBiArduinoItems Find(int ItemID)
        {

             string ItemName=""; int ItemNumber=0; int UserID=0; bool IsIncluded =false;
            DateTime AddingDate = new DateTime();

            if (ClsArduinoItemsData.GetArduinoItemsByID((int)ItemID, ref ItemName, ref ItemNumber, ref  UserID,ref AddingDate,ref IsIncluded))

                return new ClsBiArduinoItems(ItemID, ItemName, ItemNumber, UserID, AddingDate, IsIncluded);
            else
                return null;

        }
        public static int FindIDByName(string ItemName)
        {

            return (ClsArduinoItemsData.GetArduinoItemiDByName(ItemName));

        }
        public static DataTable GetAllArduinoItems()
        {
            return ClsArduinoItemsData.GetAllArduinoItems();

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewArduinoItem())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateArduinoItem();

            }

            return false;
        }
    }

}

