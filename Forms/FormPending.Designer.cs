namespace FormCollection.Forms
{
    partial class FormPending
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGiveAccess = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnManageStudentProfile = new System.Windows.Forms.Button();
            this.btnPendingTransactions = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.btnPendingEdit = new System.Windows.Forms.Button();
            this.btnPendingReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 100);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.btnEmail);
            this.panel3.Location = new System.Drawing.Point(1252, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 94);
            this.panel3.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Chocolate;
            this.btnLogout.Location = new System.Drawing.Point(0, 46);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 46);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.Chocolate;
            this.btnEmail.Location = new System.Drawing.Point(0, 0);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(146, 46);
            this.btnEmail.TabIndex = 0;
            this.btnEmail.Text = "Welcome Admin!";
            this.btnEmail.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(198, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "GLENDALE LIBRARY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseMnemonic = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.btnGiveAccess);
            this.panel4.Controls.Add(this.btnAddTransaction);
            this.panel4.Controls.Add(this.btnManageStudentProfile);
            this.panel4.Controls.Add(this.btnPendingTransactions);
            this.panel4.Controls.Add(this.btnTransactionHistory);
            this.panel4.Controls.Add(this.btnViewInventory);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 496);
            this.panel4.TabIndex = 10;
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
            this.btnAddTransaction.Click += new System.EventHandler(this.button5_Click);
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
            // 
            // btnPendingTransactions
            // 
            this.btnPendingTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendingTransactions.FlatAppearance.BorderSize = 0;
            this.btnPendingTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingTransactions.ForeColor = System.Drawing.Color.White;
            this.btnPendingTransactions.Location = new System.Drawing.Point(0, 120);
            this.btnPendingTransactions.Name = "btnPendingTransactions";
            this.btnPendingTransactions.Size = new System.Drawing.Size(200, 60);
            this.btnPendingTransactions.TabIndex = 2;
            this.btnPendingTransactions.Text = "Pending Transactions";
            this.btnPendingTransactions.UseVisualStyleBackColor = true;
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
            // 
            // dgvPending
            // 
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPending.Location = new System.Drawing.Point(220, 117);
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.Size = new System.Drawing.Size(1147, 415);
            this.dgvPending.TabIndex = 11;
            // 
            // btnPendingEdit
            // 
            this.btnPendingEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnPendingEdit.FlatAppearance.BorderSize = 0;
            this.btnPendingEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingEdit.ForeColor = System.Drawing.Color.Black;
            this.btnPendingEdit.Location = new System.Drawing.Point(1268, 548);
            this.btnPendingEdit.Name = "btnPendingEdit";
            this.btnPendingEdit.Size = new System.Drawing.Size(83, 23);
            this.btnPendingEdit.TabIndex = 12;
            this.btnPendingEdit.Text = "Edit";
            this.btnPendingEdit.UseVisualStyleBackColor = false;
            // 
            // btnPendingReturn
            // 
            this.btnPendingReturn.BackColor = System.Drawing.Color.Lime;
            this.btnPendingReturn.FlatAppearance.BorderSize = 0;
            this.btnPendingReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingReturn.ForeColor = System.Drawing.Color.Black;
            this.btnPendingReturn.Location = new System.Drawing.Point(1179, 548);
            this.btnPendingReturn.Name = "btnPendingReturn";
            this.btnPendingReturn.Size = new System.Drawing.Size(83, 23);
            this.btnPendingReturn.TabIndex = 13;
            this.btnPendingReturn.Text = "Return";
            this.btnPendingReturn.UseVisualStyleBackColor = false;
            // 
            // FormPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1406, 596);
            this.Controls.Add(this.btnPendingReturn);
            this.Controls.Add(this.btnPendingEdit);
            this.Controls.Add(this.dgvPending);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPending";
            this.Text = "FormPending";
            this.Load += new System.EventHandler(this.FormPending_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGiveAccess;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnManageStudentProfile;
        private System.Windows.Forms.Button btnPendingTransactions;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.Button btnPendingEdit;
        private System.Windows.Forms.Button btnPendingReturn;
    }
}