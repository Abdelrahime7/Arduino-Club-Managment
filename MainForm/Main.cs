using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Wammedh1
{


    public partial class AccuileFrm : Form
    {
        Form form;
        LoginFRm _frmLogin;
        private bool ArduinoMenuColapsed;
        private bool BorrowingsMenuColapsed;
        private bool RetrivalsMenuColapsed;
        private bool BorrowersMenuColapsed;
        private bool UsersMenuColapsed;


        public AccuileFrm(LoginFRm loginFRm)
        {

            SetFormSizeDnamyc();

            InitializeComponent();
            _frmLogin = loginFRm;
          
        }

        public void SetFormSizeDnamyc()
        {
            System.Drawing.Rectangle rectangle = Screen.PrimaryScreen.WorkingArea;

            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * rectangle.Width), Convert.ToInt32(0.5 * rectangle.Height));
           // this.Location = new System.Drawing.Point(50,50);
        }
        private void _ResizeMenuButon()
        {
            if (ArduinoMenuColapsed)
            {
                ArdMenuContainer.Height = MinimumSize.Height;

            }
            if (BorrowingsMenuColapsed)
            {
             BorwingsMenueCnt.Height = MinimumSize.Height;

            }

            if (RetrivalsMenuColapsed)
            {
                RetrivalsMenuCtn.Height = MinimumSize.Height;
            }

            if (UsersMenuColapsed)
            {
                UsersMenuCtn.Height = MinimumSize.Height;

            }

            if (BorrowersMenuColapsed)
            {
                BorrowersMenuCtn.Height = MinimumSize.Height;
            }
           

        }

        private void SideBarMenuDinamyc(ref bool SidBarMenueColaps, System.Windows.Forms.Panel SidebarContainer, Timer timer)
        {

            if (SidBarMenueColaps)
            {
                if (SidebarContainer == ArdMenuContainer)
                {
                    RetrivalsMenuCtn.Show();
                    BorwingsMenueCnt.Show();
                    BorrowersMenuCtn.Show();
                    UsersMenuCtn.Show();

                }
                if (SidebarContainer == RetrivalsMenuCtn)
                {
                    BorwingsMenueCnt.Show();
                    BorrowersMenuCtn.Show();
                    UsersMenuCtn.Show();

                }
                if (SidebarContainer == BorwingsMenueCnt)
                {

                    BorrowersMenuCtn.Show();
                    UsersMenuCtn.Show();

                }
                if (SidebarContainer == BorrowersMenuCtn)
                {

                    UsersMenuCtn.Show();

                }


                SidBarMenueColaps = false;

                SidebarContainer.Height += 10;

                SidebarContainer.Height = SidebarContainer.MinimumSize.Height;
                timer.Stop();
            }
            else
            {
                if (SidebarContainer == ArdMenuContainer )
                {
                    RetrivalsMenuCtn.Hide();
                    BorwingsMenueCnt.Hide();
                    BorrowersMenuCtn.Hide();
                    UsersMenuCtn.Hide();

                }
                if (SidebarContainer == RetrivalsMenuCtn)
                {
                    BorwingsMenueCnt.Hide();
                    BorrowersMenuCtn.Hide();
                    UsersMenuCtn.Hide();

                }
                if (SidebarContainer == BorwingsMenueCnt)
                {
                  
                    BorrowersMenuCtn.Hide();
                    UsersMenuCtn.Hide();

                }
                if (SidebarContainer == BorrowersMenuCtn)
                {

                    UsersMenuCtn.Hide();

                }

                SidebarContainer.Height -= 10;

                SidebarContainer.Height = SidebarContainer.MaximumSize.Height;
                SidBarMenueColaps = true;
                timer.Stop();
            }
        }
        //timer:

        private void ArduinoTimer_Tick(object sender, EventArgs e)
        {


            SideBarMenuDinamyc(ref ArduinoMenuColapsed, ArdMenuContainer, ArduinoTimer);



        }
        private void BorrwingsTimer_Tick(object sender, EventArgs e)
        {
            SideBarMenuDinamyc(ref BorrowingsMenuColapsed, BorwingsMenueCnt, BorrwingsTimer);
        }
        private void RetrievalsTimer_Tick(object sender, EventArgs e)
        {


            SideBarMenuDinamyc(ref RetrivalsMenuColapsed, RetrivalsMenuCtn, RetrievalsTimer);

        }
        private void BorrowersTimer_Tick(object sender, EventArgs e)
        {
            SideBarMenuDinamyc(ref BorrowersMenuColapsed, BorrowersMenuCtn, BorrowersTimer);
        }
        private void UserTimer_Tick(object sender, EventArgs e)
        {
            SideBarMenuDinamyc(ref UsersMenuColapsed, UsersMenuCtn, UserTimer);
        }

        
        //btn :



      
        private void BtnBorrowingsMenu_Click(object sender, EventArgs e)
        {
            BorrwingsTimer.Start();
            _ResizeMenuButon();

        }
        private void BtnRetrievalsMenu_Click(object sender, EventArgs e)

        {
            RetrievalsTimer.Start();
            _ResizeMenuButon();

        }
        private void BtnUsersMneu_Click(object sender, EventArgs e)
        {
            UserTimer.Start();
            _ResizeMenuButon();

        }
        private void BtnBorrowersMenu_Click(object sender, EventArgs e)
        {
            BorrowersTimer.Start();
            _ResizeMenuButon();

        }


        private void BtNArduinoMenu_Click_1(object sender, EventArgs e)
        {
            ArduinoTimer.Start();
            _ResizeMenuButon();
        }

       

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmLogin.Show();
        }

        
        private void Container1(Form fRM)
        
        {
            if (MainContainer.Controls.Count > 0) MainContainer.Controls.Clear();
            Form fm = fRM as Form;
            form = fRM as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;

            MainContainer.Controls.Add(fm);
            fm.Show();
           
        }
        //ArduinoItem:


        private void BtnDeletArd_Click(object sender, EventArgs e)
        {
            Container1(new DeletItemFrm());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            Container1(new AddEditForm(1));
        }

        private void BtnUpdatArd_Click_1(object sender, EventArgs e)
        {
            Container1(new AddEditForm(2));
        }
      

        private void BtnAllArds_Click(object sender, EventArgs e)
        {
            Container1(new ShowAllItemsFrm());
        }

      
        //Retrievals
        private void BtnRetProcess_Click(object sender, EventArgs e)
        {
            Container1(new RetrivalProcessFrm());

        }

        private void BtnALLRetrievals_Click(object sender, EventArgs e)
        {
            Container1(new ALLRetrievalsFrm());
        }

        //
        private void guna2Button18_Click(object sender, EventArgs e)
        {
            Container1(new BorrwingsProcessFrm(1));
        }

        private void BtnEditBrrowing_Click(object sender, EventArgs e)
        {
            Container1(new BorrwingsProcessFrm(2));
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            Container1(new AllBorrowingsFRM());
        }

       //Borrowers

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Container1(new EditBorrowerFRM());
        }

        private void BtnAllBorrowers_Click(object sender, EventArgs e)
        {
            Container1(new AllBorrowersFrm());

        }

        //users 
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            Container1(new AddUser());
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

            Container1(new DeleteUserFrm());
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            Container1(new EditUserFrm() );
        }

        private void BtnAllUsers_Click(object sender, EventArgs e)
        {
            Container1(new AllUsersFrm());

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            if (form!=null)
            {
                form.Width = MainContainer.Width;
            }
           
        }

        private void PanelTskbar_Paint(object sender, PaintEventArgs e)
        {


            LbDateTie.Text = DateTime.Now.ToShortDateString();
        }
    }
    }
    

