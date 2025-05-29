namespace WAMEEDHLAST
{
    partial class RetrivalinfoFrm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LbUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbRetrievalDate = new System.Windows.Forms.Label();
            this.LbretrivalID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.crlBorrowingsInfo1 = new WAMEEDHLAST.CrlBorrowingsInfo();
            this.crlBorroerInfo1 = new WAMEEDHLAST.CrlBorrowerInfo();
            this.crlPersnInfo1 = new WAMEEDHLAST.CrlPersnInfo();
            this.BtnItemDetail = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Controls.Add(this.LbUserID);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.LbRetrievalDate);
            this.guna2Panel1.Controls.Add(this.LbretrivalID);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(9, 9);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(792, 88);
            this.guna2Panel1.TabIndex = 0;
            // 
            // LbUserID
            // 
            this.LbUserID.AutoSize = true;
            this.LbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserID.Location = new System.Drawing.Point(727, 48);
            this.LbUserID.Name = "LbUserID";
            this.LbUserID.Size = new System.Drawing.Size(45, 20);
            this.LbUserID.TabIndex = 5;
            this.LbUserID.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Retrieved by User ID :";
            // 
            // LbRetrievalDate
            // 
            this.LbRetrievalDate.AutoSize = true;
            this.LbRetrievalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRetrievalDate.Location = new System.Drawing.Point(212, 48);
            this.LbRetrievalDate.Name = "LbRetrievalDate";
            this.LbRetrievalDate.Size = new System.Drawing.Size(45, 20);
            this.LbRetrievalDate.TabIndex = 3;
            this.LbRetrievalDate.Text = "????";
            // 
            // LbretrivalID
            // 
            this.LbretrivalID.AutoSize = true;
            this.LbretrivalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbretrivalID.Location = new System.Drawing.Point(212, 15);
            this.LbretrivalID.Name = "LbretrivalID";
            this.LbretrivalID.Size = new System.Drawing.Size(45, 20);
            this.LbretrivalID.TabIndex = 2;
            this.LbretrivalID.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Retrieval Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retrieval Process ID :";
            // 
            // BtnClose
            // 
            this.BtnClose.BorderRadius = 20;
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(694, 444);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(107, 45);
            this.BtnClose.TabIndex = 35;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // crlBorrowingsInfo1
            // 
            this.crlBorrowingsInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.crlBorrowingsInfo1.Location = new System.Drawing.Point(12, 345);
            this.crlBorrowingsInfo1.Name = "crlBorrowingsInfo1";
            this.crlBorrowingsInfo1.Size = new System.Drawing.Size(789, 93);
            this.crlBorrowingsInfo1.TabIndex = 3;
            // 
            // crlBorroerInfo1
            // 
            this.crlBorroerInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.crlBorroerInfo1.Location = new System.Drawing.Point(12, 218);
            this.crlBorroerInfo1.Name = "crlBorroerInfo1";
            this.crlBorroerInfo1.Size = new System.Drawing.Size(789, 121);
            this.crlBorroerInfo1.TabIndex = 2;
            // 
            // crlPersnInfo1
            // 
            this.crlPersnInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.crlPersnInfo1.Location = new System.Drawing.Point(12, 103);
            this.crlPersnInfo1.Name = "crlPersnInfo1";
            this.crlPersnInfo1.Size = new System.Drawing.Size(789, 109);
            this.crlPersnInfo1.TabIndex = 1;
            // 
            // BtnItemDetail
            // 
            this.BtnItemDetail.BorderRadius = 20;
            this.BtnItemDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnItemDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnItemDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnItemDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnItemDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnItemDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItemDetail.ForeColor = System.Drawing.Color.Black;
            this.BtnItemDetail.Location = new System.Drawing.Point(525, 444);
            this.BtnItemDetail.Name = "BtnItemDetail";
            this.BtnItemDetail.Size = new System.Drawing.Size(142, 45);
            this.BtnItemDetail.TabIndex = 37;
            this.BtnItemDetail.Text = "See Item details";
            this.BtnItemDetail.Click += new System.EventHandler(this.BtnItemDetail_Click);
            // 
            // RetrivalinfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(813, 499);
            this.Controls.Add(this.BtnItemDetail);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.crlBorrowingsInfo1);
            this.Controls.Add(this.crlBorroerInfo1);
            this.Controls.Add(this.crlPersnInfo1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetrivalinfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetrivalinfoFrm";
            this.Load += new System.EventHandler(this.RetrivalinfoFrm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbRetrievalDate;
        private System.Windows.Forms.Label LbretrivalID;
        private CrlPersnInfo crlPersnInfo1;
        private CrlBorrowerInfo crlBorroerInfo1;
        private CrlBorrowingsInfo crlBorrowingsInfo1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.Label LbUserID;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button BtnItemDetail;
    }
}