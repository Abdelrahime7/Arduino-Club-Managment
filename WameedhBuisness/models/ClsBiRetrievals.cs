using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WameedhDataAccess;

namespace WammeedBuisness
{
    public class ClsBiRetrievals
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int RetrievalID { get; set; }
        public int BorrowingID { get; set; }
        public string Notes { get; set; }
        
        public DateTime RetrivalDate { get; set; }
        public int UserID { get; set; }

        public ClsBiRetrievals()
        {
            this.RetrievalID = -1;
            this.BorrowingID = -1;
            this.Notes = "";
            this.RetrivalDate = new DateTime();
     
            this.UserID = -1;
            Mode = enMode.AddNew;

        }

        public ClsBiRetrievals(int RetrievalID, int BorrowingID, string Notes, DateTime RetrivalDate, int UserID)
        {
            this.RetrievalID = RetrievalID;
            this.BorrowingID = BorrowingID;
            this.Notes = Notes;
            this.RetrivalDate = RetrivalDate;
         
            this.UserID = UserID;
            Mode = enMode.Update;
        }
        private bool _AddNewRetrieval()
        {
            this.RetrievalID = ClsRetrievalsData.AddNewRetrievals(this.BorrowingID,this.Notes,this.RetrivalDate,this.UserID);
            return (this.RetrievalID != -1);
         }
        private bool _UpdateRetrieval()
        {

            return ClsRetrievalsData.UpdateRetrievals(this.RetrievalID, this.BorrowingID, this.Notes, this.RetrivalDate,  this.UserID);
        }
        public static ClsBiRetrievals Find(int RetrievalID)
        {

            int BorrowingID = -1;   string Notes=""; DateTime RetrivalDate=new DateTime(); int UserID = -1;
    
            if (ClsRetrievalsData.GetRetrievalsByID((int)RetrievalID, ref  BorrowingID, ref  Notes, ref  RetrivalDate,  ref UserID))

                return new ClsBiRetrievals(RetrievalID, BorrowingID, Notes, RetrivalDate, UserID);
            else
                return null;

        }
        public static DataTable GetAllRetrievals()
        {
            return ClsRetrievalsData.GetAllRetrievals();

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRetrieval())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateRetrieval();

            }

            return false;
        }

    }
}