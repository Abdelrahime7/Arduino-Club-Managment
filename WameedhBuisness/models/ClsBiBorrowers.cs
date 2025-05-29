using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WameedhDataAccess;

namespace WammeedBuisness
{
    public class ClsBiBorrowers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public  int BorrowerID { get; set; }
        public string StudentCardID { get; set; }
        public string BorrowerPhone { get; set; }
        public int PersonID { get; set; }
        public int UserID { get; set; }
       public ClsBIPerson person;

        public ClsBiBorrowers(string Fname, string Lname,int UserID)
        {
            this.BorrowerID = -1;
            this.StudentCardID = "";
            this.BorrowerPhone = "";
            this.UserID = -1;
            this.PersonID = -1;
            Mode = enMode.AddNew;

            person = new ClsBIPerson();
            person.FirstName = Fname;
            person.LastName = Lname;
            person.UserID = UserID;

            if (person.Save())
            {
                this.PersonID = person.PersonID;
            }
            
        }

        public ClsBiBorrowers(int BorrowerID,   string StudentCardID, string BorrowerPhone, int UserID,int PersonID,bool Edite=false)
        {
            this.BorrowerID = BorrowerID;
            this.StudentCardID = StudentCardID;
            this.BorrowerPhone = BorrowerPhone;
            this.UserID = UserID;
            this.PersonID = PersonID;
            if (!Edite)
            {
                this.person = ClsBIPerson.Find(PersonID);
            }
            Mode = enMode.Update;

        }
        private bool _AddNewBorrower()
        {
            this.BorrowerID = ClsBorrowersData.AddNewBorrower( this.BorrowerPhone, this.StudentCardID, this.UserID,this.PersonID);
              
                return (this.BorrowerID != -1);
         }
        private bool _UpdateBorrower()
        {

            return ClsBorrowersData.UpdateBorrower(this.BorrowerID, this.BorrowerPhone,this.StudentCardID, this.UserID, this.PersonID);
        }
        public static ClsBiBorrowers Find(int BorrowerID)
        {

int PersonID = -1; string BorrowerPhone = "";string  StudentCardID=""; int UserID = -1;

            if (ClsBorrowersData.GetBorrowersByID((int)BorrowerID,  ref BorrowerPhone, ref StudentCardID, ref UserID,ref PersonID))

                return new ClsBiBorrowers(BorrowerID,  StudentCardID , BorrowerPhone, UserID,PersonID);
            else
                return null;

        }
        public static ClsBiBorrowers FindByCardID(string StudentCardID)
        {

            int PersonID = -1; string BorrowerPhone = ""; int BorrowerID = -1; int UserID = -1;

            if (ClsBorrowersData.GetBorrowersByStudentCardID(StudentCardID, ref BorrowerPhone, ref BorrowerID, ref UserID, ref PersonID))

                return new ClsBiBorrowers(BorrowerID, StudentCardID, BorrowerPhone, UserID, PersonID);
            else
                return null;

        }

        public static DataTable GetAllBorrowers()
        {
            return ClsBorrowersData.GetAllBorrowers();

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBorrower())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        ClsBIPerson.Delete(PersonID);
                        return false;
                        
                    }

                case enMode.Update:

                    return _UpdateBorrower();

            }

            return false;
        }

        public static void Delete(int BorrowerId)
        {
            ClsBorrowersData.DeleteBorrowers(BorrowerId);
        }
    }

}
