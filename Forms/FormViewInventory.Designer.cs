﻿namespace FormCollection.Forms
{
    partial class FormViewInventory
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGiveAccess = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnManageStudentProfile = new System.Windows.Forms.Button();
            this.btnPendingTransaction = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnEditInv = new System.Windows.Forms.Button();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogout);
            this.panel4.Location = new System.Drawing.Point(1226, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 47);
            this.panel4.TabIndex = 9;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Chocolate;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 46);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(850, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.labelEmail);
            this.panel3.Location = new System.Drawing.Point(1216, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 46);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(37, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Chocolate;
            this.labelEmail.Location = new System.Drawing.Point(20, 15);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(101, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Welcome Admin!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormCollection.Properties.Resources.GLENDALE_icon_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(53, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(198, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "GLENDALE LIBRARY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseMnemonic = false;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Author",
            "Category",
            "SubCategory",
            "Title"});
            this.cmbSearch.Location = new System.Drawing.Point(703, 46);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbSearch.TabIndex = 1;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(1168, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "GO";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnGiveAccess);
            this.panel2.Controls.Add(this.btnAddTransaction);
            this.panel2.Controls.Add(this.btnManageStudentProfile);
            this.panel2.Controls.Add(this.btnPendingTransaction);
            this.panel2.Controls.Add(this.btnTransactionHistory);
            this.panel2.Controls.Add(this.btnViewInventory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 532);
            this.panel2.TabIndex = 7;
            // 
            // btnGiveAccess
            // 
            this.btnGiveAccess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiveAccess.FlatAppearance.BorderSize = 0;
            this.btnGiveAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveAccess.ForeColor = System.Drawing.Color.White;
            this.btnGiveAccess.Location = new System.Drawing.Point(0, 300);
            this.btnGiveAccess.Name = "btnGiveAccess";
            this.btnGiveAccess.Size = new System.Drawing.Size(200, 60);
            this.btnGiveAccess.TabIndex = 5;
            this.btnGiveAccess.Text = "Give Access";
            this.btnGiveAccess.UseVisualStyleBackColor = true;
            this.btnGiveAccess.Click += new System.EventHandler(this.btnGiveAccess_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Location = new System.Drawing.Point(0, 240);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(200, 60);
            this.btnAddTransaction.TabIndex = 4;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnManageStudentProfile
            // 
            this.btnManageStudentProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStudentProfile.FlatAppearance.BorderSize = 0;
            this.btnManageStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudentProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudentProfile.ForeColor = System.Drawing.Color.White;
            this.btnManageStudentProfile.Location = new System.Drawing.Point(0, 180);
            this.btnManageStudentProfile.Name = "btnManageStudentProfile";
            this.btnManageStudentProfile.Size = new System.Drawing.Size(200, 60);
            this.btnManageStudentProfile.TabIndex = 3;
            this.btnManageStudentProfile.Text = "Manage Student Profile";
            this.btnManageStudentProfile.UseVisualStyleBackColor = true;
            this.btnManageStudentProfile.Click += new System.EventHandler(this.btnManageStudentProfile_Click);
            // 
            // btnPendingTransaction
            // 
            this.btnPendingTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendingTransaction.FlatAppearance.BorderSize = 0;
            this.btnPendingTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingTransaction.ForeColor = System.Drawing.Color.White;
            this.btnPendingTransaction.Location = new System.Drawing.Point(0, 120);
            this.btnPendingTransaction.Name = "btnPendingTransaction";
            this.btnPendingTransaction.Size = new System.Drawing.Size(200, 60);
            this.btnPendingTransaction.TabIndex = 2;
            this.btnPendingTransaction.Text = "Pending Transactions";
            this.btnPendingTransaction.UseVisualStyleBackColor = true;
            this.btnPendingTransaction.Click += new System.EventHandler(this.btnPendingTransaction_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionHistory.FlatAppearance.BorderSize = 0;
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionHistory.ForeColor = System.Drawing.Color.White;
            this.btnTransactionHistory.Location = new System.Drawing.Point(0, 60);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(200, 60);
            this.btnTransactionHistory.TabIndex = 1;
            this.btnTransactionHistory.Text = "Transaction History";
            this.btnTransactionHistory.UseVisualStyleBackColor = true;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewInventory.FlatAppearance.BorderSize = 0;
            this.btnViewInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInventory.ForeColor = System.Drawing.Color.White;
            this.btnViewInventory.Location = new System.Drawing.Point(0, 0);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(200, 60);
            this.btnViewInventory.TabIndex = 0;
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(256, 142);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(1043, 415);
            this.dgvSearch.TabIndex = 8;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataGridView_CellContentClick);
            // 
            // btnEditInv
            // 
            this.btnEditInv.BackColor = System.Drawing.Color.Yellow;
            this.btnEditInv.FlatAppearance.BorderSize = 0;
            this.btnEditInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInv.ForeColor = System.Drawing.Color.Black;
            this.btnEditInv.Location = new System.Drawing.Point(1216, 576);
            this.btnEditInv.Name = "btnEditInv";
            this.btnEditInv.Size = new System.Drawing.Size(83, 23);
            this.btnEditInv.TabIndex = 7;
            this.btnEditInv.Text = "Edit";
            this.btnEditInv.UseVisualStyleBackColor = false;
            this.btnEditInv.Click += new System.EventHandler(this.btnEditInv_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            // 
            // FormViewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1349, 632);
            this.Controls.Add(this.btnEditInv);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormViewInventory";
            this.Load += new System.EventHandler(this.FormViewInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGiveAccess;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnManageStudentProfile;
        private System.Windows.Forms.Button btnPendingTransaction;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnEditInv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        
        private System.Windows.Forms.BindingSource bookBindingSource;
        
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLogout;
    }
}