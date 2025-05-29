namespace Wammedh1
{
    partial class DeletItemFrm
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
            this.SearchContainer = new System.Windows.Forms.Panel();
            this.BtnSearh = new Guna.UI2.WinForms.Guna2Button();
            this.TbItemId = new Guna.UI2.WinForms.Guna2TextBox();
            this.LbitmeIDs = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBItemID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbItemREF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbItemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchContainer
            // 
            this.SearchContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchContainer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SearchContainer.Controls.Add(this.BtnSearh);
            this.SearchContainer.Controls.Add(this.TbItemId);
            this.SearchContainer.Controls.Add(this.LbitmeIDs);
            this.SearchContainer.Location = new System.Drawing.Point(10, 9);
            this.SearchContainer.Name = "SearchContainer";
            this.SearchContainer.Size = new System.Drawing.Size(714, 83);
            this.SearchContainer.TabIndex = 25;
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
            this.BtnSearh.Location = new System.Drawing.Point(583, 16);
            this.BtnSearh.Name = "BtnSearh";
            this.BtnSearh.Size = new System.Drawing.Size(107, 45);
            this.BtnSearh.TabIndex = 26;
            this.BtnSearh.Text = "Search";
            this.BtnSearh.Click += new System.EventHandler(this.BtnSearh_Click);
            // 
            // TbItemId
            // 
            this.TbItemId.Animated = true;
            this.TbItemId.AutoRoundedCorners = true;
            this.TbItemId.BorderColor = System.Drawing.Color.Gray;
            this.TbItemId.BorderRadius = 17;
            this.TbItemId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbItemId.DefaultText = "";
            this.TbItemId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbItemId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbItemId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbItemId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbItemId.FillColor = System.Drawing.Color.LightGray;
            this.TbItemId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbItemId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbItemId.ForeColor = System.Drawing.Color.Black;
            this.TbItemId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbItemId.Location = new System.Drawing.Point(170, 16);
            this.TbItemId.Name = "TbItemId";
            this.TbItemId.PasswordChar = '\0';
            this.TbItemId.PlaceholderText = "";
            this.TbItemId.SelectedText = "";
            this.TbItemId.Size = new System.Drawing.Size(323, 36);
            this.TbItemId.TabIndex = 25;
            // 
            // LbitmeIDs
            // 
            this.LbitmeIDs.AutoSize = true;
            this.LbitmeIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbitmeIDs.Location = new System.Drawing.Point(16, 28);
            this.LbitmeIDs.Name = "LbitmeIDs";
            this.LbitmeIDs.Size = new System.Drawing.Size(79, 20);
            this.LbitmeIDs.TabIndex = 24;
            this.LbitmeIDs.Text = "Item ID :";
            // 
            // BtnClose
            // 
            this.BtnClose.BorderRadius = 20;
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(506, 135);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(107, 45);
            this.BtnClose.TabIndex = 30;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BorderRadius = 20;
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(299, 135);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(107, 45);
            this.BtnDelete.TabIndex = 28;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.LBItemID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LbItemREF);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LbItemName);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 201);
            this.panel2.TabIndex = 31;
            // 
            // LBItemID
            // 
            this.LBItemID.AutoSize = true;
            this.LBItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBItemID.Location = new System.Drawing.Point(167, 34);
            this.LBItemID.Name = "LBItemID";
            this.LBItemID.Size = new System.Drawing.Size(49, 20);
            this.LBItemID.TabIndex = 35;
            this.LBItemID.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Item ID :";
            // 
            // LbItemREF
            // 
            this.LbItemREF.AutoSize = true;
            this.LbItemREF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbItemREF.Location = new System.Drawing.Point(167, 112);
            this.LbItemREF.Name = "LbItemREF";
            this.LbItemREF.Size = new System.Drawing.Size(49, 20);
            this.LbItemREF.TabIndex = 33;
            this.LbItemREF.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Item Reference :";
            // 
            // LbItemName
            // 
            this.LbItemName.AutoSize = true;
            this.LbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbItemName.Location = new System.Drawing.Point(167, 70);
            this.LbItemName.Name = "LbItemName";
            this.LbItemName.Size = new System.Drawing.Size(49, 20);
            this.LbItemName.TabIndex = 31;
            this.LbItemName.Text = "????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Item Name :";
            // 
            // DeletItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(734, 312);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SearchContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletItemFrm";
            this.Text = "DeletItemFrm";
            this.Load += new System.EventHandler(this.DeletItemFrm_Load);
            this.SearchContainer.ResumeLayout(false);
            this.SearchContainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchContainer;
        private Guna.UI2.WinForms.Guna2Button BtnSearh;
        private Guna.UI2.WinForms.Guna2TextBox TbItemId;
        private System.Windows.Forms.Label LbitmeIDs;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbItemName;
        private System.Windows.Forms.Label LbItemREF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBItemID;
        private System.Windows.Forms.Label label4;
    }
}