using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WameedhDataAccess;

namespace WammeedBuisness
{
    public class ClsBiUsers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
       public string Password { get; set; }
        public bool Stutu { get; set; }
        public int UserID { get; set; }
        public string UserNAME { get; set; }
        public int PersonID { get; set; }
        public ClsBIPerson person;
        public ClsBiUsers(string Fname, string Lname, int UserID)

        {
            this.UserID =-1 ;
            this.UserNAME ="" ;
            this.Password = "";
            this.Stutu =false;
            this.PersonID = -1;

            person = new ClsBIPerson();
            person.FirstName = Fname;
            person.LastName = Lname;
            person.UserID = UserID;
            if (person.Save())
            {
                this.PersonID = person.PersonID;

               
            }

            Mode = enMode.AddNew;

        }

        public ClsBiUsers(int UserID, string UserNAME ,string Password, bool Stutu,int PersonID,bool Edite=false)
        {
            this.UserID = UserID;
            this.UserNAME = UserNAME;
            this.Password = Password;
            this.Stutu = Stutu;
            this.PersonID = PersonID;
            if (!Edite)
            {
                person = ClsBIPerson.Find(PersonID);
            }
            Mode = enMode.Update;


        }
        private bool _AddNewUser()
        {
            this.UserID = ClsUsersData.AddNewUsers( this.UserNAME ,this.Password, this.Stutu,this.PersonID);
                 return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {

            return ClsUsersData.UpdateUsers(this.UserID, this.UserNAME, this.Password, this.Stutu);
        }
        public static ClsBiUsers Find(int UserID)
        {

            string Password = ""; bool Stutu = false;   string UserNAME = "";int PersonID = -1;

            if (ClsUsersData.GetUsersByID((int)UserID, ref  UserNAME, ref Password, ref  Stutu,ref PersonID))

                return new ClsBiUsers(UserID, UserNAME, Password, Stutu, PersonID);
            else
                return null;

        }

        public static ClsBiUsers FindUserByUserNameAndPassword(string UserName,string Password)
        {

            int UserID = -1; bool Stutu = false; int PersonID=-1 ;

            if (ClsUsersData.GetUsersByUserNameAndPasswrd(UserName, Password, ref UserID, ref Stutu, ref PersonID))

                return new ClsBiUsers(UserID, UserName, Password, Stutu, PersonID);
            else
                return null;

        }

        public static DataTable GetAllUsers()
        {
            return ClsUsersData.GetAllUsers();

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }

            return false;
        }

        public static bool ISUserExist(string UserName,string Password)
        {
            return ClsUsersData.IsUsersExist(UserName, Password);
        }
        public static bool Delete(int UserID)
        {
            return ClsUsersData.DeleteUsers(UserID);
        }
    }

}
