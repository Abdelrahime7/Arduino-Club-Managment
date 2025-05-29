namespace Wammedh1
{
    partial class RetrivalProcessFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSearh = new Guna.UI2.WinForms.Guna2Button();
            this.TbItemId = new Guna.UI2.WinForms.Guna2TextBox();
            this.LbitmeID = new System.Windows.Forms.Label();
            this.RetContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.DgvItemStatistique = new Guna.UI2.WinForms.Guna2DataGridView();
            this.LBBorrStutus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbRetrievalNtes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbBorrowerCart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbBorName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRetrieve = new Guna.UI2.WinForms.Guna2Button();
            this.DpBorrwingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.RetContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItemStatistique)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.BtnSearh);
            this.panel1.Controls.Add(this.TbItemId);
            this.panel1.Controls.Add(this.LbitmeID);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 71);
            this.panel1.TabIndex = 26;
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
            this.BtnSearh.Location = new System.Drawing.Point(685, 10);
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
            this.TbItemId.Location = new System.Drawing.Point(292, 19);
            this.TbItemId.Name = "TbItemId";
            this.TbItemId.PasswordChar = '\0';
            this.TbItemId.PlaceholderText = "";
            this.TbItemId.SelectedText = "";
            this.TbItemId.Size = new System.Drawing.Size(301, 36);
            this.TbItemId.TabIndex = 25;
            // 
            // LbitmeID
            // 
            this.LbitmeID.AutoSize = true;
            this.LbitmeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbitmeID.Location = new System.Drawing.Point(14, 28);
            this.LbitmeID.Name = "LbitmeID";
            this.LbitmeID.Size = new System.Drawing.Size(246, 20);
            this.LbitmeID.TabIndex = 24;
            this.LbitmeID.Text = "Enter  Borrowing Process ID :";
            // 
            // RetContainer
            // 
            this.RetContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RetContainer.BackColor = System.Drawing.Color.SlateBlue;
            this.RetContainer.Controls.Add(this.DgvItemStatistique);
            this.RetContainer.Controls.Add(this.LBBorrStutus);
            this.RetContainer.Controls.Add(this.label5);
            this.RetContainer.Controls.Add(this.TbRetrievalNtes);
            this.RetContainer.Controls.Add(this.label2);
            this.RetContainer.Controls.Add(this.LbBorrowerCart);
            this.RetContainer.Controls.Add(this.label6);
            this.RetContainer.Controls.Add(this.LbBorName);
            this.RetContainer.Controls.Add(this.label3);
            this.RetContainer.Controls.Add(this.BtnClose);
            this.RetContainer.Controls.Add(this.BtnRetrieve);
            this.RetContainer.Controls.Add(this.DpBorrwingDate);
            this.RetContainer.Controls.Add(this.label4);
            this.RetContainer.Controls.Add(this.label1);
            this.RetContainer.Location = new System.Drawing.Point(9, 89);
            this.RetContainer.Name = "RetContainer";
            this.RetContainer.Size = new System.Drawing.Size(860, 403);
            this.RetContainer.TabIndex = 25;
            // 
            // DgvItemStatistique
            // 
            this.DgvItemStatistique.AllowUserToAddRows = false;
            this.DgvItemStatistique.AllowUserToDeleteRows = false;
            this.DgvItemStatistique.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DgvItemStatistique.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvItemStatistique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvItemStatistique.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvItemStatistique.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvItemStatistique.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvItemStatistique.Location = new System.Drawing.Point(248, 88);
            this.DgvItemStatistique.MaximumSize = new System.Drawing.Size(605, 100);
            this.DgvItemStatistique.MinimumSize = new System.Drawing.Size(605, 100);
            this.DgvItemStatistique.Name = "DgvItemStatistique";
            this.DgvItemStatistique.RowHeadersVisible = false;
            this.DgvItemStatistique.Size = new System.Drawing.Size(605, 100);
            this.DgvItemStatistique.TabIndex = 32;
            this.DgvItemStatistique.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvItemStatistique.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvItemStatistique.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvItemStatistique.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvItemStatistique.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvItemStatistique.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvItemStatistique.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvItemStatistique.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvItemStatistique.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvItemStatistique.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvItemStatistique.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvItemStatistique.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvItemStatistique.ThemeStyle.HeaderStyle.Height = 30;
            this.DgvItemStatistique.ThemeStyle.ReadOnly = false;
            this.DgvItemStatistique.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvItemStatistique.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvItemStatistique.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvItemStatistique.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvItemStatistique.ThemeStyle.RowsStyle.Height = 22;
            this.DgvItemStatistique.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvItemStatistique.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // LBBorrStutus
            // 
            this.LBBorrStutus.AutoSize = true;
            this.LBBorrStutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBorrStutus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LBBorrStutus.Location = new System.Drawing.Point(244, 210);
            this.LBBorrStutus.Name = "LBBorrStutus";
            this.LBBorrStutus.Size = new System.Drawing.Size(59, 20);
            this.LBBorrStutus.TabIndex = 31;
            this.LBBorrStutus.Text = "?????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Borrowing Stutus :\r\n";
            // 
            // TbRetrievalNtes
            // 
            this.TbRetrievalNtes.BorderColor = System.Drawing.Color.Gray;
            this.TbRetrievalNtes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbRetrievalNtes.DefaultText = "";
            this.TbRetrievalNtes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbRetrievalNtes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbRetrievalNtes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbRetrievalNtes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbRetrievalNtes.FillColor = System.Drawing.Color.LightGray;
            this.TbRetrievalNtes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbRetrievalNtes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbRetrievalNtes.ForeColor = System.Drawing.Color.Black;
            this.TbRetrievalNtes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbRetrievalNtes.Location = new System.Drawing.Point(250, 249);
            this.TbRetrievalNtes.Name = "TbRetrievalNtes";
            this.TbRetrievalNtes.PasswordChar = '\0';
            this.TbRetrievalNtes.PlaceholderText = "";
            this.TbRetrievalNtes.SelectedText = "";
            this.TbRetrievalNtes.Size = new System.Drawing.Size(527, 78);
            this.TbRetrievalNtes.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Retrieval Notes :\r\n";
            // 
            // LbBorrowerCart
            // 
            this.LbBorrowerCart.AutoSize = true;
            this.LbBorrowerCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBorrowerCart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LbBorrowerCart.Location = new System.Drawing.Point(264, 17);
            this.LbBorrowerCart.Name = "LbBorrowerCart";
            this.LbBorrowerCart.Size = new System.Drawing.Size(49, 20);
            this.LbBorrowerCart.TabIndex = 27;
            this.LbBorrowerCart.Text = "????";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Borrower\'s Student Card ID :";
            // 
            // LbBorName
            // 
            this.LbBorName.AutoSize = true;
            this.LbBorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBorName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LbBorName.Location = new System.Drawing.Point(175, 53);
            this.LbBorName.Name = "LbBorName";
            this.LbBorName.Size = new System.Drawing.Size(49, 20);
            this.LbBorName.TabIndex = 25;
            this.LbBorName.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Borrower\'s Name :";
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
            this.BtnClose.Location = new System.Drawing.Point(685, 344);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(107, 45);
            this.BtnClose.TabIndex = 23;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnRetrieve
            // 
            this.BtnRetrieve.BorderRadius = 20;
            this.BtnRetrieve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRetrieve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRetrieve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRetrieve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRetrieve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRetrieve.ForeColor = System.Drawing.Color.White;
            this.BtnRetrieve.Location = new System.Drawing.Point(526, 344);
            this.BtnRetrieve.Name = "BtnRetrieve";
            this.BtnRetrieve.Size = new System.Drawing.Size(107, 45);
            this.BtnRetrieve.TabIndex = 22;
            this.BtnRetrieve.Text = "Retrieve";
            this.BtnRetrieve.Click += new System.EventHandler(this.BtnEditItem_Click);
            // 
            // DpBorrwingDate
            // 
            this.DpBorrwingDate.Animated = true;
            this.DpBorrwingDate.AutoRoundedCorners = true;
            this.DpBorrwingDate.BackColor = System.Drawing.Color.Transparent;
            this.DpBorrwingDate.BorderColor = System.Drawing.Color.Gray;
            this.DpBorrwingDate.BorderRadius = 17;
            this.DpBorrwingDate.Checked = true;
            this.DpBorrwingDate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DpBorrwingDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DpBorrwingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpBorrwingDate.Location = new System.Drawing.Point(736, 6);
            this.DpBorrwingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DpBorrwingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DpBorrwingDate.Name = "DpBorrwingDate";
            this.DpBorrwingDate.Size = new System.Drawing.Size(117, 36);
            this.DpBorrwingDate.TabIndex = 20;
            this.DpBorrwingDate.Value = new System.DateTime(2024, 12, 22, 14, 56, 40, 527);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Borrwings Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Items  Name And Quantity :\r\n";
            // 
            // RetrivalProcessFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(878, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RetContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetrivalProcessFrm";
            this.Load += new System.EventHandler(this.RetrivalProcessFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RetContainer.ResumeLayout(false);
            this.RetContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItemStatistique)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnSearh;
        private Guna.UI2.WinForms.Guna2TextBox TbItemId;
        private System.Windows.Forms.Label LbitmeID;
        private Guna.UI2.WinForms.Guna2Panel RetContainer;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnRetrieve;
        private Guna.UI2.WinForms.Guna2DateTimePicker DpBorrwingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbBorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbBorrowerCart;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TbRetrievalNtes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBBorrStutus;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DgvItemStatistique;
    }
}