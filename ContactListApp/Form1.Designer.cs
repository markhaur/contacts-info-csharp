namespace ContactListApp
{
    partial class mainForm
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
            this.lstFirtName = new System.Windows.Forms.ListBox();
            this.lstLastName = new System.Windows.Forms.ListBox();
            this.lstPhoneNumber = new System.Windows.Forms.ListBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTextLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblTextFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblTextPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radLastName = new System.Windows.Forms.RadioButton();
            this.radFirstName = new System.Windows.Forms.RadioButton();
            this.radPhoneNumber = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblActiveEntries = new System.Windows.Forms.Label();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFirtName
            // 
            this.lstFirtName.FormattingEnabled = true;
            this.lstFirtName.ItemHeight = 16;
            this.lstFirtName.Location = new System.Drawing.Point(242, 38);
            this.lstFirtName.Name = "lstFirtName";
            this.lstFirtName.Size = new System.Drawing.Size(224, 260);
            this.lstFirtName.TabIndex = 0;
            this.lstFirtName.SelectedIndexChanged += new System.EventHandler(this.lstFirtName_SelectedIndexChanged);
            this.lstFirtName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstFirtName_MouseDown);
            // 
            // lstLastName
            // 
            this.lstLastName.FormattingEnabled = true;
            this.lstLastName.ItemHeight = 16;
            this.lstLastName.Location = new System.Drawing.Point(472, 38);
            this.lstLastName.Name = "lstLastName";
            this.lstLastName.Size = new System.Drawing.Size(224, 260);
            this.lstLastName.TabIndex = 1;
            this.lstLastName.SelectedIndexChanged += new System.EventHandler(this.lstLastName_SelectedIndexChanged);
            this.lstLastName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstLastName_MouseDown);
            // 
            // lstPhoneNumber
            // 
            this.lstPhoneNumber.FormattingEnabled = true;
            this.lstPhoneNumber.ItemHeight = 16;
            this.lstPhoneNumber.Location = new System.Drawing.Point(12, 38);
            this.lstPhoneNumber.Name = "lstPhoneNumber";
            this.lstPhoneNumber.Size = new System.Drawing.Size(224, 260);
            this.lstPhoneNumber.TabIndex = 2;
            this.lstPhoneNumber.SelectedIndexChanged += new System.EventHandler(this.lstPhoneNumber_SelectedIndexChanged);
            this.lstPhoneNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstPhoneNumber_MouseDown);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(239, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(469, 13);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 13);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(712, 99);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(195, 35);
            this.btnLoadFile.TabIndex = 6;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(712, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(712, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(712, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(195, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(712, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblTextLastName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblTextFirstName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblTextPhoneNumber);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 94);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Contact";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(700, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTextLastName
            // 
            this.lblTextLastName.AutoSize = true;
            this.lblTextLastName.Location = new System.Drawing.Point(457, 43);
            this.lblTextLastName.Name = "lblTextLastName";
            this.lblTextLastName.Size = new System.Drawing.Size(76, 17);
            this.lblTextLastName.TabIndex = 5;
            this.lblTextLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(456, 66);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(218, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // lblTextFirstName
            // 
            this.lblTextFirstName.AutoSize = true;
            this.lblTextFirstName.Location = new System.Drawing.Point(227, 43);
            this.lblTextFirstName.Name = "lblTextFirstName";
            this.lblTextFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblTextFirstName.TabIndex = 3;
            this.lblTextFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(226, 66);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(228, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblTextPhoneNumber
            // 
            this.lblTextPhoneNumber.AutoSize = true;
            this.lblTextPhoneNumber.Location = new System.Drawing.Point(7, 43);
            this.lblTextPhoneNumber.Name = "lblTextPhoneNumber";
            this.lblTextPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblTextPhoneNumber.TabIndex = 1;
            this.lblTextPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(6, 66);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(218, 22);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.radLastName);
            this.grpSearch.Controls.Add(this.radFirstName);
            this.grpSearch.Controls.Add(this.radPhoneNumber);
            this.grpSearch.Location = new System.Drawing.Point(13, 437);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(453, 117);
            this.grpSearch.TabIndex = 12;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Contact Info";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(229, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(218, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(229, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // radLastName
            // 
            this.radLastName.AutoSize = true;
            this.radLastName.Location = new System.Drawing.Point(9, 76);
            this.radLastName.Name = "radLastName";
            this.radLastName.Size = new System.Drawing.Size(97, 21);
            this.radLastName.TabIndex = 2;
            this.radLastName.TabStop = true;
            this.radLastName.Text = "Last Name";
            this.radLastName.UseVisualStyleBackColor = true;
            // 
            // radFirstName
            // 
            this.radFirstName.AutoSize = true;
            this.radFirstName.Location = new System.Drawing.Point(9, 49);
            this.radFirstName.Name = "radFirstName";
            this.radFirstName.Size = new System.Drawing.Size(97, 21);
            this.radFirstName.TabIndex = 1;
            this.radFirstName.TabStop = true;
            this.radFirstName.Text = "First Name";
            this.radFirstName.UseVisualStyleBackColor = true;
            // 
            // radPhoneNumber
            // 
            this.radPhoneNumber.AutoSize = true;
            this.radPhoneNumber.Location = new System.Drawing.Point(9, 22);
            this.radPhoneNumber.Name = "radPhoneNumber";
            this.radPhoneNumber.Size = new System.Drawing.Size(124, 21);
            this.radPhoneNumber.TabIndex = 0;
            this.radPhoneNumber.TabStop = true;
            this.radPhoneNumber.Text = "Phone Number";
            this.radPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // lblActiveEntries
            // 
            this.lblActiveEntries.AutoSize = true;
            this.lblActiveEntries.Location = new System.Drawing.Point(712, 38);
            this.lblActiveEntries.Name = "lblActiveEntries";
            this.lblActiveEntries.Size = new System.Drawing.Size(114, 17);
            this.lblActiveEntries.TabIndex = 13;
            this.lblActiveEntries.Text = "Active Entries : 0";
            // 
            // picDelete
            // 
            this.picDelete.ImageLocation = "https://cdn3.iconfinder.com/data/icons/social-messaging-ui-color-line/254000/82-5" +
    "12.png";
            this.picDelete.Location = new System.Drawing.Point(807, 626);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(100, 50);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 14;
            this.picDelete.TabStop = false;
            this.picDelete.DragDrop += new System.Windows.Forms.DragEventHandler(this.picDelete_DragDrop);
            this.picDelete.DragEnter += new System.Windows.Forms.DragEventHandler(this.picDelete_DragEnter);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 688);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.lblActiveEntries);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lstPhoneNumber);
            this.Controls.Add(this.lstLastName);
            this.Controls.Add(this.lstFirtName);
            this.Name = "mainForm";
            this.Text = "30014914";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFirtName;
        private System.Windows.Forms.ListBox lstLastName;
        private System.Windows.Forms.ListBox lstPhoneNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblTextPhoneNumber;
        private System.Windows.Forms.Label lblTextFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblTextLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radPhoneNumber;
        private System.Windows.Forms.RadioButton radFirstName;
        private System.Windows.Forms.RadioButton radLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblActiveEntries;
        private System.Windows.Forms.PictureBox picDelete;
    }
}

