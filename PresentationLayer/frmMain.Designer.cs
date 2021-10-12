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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblLogin = new System.Windows.Forms.Label();
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
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.buttonMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.linkSwitch = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbModules = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblLogin.Location = new System.Drawing.Point(24, 125);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(462, 66);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "STUDENT SYSTEM";
            // 
            // lblPhysicalAddress
            // 
            this.lblPhysicalAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPhysicalAddress.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPhysicalAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblPhysicalAddress.Location = new System.Drawing.Point(0, 377);
            this.lblPhysicalAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhysicalAddress.Name = "lblPhysicalAddress";
            this.lblPhysicalAddress.Size = new System.Drawing.Size(494, 120);
            this.lblPhysicalAddress.TabIndex = 15;
            this.lblPhysicalAddress.Text = "\"PhysicalAddress\"";
            this.lblPhysicalAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(2, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Physical Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(250, 291);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(199, 30);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "\"PhoneNumber\"";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblGender.Location = new System.Drawing.Point(250, 234);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(118, 30);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "\"Gender\"";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(4, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 28);
            this.label12.TabIndex = 10;
            this.label12.Text = "Gender";
            // 
            // lblFullNameTop
            // 
            this.lblFullNameTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblFullNameTop.Location = new System.Drawing.Point(32, 271);
            this.lblFullNameTop.Name = "lblFullNameTop";
            this.lblFullNameTop.Size = new System.Drawing.Size(498, 94);
            this.lblFullNameTop.TabIndex = 9;
            this.lblFullNameTop.Text = "\"FullName\"";
            this.lblFullNameTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblDateOfBirth.Location = new System.Drawing.Point(250, 165);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(243, 60);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "\"DateOfBirth\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of Birth";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblFullName.Location = new System.Drawing.Point(250, 92);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(140, 30);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "\"FullName\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name";
            // 
            // lblStudNumber
            // 
            this.lblStudNumber.AutoSize = true;
            this.lblStudNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblStudNumber.Location = new System.Drawing.Point(250, 29);
            this.lblStudNumber.Name = "lblStudNumber";
            this.lblStudNumber.Size = new System.Drawing.Size(213, 30);
            this.lblStudNumber.TabIndex = 3;
            this.lblStudNumber.Text = "\"StudentNumber\"";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(2, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(198, 28);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Student Number";
            // 
            // studentImageBox
            // 
            this.studentImageBox.Location = new System.Drawing.Point(87, 366);
            this.studentImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentImageBox.Name = "studentImageBox";
            this.studentImageBox.Size = new System.Drawing.Size(382, 346);
            this.studentImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentImageBox.TabIndex = 8;
            this.studentImageBox.TabStop = false;
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Location = new System.Drawing.Point(554, 271);
            this.studentDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.ReadOnly = true;
            this.studentDataGrid.RowHeadersWidth = 62;
            this.studentDataGrid.RowTemplate.Height = 28;
            this.studentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGrid.Size = new System.Drawing.Size(1022, 715);
            this.studentDataGrid.TabIndex = 17;
            this.studentDataGrid.SelectionChanged += new System.EventHandler(this.studentDataGrid_SelectionChanged);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMoveLast.FlatAppearance.BorderSize = 2;
            this.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveLast.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnMoveLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMoveLast.Location = new System.Drawing.Point(1408, 1000);
            this.btnMoveLast.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(166, 54);
            this.btnMoveLast.TabIndex = 16;
            this.btnMoveLast.Text = ">>";
            this.btnMoveLast.UseVisualStyleBackColor = false;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // buttonMoveNext
            // 
            this.buttonMoveNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonMoveNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.buttonMoveNext.FlatAppearance.BorderSize = 2;
            this.buttonMoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveNext.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonMoveNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.buttonMoveNext.Location = new System.Drawing.Point(1236, 1000);
            this.buttonMoveNext.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonMoveNext.Name = "buttonMoveNext";
            this.buttonMoveNext.Size = new System.Drawing.Size(166, 54);
            this.buttonMoveNext.TabIndex = 15;
            this.buttonMoveNext.Text = ">";
            this.buttonMoveNext.UseVisualStyleBackColor = false;
            this.buttonMoveNext.Click += new System.EventHandler(this.buttonMoveNext_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnMovePrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMovePrevious.FlatAppearance.BorderSize = 2;
            this.btnMovePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovePrevious.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnMovePrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMovePrevious.Location = new System.Drawing.Point(726, 998);
            this.btnMovePrevious.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(166, 54);
            this.btnMovePrevious.TabIndex = 14;
            this.btnMovePrevious.Text = "<";
            this.btnMovePrevious.UseVisualStyleBackColor = false;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMoveFirst.FlatAppearance.BorderSize = 2;
            this.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveFirst.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnMoveFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMoveFirst.Location = new System.Drawing.Point(554, 998);
            this.btnMoveFirst.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(166, 54);
            this.btnMoveFirst.TabIndex = 13;
            this.btnMoveFirst.Text = "<<";
            this.btnMoveFirst.UseVisualStyleBackColor = false;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1950, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 62);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(1342, 1142);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(232, 54);
            this.btnViewAll.TabIndex = 21;
            this.btnViewAll.Text = "VIEW ALL ";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1083, 1142);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 54);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE STUDENT";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(816, 1142);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(232, 54);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE STUDENT";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(554, 1142);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(232, 54);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "ADD STUDENT";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblWelcome.Location = new System.Drawing.Point(1798, 81);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblWelcome.Size = new System.Drawing.Size(225, 55);
            this.lblWelcome.TabIndex = 16;
            this.lblWelcome.Text = "\"UserWelcome\"";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkSwitch
            // 
            this.linkSwitch.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkSwitch.AutoSize = true;
            this.linkSwitch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.linkSwitch.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSwitch.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.linkSwitch.Location = new System.Drawing.Point(1674, 125);
            this.linkSwitch.Name = "linkSwitch";
            this.linkSwitch.Size = new System.Drawing.Size(141, 28);
            this.linkSwitch.TabIndex = 17;
            this.linkSwitch.TabStop = true;
            this.linkSwitch.Text = "Switch User";
            this.linkSwitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSwitch_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2026, 89);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "BELGIUM CAMPUS";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchBox.Location = new System.Drawing.Point(36, 222);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(302, 35);
            this.searchBox.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(346, 215);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 54);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblPhysicalAddress);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblPhoneNumber);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblFullName);
            this.panel2.Controls.Add(this.lblStudNumber);
            this.panel2.Controls.Add(this.lblDateOfBirth);
            this.panel2.Location = new System.Drawing.Point(36, 718);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 497);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1674, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Welcome";
            // 
            // lbModules
            // 
            this.lbModules.FormattingEnabled = true;
            this.lbModules.ItemHeight = 20;
            this.lbModules.Location = new System.Drawing.Point(1618, 275);
            this.lbModules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbModules.Name = "lbModules";
            this.lbModules.Size = new System.Drawing.Size(290, 704);
            this.lbModules.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(555, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Student Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(1612, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Student Modules";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2026, 1288);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbModules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.studentDataGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnMoveLast);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.buttonMoveNext);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.lblFullNameTop);
            this.Controls.Add(this.btnMovePrevious);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.studentImageBox);
            this.Controls.Add(this.linkSwitch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.studentImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbModules;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}