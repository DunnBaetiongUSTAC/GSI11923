namespace FormCollection.Forms
{
    partial class FormAddStudent
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
            this.btnStudentSearch = new System.Windows.Forms.Panel();
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
            this.dgvAddStudent = new System.Windows.Forms.DataGridView();
            this.txtStudentSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtStudentFName = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.btnStudentEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStudentMName = new System.Windows.Forms.TextBox();
            this.txtStudentLName = new System.Windows.Forms.TextBox();
            this.txtStudentSuffix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStudentSearch.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.BackColor = System.Drawing.Color.DarkBlue;
            this.btnStudentSearch.Controls.Add(this.panel3);
            this.btnStudentSearch.Controls.Add(this.pictureBox1);
            this.btnStudentSearch.Controls.Add(this.label2);
            this.btnStudentSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentSearch.Location = new System.Drawing.Point(0, 0);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(1401, 100);
            this.btnStudentSearch.TabIndex = 8;
            this.btnStudentSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel4.Size = new System.Drawing.Size(200, 503);
            this.panel4.TabIndex = 9;
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
            this.btnManageStudentProfile.Click += new System.EventHandler(this.btnStudent_Click);
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
            this.btnPendingTransactions.Click += new System.EventHandler(this.btnPendingTransactions_Click);
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
            this.btnViewInventory.Click += new System.EventHandler(this.button10_Click);
            // 
            // dgvAddStudent
            // 
            this.dgvAddStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddStudent.Location = new System.Drawing.Point(226, 121);
            this.dgvAddStudent.Name = "dgvAddStudent";
            this.dgvAddStudent.Size = new System.Drawing.Size(660, 415);
            this.dgvAddStudent.TabIndex = 11;
            this.dgvAddStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataGridView_CellContentClick);
            // 
            // txtStudentSearch
            // 
            this.txtStudentSearch.Location = new System.Drawing.Point(933, 140);
            this.txtStudentSearch.Name = "txtStudentSearch";
            this.txtStudentSearch.Size = new System.Drawing.Size(332, 20);
            this.txtStudentSearch.TabIndex = 12;
            this.txtStudentSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1282, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(933, 241);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(332, 20);
            this.txtStudentNumber.TabIndex = 14;
            // 
            // txtStudentFName
            // 
            this.txtStudentFName.Location = new System.Drawing.Point(933, 301);
            this.txtStudentFName.Name = "txtStudentFName";
            this.txtStudentFName.Size = new System.Drawing.Size(101, 20);
            this.txtStudentFName.TabIndex = 15;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(933, 361);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(332, 20);
            this.txtStudentEmail.TabIndex = 16;
            // 
            // btnStudentEdit
            // 
            this.btnStudentEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnStudentEdit.FlatAppearance.BorderSize = 0;
            this.btnStudentEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentEdit.ForeColor = System.Drawing.Color.Black;
            this.btnStudentEdit.Location = new System.Drawing.Point(1152, 400);
            this.btnStudentEdit.Name = "btnStudentEdit";
            this.btnStudentEdit.Size = new System.Drawing.Size(83, 23);
            this.btnStudentEdit.TabIndex = 17;
            this.btnStudentEdit.Text = "Edit";
            this.btnStudentEdit.UseVisualStyleBackColor = false;
            this.btnStudentEdit.Click += new System.EventHandler(this.btnStudentEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(929, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Find Student:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(929, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(929, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(929, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email Address:";
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnStudentAdd.FlatAppearance.BorderSize = 0;
            this.btnStudentAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentAdd.ForeColor = System.Drawing.Color.Black;
            this.btnStudentAdd.Location = new System.Drawing.Point(1268, 400);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(83, 23);
            this.btnStudentAdd.TabIndex = 22;
            this.btnStudentAdd.Text = "Add";
            this.btnStudentAdd.UseVisualStyleBackColor = false;
            this.btnStudentAdd.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // txtStudentMName
            // 
            this.txtStudentMName.Location = new System.Drawing.Point(1040, 301);
            this.txtStudentMName.Name = "txtStudentMName";
            this.txtStudentMName.Size = new System.Drawing.Size(107, 20);
            this.txtStudentMName.TabIndex = 23;
            // 
            // txtStudentLName
            // 
            this.txtStudentLName.Location = new System.Drawing.Point(1153, 301);
            this.txtStudentLName.Name = "txtStudentLName";
            this.txtStudentLName.Size = new System.Drawing.Size(112, 20);
            this.txtStudentLName.TabIndex = 24;
            // 
            // txtStudentSuffix
            // 
            this.txtStudentSuffix.Location = new System.Drawing.Point(1282, 301);
            this.txtStudentSuffix.Name = "txtStudentSuffix";
            this.txtStudentSuffix.Size = new System.Drawing.Size(35, 20);
            this.txtStudentSuffix.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1036, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Middle Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1149, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1278, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Suffix:";
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1401, 603);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudentSuffix);
            this.Controls.Add(this.txtStudentLName);
            this.Controls.Add(this.txtStudentMName);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStudentEdit);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtStudentFName);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStudentSearch);
            this.Controls.Add(this.dgvAddStudent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnStudentSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddStudent";
            this.Text = "FormAddStudent";
            this.Load += new System.EventHandler(this.FormAddStudent_Load);
            this.btnStudentSearch.ResumeLayout(false);
            this.btnStudentSearch.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnStudentSearch;
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
        private System.Windows.Forms.DataGridView dgvAddStudent;
        private System.Windows.Forms.TextBox txtStudentSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentFName;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.Button btnStudentEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStudentAdd;
        
        private System.Windows.Forms.BindingSource studentBindingSource;
        
        private System.Windows.Forms.TextBox txtStudentMName;
        private System.Windows.Forms.TextBox txtStudentLName;
        private System.Windows.Forms.TextBox txtStudentSuffix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}