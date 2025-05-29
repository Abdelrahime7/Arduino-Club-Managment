namespace Wammedh1
{
    partial class DeleteUserFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSearh = new Guna.UI2.WinForms.Guna2Button();
            this.TbUserd = new Guna.UI2.WinForms.Guna2TextBox();
            this.LbitmeID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBuserFname = new System.Windows.Forms.Label();
            this.LbUserName = new System.Windows.Forms.Label();
            this.lbUserLname = new System.Windows.Forms.Label();
            this.LbUserStutus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDeleteUseer = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.BtnSearh);
            this.panel1.Controls.Add(this.TbUserd);
            this.panel1.Controls.Add(this.LbitmeID);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 84);
            this.panel1.TabIndex = 36;
            // 
            // BtnSearh
            // 
            this.BtnSearh.BorderRadius = 20;
            this.BtnSearh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSearh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSearh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSearh.ForeColor = System.Drawing.Color.White;
            this.BtnSearh.Location = new System.Drawing.Point(741, 18);
            this.BtnSearh.Name = "BtnSearh";
            this.BtnSearh.Size = new System.Drawing.Size(107, 45);
            this.BtnSearh.TabIndex = 26;
            this.BtnSearh.Text = "Search";
            this.BtnSearh.Click += new System.EventHandler(this.BtnSearh_Click);
            // 
            // TbUserd
            // 
            this.TbUserd.Animated = true;
            this.TbUserd.AutoRoundedCorners = true;
            this.TbUserd.BorderColor = System.Drawing.Color.Gray;
            this.TbUserd.BorderRadius = 17;
            this.TbUserd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbUserd.DefaultText = "";
            this.TbUserd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbUserd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbUserd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUserd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUserd.FillColor = System.Drawing.Color.LightGray;
            this.TbUserd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUserd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbUserd.ForeColor = System.Drawing.Color.Black;
            this.TbUserd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUserd.Location = new System.Drawing.Point(155, 18);
            this.TbUserd.Name = "TbUserd";
            this.TbUserd.PasswordChar = '\0';
            this.TbUserd.PlaceholderText = "";
            this.TbUserd.SelectedText = "";
            this.TbUserd.Size = new System.Drawing.Size(310, 36);
            this.TbUserd.TabIndex = 25;
            // 
            // LbitmeID
            // 
            this.LbitmeID.AutoSize = true;
            this.LbitmeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbitmeID.Location = new System.Drawing.Point(16, 30);
            this.LbitmeID.Name = "LbitmeID";
            this.LbitmeID.Size = new System.Drawing.Size(81, 20);
            this.LbitmeID.TabIndex = 24;
            this.LbitmeID.Text = "User ID :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.LBuserFname);
            this.panel2.Controls.Add(this.LbUserName);
            this.panel2.Controls.Add(this.lbUserLname);
            this.panel2.Controls.Add(this.LbUserStutus);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.BtnDeleteUseer);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(8, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 208);
            this.panel2.TabIndex = 37;
            // 
            // LBuserFname
            // 
            this.LBuserFname.AutoSize = true;
            this.LBuserFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuserFname.Location = new System.Drawing.Point(128, 31);
            this.LBuserFname.Name = "LBuserFname";
            this.LBuserFname.Size = new System.Drawing.Size(49, 20);
            this.LBuserFname.TabIndex = 40;
            this.LBuserFname.Text = "????";
            this.LBuserFname.Click += new System.EventHandler(this.LBuserFname_Click);
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserName.Location = new System.Drawing.Point(128, 84);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(49, 20);
            this.LbUserName.TabIndex = 39;
            this.LbUserName.Text = "????";
            // 
            // lbUserLname
            // 
            this.lbUserLname.AutoSize = true;
            this.lbUserLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserLname.Location = new System.Drawing.Point(559, 31);
            this.lbUserLname.Name = "lbUserLname";
            this.lbUserLname.Size = new System.Drawing.Size(49, 20);
            this.lbUserLname.TabIndex = 38;
            this.lbUserLname.Text = "????";
            // 
            // LbUserStutus
            // 
            this.LbUserStutus.AutoSize = true;
            this.LbUserStutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserStutus.Location = new System.Drawing.Point(560, 84);
            this.LbUserStutus.Name = "LbUserStutus";
            this.LbUserStutus.Size = new System.Drawing.Size(49, 20);
            this.LbUserStutus.TabIndex = 37;
            this.LbUserStutus.Text = "????";
            this.LbUserStutus.Click += new System.EventHandler(this.LbUserStutus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Stutus :";
            // 
            // Close
            // 
            this.Close.BorderRadius = 20;
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(741, 147);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(107, 45);
            this.Close.TabIndex = 27;
            this.Close.Text = "Close";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // BtnDeleteUseer
            // 
            this.BtnDeleteUseer.BorderRadius = 20;
            this.BtnDeleteUseer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteUseer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteUseer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteUseer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteUseer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteUseer.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteUseer.Location = new System.Drawing.Point(609, 147);
            this.BtnDeleteUseer.Name = "BtnDeleteUseer";
            this.BtnDeleteUseer.Size = new System.Drawing.Size(107, 45);
            this.BtnDeleteUseer.TabIndex = 34;
            this.BtnDeleteUseer.Text = "Delete";
            this.BtnDeleteUseer.Click += new System.EventHandler(this.BtnAddUseer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "LastName :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "UserName :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "FirstName:";
            // 
            // DeleteUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(911, 316);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteUserFrm";
            this.Text = "DeleteUserFrm";
            this.Load += new System.EventHandler(this.DeleteUserFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnSearh;
        private Guna.UI2.WinForms.Guna2TextBox TbUserd;
        private System.Windows.Forms.Label LbitmeID;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button Close;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteUseer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBuserFname;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Label lbUserLname;
        private System.Windows.Forms.Label LbUserStutus;
        private System.Windows.Forms.Label label1;
    }
}