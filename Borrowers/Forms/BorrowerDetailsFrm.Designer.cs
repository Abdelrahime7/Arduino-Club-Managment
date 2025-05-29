namespace WAMEEDHLAST
{
    partial class BorrowerDetailsFrm
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
            this.crlBorroerInfo1 = new WAMEEDHLAST.CrlBorrowerInfo();
            this.crlPersnInfo1 = new WAMEEDHLAST.CrlPersnInfo();
            this.SuspendLayout();
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
            this.BtnClose.Location = new System.Drawing.Point(681, 344);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(107, 45);
            this.BtnClose.TabIndex = 34;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // crlBorroerInfo1
            // 
            this.crlBorroerInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.crlBorroerInfo1.Location = new System.Drawing.Point(12, 168);
            this.crlBorroerInfo1.Name = "crlBorroerInfo1";
            this.crlBorroerInfo1.Size = new System.Drawing.Size(776, 166);
            this.crlBorroerInfo1.TabIndex = 35;
            this.crlBorroerInfo1.Load += new System.EventHandler(this.crlBorroerInfo1_Load);
            // 
            // crlPersnInfo1
            // 
            this.crlPersnInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.crlPersnInfo1.Location = new System.Drawing.Point(12, 12);
            this.crlPersnInfo1.Name = "crlPersnInfo1";
            this.crlPersnInfo1.Size = new System.Drawing.Size(776, 145);
            this.crlPersnInfo1.TabIndex = 0;
            // 
            // BorrowerDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.crlBorroerInfo1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.crlPersnInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowerDetailsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowerDetailsFrm";
            this.Load += new System.EventHandler(this.BorrowerDetailsFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrlPersnInfo crlPersnInfo1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private CrlBorrowerInfo crlBorroerInfo1;
    }
}