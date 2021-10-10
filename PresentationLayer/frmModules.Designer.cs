
namespace Group_Project_PRG282.PresentationLayer
{
    partial class frmModules
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
            this.linkSwitch = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtsearchBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.buttonMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblModuleDescription = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkSwitch
            // 
            this.linkSwitch.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkSwitch.AutoSize = true;
            this.linkSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkSwitch.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSwitch.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkSwitch.Location = new System.Drawing.Point(1285, -24);
            this.linkSwitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkSwitch.Name = "linkSwitch";
            this.linkSwitch.Size = new System.Drawing.Size(82, 17);
            this.linkSwitch.TabIndex = 24;
            this.linkSwitch.TabStop = true;
            this.linkSwitch.Text = "Switch User";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.txtsearchBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(11, 78);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Size = new System.Drawing.Size(329, 82);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Module";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(225, 36);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtsearchBox
            // 
            this.txtsearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsearchBox.Location = new System.Drawing.Point(13, 36);
            this.txtsearchBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtsearchBox.Name = "txtsearchBox";
            this.txtsearchBox.Size = new System.Drawing.Size(203, 26);
            this.txtsearchBox.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnViewAll);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(356, 689);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(937, 103);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(736, 42);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 35);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(564, 42);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(155, 35);
            this.btnViewAll.TabIndex = 21;
            this.btnViewAll.Text = "VIEW ALL MODULES";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(391, 42);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 35);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE MODULE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(221, 42);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 35);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE MODULE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(51, 42);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(154, 35);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "ADD MODULE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.VisibleChanged += new System.EventHandler(this.btnCreate_VisibleChanged);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvModules);
            this.groupBox2.Controls.Add(this.btnMoveLast);
            this.groupBox2.Controls.Add(this.buttonMoveNext);
            this.groupBox2.Controls.Add(this.btnMovePrevious);
            this.groupBox2.Controls.Add(this.btnMoveFirst);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(356, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(937, 603);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modules";
            // 
            // dgvModules
            // 
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(15, 27);
            this.dgvModules.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.ReadOnly = true;
            this.dgvModules.RowHeadersWidth = 62;
            this.dgvModules.RowTemplate.Height = 28;
            this.dgvModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModules.Size = new System.Drawing.Size(905, 501);
            this.dgvModules.TabIndex = 17;
            this.dgvModules.SelectionChanged += new System.EventHandler(this.dgvModules_SelectionChanged);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Location = new System.Drawing.Point(799, 551);
            this.btnMoveLast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(111, 35);
            this.btnMoveLast.TabIndex = 16;
            this.btnMoveLast.Text = ">>";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // buttonMoveNext
            // 
            this.buttonMoveNext.Location = new System.Drawing.Point(669, 551);
            this.buttonMoveNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonMoveNext.Name = "buttonMoveNext";
            this.buttonMoveNext.Size = new System.Drawing.Size(111, 35);
            this.buttonMoveNext.TabIndex = 15;
            this.buttonMoveNext.Text = ">";
            this.buttonMoveNext.UseVisualStyleBackColor = true;
            this.buttonMoveNext.Click += new System.EventHandler(this.buttonMoveNext_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Location = new System.Drawing.Point(149, 547);
            this.btnMovePrevious.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(111, 35);
            this.btnMovePrevious.TabIndex = 14;
            this.btnMovePrevious.Text = "<";
            this.btnMovePrevious.UseVisualStyleBackColor = true;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Location = new System.Drawing.Point(19, 547);
            this.btnMoveFirst.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(111, 35);
            this.btnMoveFirst.TabIndex = 13;
            this.btnMoveFirst.Text = "<<";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblModuleDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblModuleName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblModuleCode);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(11, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(329, 150);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Details";
            // 
            // lblModuleDescription
            // 
            this.lblModuleDescription.AutoSize = true;
            this.lblModuleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblModuleDescription.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblModuleDescription.Location = new System.Drawing.Point(179, 109);
            this.lblModuleDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleDescription.Name = "lblModuleDescription";
            this.lblModuleDescription.Size = new System.Drawing.Size(135, 17);
            this.lblModuleDescription.TabIndex = 7;
            this.lblModuleDescription.Text = "\"ModuleDescription\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Module Description";
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblModuleName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblModuleName.Location = new System.Drawing.Point(179, 71);
            this.lblModuleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(101, 17);
            this.lblModuleName.TabIndex = 5;
            this.lblModuleName.Text = "\"ModuleName\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Module Name";
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblModuleCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblModuleCode.Location = new System.Drawing.Point(179, 32);
            this.lblModuleCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(97, 17);
            this.lblModuleCode.TabIndex = 3;
            this.lblModuleCode.Text = "\"ModuleCode\"";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(10, 32);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Module Code";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(93, -46);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(265, 38);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "STUDENT SYSTEM";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcome.Location = new System.Drawing.Point(76, -66);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblWelcome.Size = new System.Drawing.Size(1333, 68);
            this.lblWelcome.TabIndex = 23;
            this.lblWelcome.Text = "\"UserWelcome\"";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcomeUser.Location = new System.Drawing.Point(8, 9);
            this.lblWelcomeUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblWelcomeUser.Size = new System.Drawing.Size(1285, 68);
            this.lblWelcomeUser.TabIndex = 25;
            this.lblWelcomeUser.Text = "\"UserWelcome\"";
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "MODULE SYSTEM";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(1170, 50);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 17);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Switch User";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 804);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcomeUser);
            this.Controls.Add(this.linkSwitch);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmModules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModules";
            this.Load += new System.EventHandler(this.frmModules_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkSwitch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsearchBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button buttonMoveNext;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblModuleDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}