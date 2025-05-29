using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WameedhDataAccess;

namespace WammeedBuisness
{
    public class ClsBIPerson
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserID { get; set; }


        public ClsBIPerson()
        {
            this.PersonID = 0;
            this.FirstName = "";
            this.LastName = "";
            this.UserID = -1;

            Mode = enMode.AddNew;
        }

        public ClsBIPerson(int PersonID, string FirstName, string LastName, int UserID)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserID = UserID;
            Mode = enMode.Update;

        }



        private bool _AddNewPerson()
        {

            this.PersonID = ClSPersonDatta.AddNewPerson(this.FirstName, this.LastName, this.UserID);

            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {

            return ClSPersonDatta.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.UserID);
        }
        public static ClsBIPerson Find(int PersonID)
        {

            string FirstName = ""; string LastName = "";  int UserID = -1;

            if (ClSPersonDatta.GetPersonByID((int)PersonID, ref FirstName, ref LastName, ref UserID))

                return new ClsBIPerson(PersonID, FirstName, LastName, UserID);
            else
                return null;

        }
        //public static DataTable GetAllBorrowers()
        //{
        //    return ClsBorrowersData.GetAllBorrowers();

        //}
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }

        public static void Delete(int personID)
        {
            ClSPersonDatta.Delete(personID);
        }
        public static DataTable GetAllPeople()
        {
          return  ClSPersonDatta.GetAllPerson();
        }
    }
}
