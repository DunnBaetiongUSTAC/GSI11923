namespace FormCollection.Forms
{
    partial class FormEdit
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditDelete = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.txtEditQuantity = new System.Windows.Forms.TextBox();
            this.txtEditBookCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.txtEditTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEditAuthor = new System.Windows.Forms.ComboBox();
            this.cmbEditCategory = new System.Windows.Forms.ComboBox();
            this.cmbEditSubCategory = new System.Windows.Forms.ComboBox();
            this.txtEditYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEditPublisher = new System.Windows.Forms.ComboBox();
            this.cmbEditShelf = new System.Windows.Forms.ComboBox();
            this.cmbEditRow = new System.Windows.Forms.ComboBox();
            this.btnEditConfigure = new System.Windows.Forms.Button();
            this.txtEditSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEditSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 100);
            this.panel1.TabIndex = 8;
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
            // btnEditDelete
            // 
            this.btnEditDelete.BackColor = System.Drawing.Color.Red;
            this.btnEditDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDelete.Location = new System.Drawing.Point(408, 488);
            this.btnEditDelete.Name = "btnEditDelete";
            this.btnEditDelete.Size = new System.Drawing.Size(95, 35);
            this.btnEditDelete.TabIndex = 31;
            this.btnEditDelete.Text = "Delete";
            this.btnEditDelete.UseVisualStyleBackColor = false;
            this.btnEditDelete.Click += new System.EventHandler(this.btnEditDelete_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnEditUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUpdate.Location = new System.Drawing.Point(276, 488);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(95, 35);
            this.btnEditUpdate.TabIndex = 30;
            this.btnEditUpdate.Text = "Update";
            this.btnEditUpdate.UseVisualStyleBackColor = false;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.BackColor = System.Drawing.Color.Lime;
            this.btnEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditAdd.Location = new System.Drawing.Point(139, 488);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(95, 35);
            this.btnEditAdd.TabIndex = 29;
            this.btnEditAdd.Text = "Add";
            this.btnEditAdd.UseVisualStyleBackColor = false;
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // txtEditQuantity
            // 
            this.txtEditQuantity.Location = new System.Drawing.Point(263, 293);
            this.txtEditQuantity.Name = "txtEditQuantity";
            this.txtEditQuantity.Size = new System.Drawing.Size(240, 20);
            this.txtEditQuantity.TabIndex = 26;
            // 
            // txtEditBookCode
            // 
            this.txtEditBookCode.Location = new System.Drawing.Point(263, 179);
            this.txtEditBookCode.Name = "txtEditBookCode";
            this.txtEditBookCode.Size = new System.Drawing.Size(240, 20);
            this.txtEditBookCode.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sub-Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Publisher:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Author:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Book Code:";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Location = new System.Drawing.Point(12, 612);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(95, 35);
            this.btnEditCancel.TabIndex = 33;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // txtEditTitle
            // 
            this.txtEditTitle.Location = new System.Drawing.Point(263, 207);
            this.txtEditTitle.Name = "txtEditTitle";
            this.txtEditTitle.Size = new System.Drawing.Size(240, 20);
            this.txtEditTitle.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Title:";
            // 
            // cmbEditAuthor
            // 
            this.cmbEditAuthor.FormattingEnabled = true;
            this.cmbEditAuthor.Location = new System.Drawing.Point(263, 233);
            this.cmbEditAuthor.Name = "cmbEditAuthor";
            this.cmbEditAuthor.Size = new System.Drawing.Size(240, 21);
            this.cmbEditAuthor.TabIndex = 36;
            // 
            // cmbEditCategory
            // 
            this.cmbEditCategory.FormattingEnabled = true;
            this.cmbEditCategory.Location = new System.Drawing.Point(263, 323);
            this.cmbEditCategory.Name = "cmbEditCategory";
            this.cmbEditCategory.Size = new System.Drawing.Size(240, 21);
            this.cmbEditCategory.TabIndex = 37;
            // 
            // cmbEditSubCategory
            // 
            this.cmbEditSubCategory.FormattingEnabled = true;
            this.cmbEditSubCategory.Location = new System.Drawing.Point(263, 351);
            this.cmbEditSubCategory.Name = "cmbEditSubCategory";
            this.cmbEditSubCategory.Size = new System.Drawing.Size(240, 21);
            this.cmbEditSubCategory.TabIndex = 38;
            // 
            // txtEditYear
            // 
            this.txtEditYear.Location = new System.Drawing.Point(263, 378);
            this.txtEditYear.Name = "txtEditYear";
            this.txtEditYear.Size = new System.Drawing.Size(240, 20);
            this.txtEditYear.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Year Published:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(136, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 41;
            this.label10.Text = "Shelf:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(136, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 18);
            this.label11.TabIndex = 43;
            this.label11.Text = "Row:";
            // 
            // cmbEditPublisher
            // 
            this.cmbEditPublisher.FormattingEnabled = true;
            this.cmbEditPublisher.Location = new System.Drawing.Point(263, 264);
            this.cmbEditPublisher.Name = "cmbEditPublisher";
            this.cmbEditPublisher.Size = new System.Drawing.Size(240, 21);
            this.cmbEditPublisher.TabIndex = 45;
            // 
            // cmbEditShelf
            // 
            this.cmbEditShelf.FormattingEnabled = true;
            this.cmbEditShelf.Location = new System.Drawing.Point(263, 407);
            this.cmbEditShelf.Name = "cmbEditShelf";
            this.cmbEditShelf.Size = new System.Drawing.Size(240, 21);
            this.cmbEditShelf.TabIndex = 46;
            // 
            // cmbEditRow
            // 
            this.cmbEditRow.FormattingEnabled = true;
            this.cmbEditRow.Location = new System.Drawing.Point(263, 435);
            this.cmbEditRow.Name = "cmbEditRow";
            this.cmbEditRow.Size = new System.Drawing.Size(240, 21);
            this.cmbEditRow.TabIndex = 47;
            // 
            // btnEditConfigure
            // 
            this.btnEditConfigure.BackColor = System.Drawing.Color.Lime;
            this.btnEditConfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditConfigure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditConfigure.Location = new System.Drawing.Point(529, 612);
            this.btnEditConfigure.Name = "btnEditConfigure";
            this.btnEditConfigure.Size = new System.Drawing.Size(95, 35);
            this.btnEditConfigure.TabIndex = 48;
            this.btnEditConfigure.Text = "Configure";
            this.btnEditConfigure.UseVisualStyleBackColor = false;
            this.btnEditConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // txtEditSearch
            // 
            this.txtEditSearch.Location = new System.Drawing.Point(263, 117);
            this.txtEditSearch.Name = "txtEditSearch";
            this.txtEditSearch.Size = new System.Drawing.Size(240, 20);
            this.txtEditSearch.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(136, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 49;
            this.label12.Text = "Search: ";
            // 
            // btnEditSearch
            // 
            this.btnEditSearch.BackColor = System.Drawing.Color.Yellow;
            this.btnEditSearch.FlatAppearance.BorderSize = 0;
            this.btnEditSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSearch.ForeColor = System.Drawing.Color.Black;
            this.btnEditSearch.Location = new System.Drawing.Point(518, 115);
            this.btnEditSearch.Name = "btnEditSearch";
            this.btnEditSearch.Size = new System.Drawing.Size(83, 23);
            this.btnEditSearch.TabIndex = 51;
            this.btnEditSearch.Text = "Find";
            this.btnEditSearch.UseVisualStyleBackColor = false;
            this.btnEditSearch.Click += new System.EventHandler(this.btnEditSearch_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.btnEditSearch);
            this.Controls.Add(this.txtEditSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEditConfigure);
            this.Controls.Add(this.cmbEditRow);
            this.Controls.Add(this.cmbEditShelf);
            this.Controls.Add(this.cmbEditPublisher);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEditYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEditSubCategory);
            this.Controls.Add(this.cmbEditCategory);
            this.Controls.Add(this.cmbEditAuthor);
            this.Controls.Add(this.txtEditTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditDelete);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnEditAdd);
            this.Controls.Add(this.txtEditQuantity);
            this.Controls.Add(this.txtEditBookCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditDelete;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.TextBox txtEditQuantity;
        private System.Windows.Forms.TextBox txtEditBookCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.TextBox txtEditTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEditAuthor;
        private System.Windows.Forms.ComboBox cmbEditCategory;
        private System.Windows.Forms.ComboBox cmbEditSubCategory;
        private System.Windows.Forms.TextBox txtEditYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEditPublisher;
        private System.Windows.Forms.ComboBox cmbEditShelf;
        private System.Windows.Forms.ComboBox cmbEditRow;
        private System.Windows.Forms.Button btnEditConfigure;
        private System.Windows.Forms.TextBox txtEditSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEditSearch;
    }
}