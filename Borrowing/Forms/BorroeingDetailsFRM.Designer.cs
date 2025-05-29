namespace WAMEEDHLAST
{
    partial class BorroeingDetailsFRM
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
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.crlBorrowingsInfo1 = new WAMEEDHLAST.CrlBorrowingsInfo();
            this.crlBorroerInfo1 = new WAMEEDHLAST.CrlBorrowerInfo();
            this.crlPersnInfo1 = new WAMEEDHLAST.CrlPersnInfo();
            this.BtnItemDetail = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BorderRadius = 20;
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(726, 389);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(107, 45);
            this.BtnClose.TabIndex = 35;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // crlBorrowingsInfo1
            // 
            this.crlBorrowingsInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.crlBorrowingsInfo1.Location = new System.Drawing.Point(12, 262);
            this.crlBorrowingsInfo1.Name = "crlBorrowingsInfo1";
            this.crlBorrowingsInfo1.Size = new System.Drawing.Size(821, 116);
            this.crlBorrowingsInfo1.TabIndex = 2;
            // 
            // crlBorroerInfo1
            // 
            this.crlBorroerInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.crlBorroerInfo1.Location = new System.Drawing.Point(12, 127);
            this.crlBorroerInfo1.Name = "crlBorroerInfo1";
            this.crlBorroerInfo1.Size = new System.Drawing.Size(821, 129);
            this.crlBorroerInfo1.TabIndex = 1;
            // 
            // crlPersnInfo1
            // 
            this.crlPersnInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.crlPersnInfo1.Location = new System.Drawing.Point(12, 7);
            this.crlPersnInfo1.Name = "crlPersnInfo1";
            this.crlPersnInfo1.Size = new System.Drawing.Size(821, 114);
            this.crlPersnInfo1.TabIndex = 0;
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
            this.BtnItemDetail.Location = new System.Drawing.Point(446, 390);
            this.BtnItemDetail.Name = "BtnItemDetail";
            this.BtnItemDetail.Size = new System.Drawing.Size(142, 45);
            this.BtnItemDetail.TabIndex = 36;
            this.BtnItemDetail.Text = "See Item details";
            this.BtnItemDetail.Click += new System.EventHandler(this.BtnItemDetail_Click);
            // 
            // BorroeingDetailsFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(845, 446);
            this.Controls.Add(this.BtnItemDetail);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.crlBorrowingsInfo1);
            this.Controls.Add(this.crlBorroerInfo1);
            this.Controls.Add(this.crlPersnInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorroeingDetailsFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorroeingDetailsFRM";
            this.Load += new System.EventHandler(this.BorroeingDetailsFRM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrlPersnInfo crlPersnInfo1;
        private CrlBorrowerInfo crlBorroerInfo1;
        private CrlBorrowingsInfo crlBorrowingsInfo1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnItemDetail;
    }
}