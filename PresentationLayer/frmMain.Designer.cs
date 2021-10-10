using System;

namespace Group_Project_PRG282.Presentation_Layer
{
    partial class frmMain
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPhysicalAddress = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFullNameTop = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudNumber = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.studentImageBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.buttonMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.linkSwitch = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentImageBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(23, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(332, 47);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "STUDENT SYSTEM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPhysicalAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblFullNameTop);
            this.groupBox1.Controls.Add(this.lblDateOfBirth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblStudNumber);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.studentImageBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(32, 198);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(439, 773);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // lblPhysicalAddress
            // 
            this.lblPhysicalAddress.AutoSize = true;
            this.lblPhysicalAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhysicalAddress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPhysicalAddress.Location = new System.Drawing.Point(13, 722);
            this.lblPhysicalAddress.Name = "lblPhysicalAddress";
            this.lblPhysicalAddress.Size = new System.Drawing.Size(146, 20);
            this.lblPhysicalAddress.TabIndex = 15;
            this.lblPhysicalAddress.Text = "\"PhysicalAddress\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(13, 686);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Physical Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(238, 638);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(127, 20);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "\"PhoneNumber\"";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(13, 638);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGender.Location = new System.Drawing.Point(238, 590);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(76, 20);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "\"Gender\"";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(13, 590);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Gender";
            // 
            // lblFullNameTop
            // 
            this.lblFullNameTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFullNameTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFullNameTop.Location = new System.Drawing.Point(3, 21);
            this.lblFullNameTop.Name = "lblFullNameTop";
            this.lblFullNameTop.Size = new System.Drawing.Size(433, 45);
            this.lblFullNameTop.TabIndex = 9;
            this.lblFullNameTop.Text = "\"FullName\"";
            this.lblFullNameTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateOfBirth.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDateOfBirth.Location = new System.Drawing.Point(238, 546);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(111, 20);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "\"DateOfBirth\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of Birth";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFullName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFullName.Location = new System.Drawing.Point(238, 500);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(92, 20);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "\"FullName\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name";
            // 
            // lblStudNumber
            // 
            this.lblStudNumber.AutoSize = true;
            this.lblStudNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStudNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStudNumber.Location = new System.Drawing.Point(238, 452);
            this.lblStudNumber.Name = "lblStudNumber";
            this.lblStudNumber.Size = new System.Drawing.Size(137, 20);
            this.lblStudNumber.TabIndex = 3;
            this.lblStudNumber.Text = "\"StudentNumber\"";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(13, 452);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(144, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Student Number";
            // 
            // studentImageBox
            // 
            this.studentImageBox.Location = new System.Drawing.Point(18, 68);
            this.studentImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentImageBox.Name = "studentImageBox";
            this.studentImageBox.Size = new System.Drawing.Size(400, 360);
            this.studentImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentImageBox.TabIndex = 8;
            this.studentImageBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentDataGrid);
            this.groupBox2.Controls.Add(this.btnMoveLast);
            this.groupBox2.Controls.Add(this.buttonMoveNext);
            this.groupBox2.Controls.Add(this.btnMovePrevious);
            this.groupBox2.Controls.Add(this.btnMoveFirst);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(492, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1249, 742);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students";
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Location = new System.Drawing.Point(20, 34);
            this.studentDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.ReadOnly = true;
            this.studentDataGrid.RowHeadersWidth = 62;
            this.studentDataGrid.RowTemplate.Height = 28;
            this.studentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGrid.Size = new System.Drawing.Size(1207, 617);
            this.studentDataGrid.TabIndex = 17;
            this.studentDataGrid.SelectionChanged += new System.EventHandler(this.studentDataGrid_SelectionChanged);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Location = new System.Drawing.Point(1066, 678);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(148, 43);
            this.btnMoveLast.TabIndex = 16;
            this.btnMoveLast.Text = ">>";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // buttonMoveNext
            // 
            this.buttonMoveNext.Location = new System.Drawing.Point(892, 678);
            this.buttonMoveNext.Name = "buttonMoveNext";
            this.buttonMoveNext.Size = new System.Drawing.Size(148, 43);
            this.buttonMoveNext.TabIndex = 15;
            this.buttonMoveNext.Text = ">";
            this.buttonMoveNext.UseVisualStyleBackColor = true;
            this.buttonMoveNext.Click += new System.EventHandler(this.buttonMoveNext_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Location = new System.Drawing.Point(198, 674);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(148, 43);
            this.btnMovePrevious.TabIndex = 14;
            this.btnMovePrevious.Text = "<";
            this.btnMovePrevious.UseVisualStyleBackColor = true;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Location = new System.Drawing.Point(26, 674);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(148, 43);
            this.btnMoveFirst.TabIndex = 13;
            this.btnMoveFirst.Text = "<<";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnViewAll);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(492, 845);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1249, 126);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // btnExit
            // 

            this.btnExit.Location = new System.Drawing.Point(981, 51);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(206, 43);

            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(752, 51);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(206, 43);
            this.btnViewAll.TabIndex = 21;
            this.btnViewAll.Text = "VIEW ALL STUDENTS";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(522, 51);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 43);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE STUDENT";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(294, 51);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(205, 43);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE STUDENT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(68, 51);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(205, 43);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "ADD STUDENT";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.searchBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(32, 92);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(439, 101);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Student";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(300, 45);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchBox.Location = new System.Drawing.Point(18, 44);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(269, 30);
            this.searchBox.TabIndex = 11;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.lblWelcome.Size = new System.Drawing.Size(1778, 83);
            this.lblWelcome.TabIndex = 16;
            this.lblWelcome.Text = "\"UserWelcome\"";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkSwitch
            // 
            this.linkSwitch.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkSwitch.AutoSize = true;
            this.linkSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkSwitch.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSwitch.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkSwitch.Location = new System.Drawing.Point(1612, 51);
            this.linkSwitch.Name = "linkSwitch";
            this.linkSwitch.Size = new System.Drawing.Size(100, 20);
            this.linkSwitch.TabIndex = 17;
            this.linkSwitch.TabStop = true;
            this.linkSwitch.Text = "Switch User";
            this.linkSwitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSwitch_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;

            this.ClientSize = new System.Drawing.Size(1834, 1055);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.Controls.Add(this.linkSwitch);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentImageBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPhysicalAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFullNameTop;
        private System.Windows.Forms.PictureBox studentImageBox;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudNumber;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button buttonMoveNext;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.LinkLabel linkSwitch;
        private System.Windows.Forms.Button btnExit;
    }
}