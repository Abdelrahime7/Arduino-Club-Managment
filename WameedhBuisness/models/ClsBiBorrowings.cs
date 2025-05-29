using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WameedhDataAccess;

namespace WammeedBuisness
{
    public class ClsBiBorrowings
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int BorrowingID { get; set; }
        public int BorrowerID { get; set; }
        public string Notes { get; set; }
        public int UserID { get; set; }
        public DateTime BorrowingDate { get; set; }
        public string BorrowingStutu { get; set; }
        public byte BorrowingDuration { get; set; }
        public ClsBiBorrowers Borrower;



        public ClsBiBorrowings()
        {
            this.BorrowingID = -1;
            this.BorrowerID = -1;
            this.BorrowingStutu = "";
            this.Notes = "";
            this.BorrowingDate =  new DateTime();
            this.UserID =-1 ;
            this.BorrowingDuration = 1;
            Mode = enMode.AddNew;
        }

        public ClsBiBorrowings(int BorrowingID, int BorrowerID, string BorrowingStutu, string Notes, DateTime BorrowingDate, int UserID ,byte BorrowingDuration,bool Edite=false)
        {
            this.BorrowingID = BorrowingID;
            this.BorrowerID = BorrowerID;
           
            this.BorrowingStutu = BorrowingStutu;
            this.Notes = Notes;
            this.BorrowingDate = BorrowingDate;
            this.UserID = UserID;
         this.BorrowingDuration = BorrowingDuration;

            if (!Edite)
            {
                Borrower = ClsBiBorrowers.Find(BorrowerID);
            }
            Mode = enMode.Update;

        }

        public static void ChangeBorrowingStutus(int BorrowingID)
        {
            ClsBorrowingsData.ChangeBorrowinigStutuS(BorrowingID);
        }
        private bool _AddNewBorrowing()
        {

            this.BorrowingID = ClsBorrowingsData.AddNewBorrowing(this.BorrowerID, this.BorrowingStutu, this.Notes, this.BorrowingDate, this.BorrowingDuration, this.UserID);
            return (this.BorrowingID != -1);
        }
        private bool _UpdateBorrowing()
        {

            return ClsBorrowingsData.UpdateBorrowings(this.BorrowingID, this.BorrowerID, this.BorrowingStutu, this.Notes, this.BorrowingDate, this.BorrowingDuration, this.UserID);
        }
        public static ClsBiBorrowings Find(int BorrowingID)
        {

            int BorrowerID = -1; DateTime BorrowingDate=new DateTime(); 
            Byte BorrowingDuration = 0; string BorrowingStutu = ""; string Notes = "";int UserID = -1;

            if (ClsBorrowingsData.GetBorrowingsByID(BorrowingID, ref BorrowerID, ref BorrowingStutu, ref Notes, ref BorrowingDate, ref BorrowingDuration, ref UserID))

                return new ClsBiBorrowings(BorrowingID, BorrowerID, BorrowingStutu, Notes, BorrowingDate, UserID,BorrowingDuration);
            else
                return null;

        }
        public static DataTable GetAllBorrowings()
        {
            return ClsBorrowingsData.GetAllBorrowings();

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBorrowing())
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
        public static void Delete(int BorrowingID) => ClsBorrowingsData.DeleteBorrowings(BorrowingID);

        public static bool UpdatToSaveFinalVersin(int BorrowingID,string Notes,byte BorrowingDur)
        {
            return ClsBorrowingsData.UpdateBorrowingToSave(BorrowingID, Notes, BorrowingDur);
        }
    }

}
