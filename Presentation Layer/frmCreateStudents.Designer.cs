namespace Group_Project_PRG282.Presentation_Layer
{
    partial class frmCreateStudents
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
            this.addAddressBox = new System.Windows.Forms.TextBox();
            this.addPhoneBox = new System.Windows.Forms.TextBox();
            this.rdioBtnOther = new System.Windows.Forms.RadioButton();
            this.rdioBtnFemale = new System.Windows.Forms.RadioButton();
            this.rdioBtnMale = new System.Windows.Forms.RadioButton();
            this.addDateBirthBox = new System.Windows.Forms.TextBox();
            this.addFullNameBox = new System.Windows.Forms.TextBox();
            this.addStudNumBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addModuleDesBox = new System.Windows.Forms.TextBox();
            this.addModuleNameBox = new System.Windows.Forms.TextBox();
            this.addModuleCodeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackSystem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(26, 31);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(332, 56);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "ADD STUDENT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addAddressBox);
            this.groupBox1.Controls.Add(this.addPhoneBox);
            this.groupBox1.Controls.Add(this.rdioBtnOther);
            this.groupBox1.Controls.Add(this.rdioBtnFemale);
            this.groupBox1.Controls.Add(this.rdioBtnMale);
            this.groupBox1.Controls.Add(this.addDateBirthBox);
            this.groupBox1.Controls.Add(this.addFullNameBox);
            this.groupBox1.Controls.Add(this.addStudNumBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(36, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 641);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // addAddressBox
            // 
            this.addAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addAddressBox.Location = new System.Drawing.Point(23, 576);
            this.addAddressBox.Name = "addAddressBox";
            this.addAddressBox.Size = new System.Drawing.Size(248, 35);
            this.addAddressBox.TabIndex = 22;
            // 
            // addPhoneBox
            // 
            this.addPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPhoneBox.Location = new System.Drawing.Point(23, 470);
            this.addPhoneBox.Name = "addPhoneBox";
            this.addPhoneBox.Size = new System.Drawing.Size(248, 35);
            this.addPhoneBox.TabIndex = 21;
            // 
            // rdioBtnOther
            // 
            this.rdioBtnOther.AutoSize = true;
            this.rdioBtnOther.Location = new System.Drawing.Point(286, 385);
            this.rdioBtnOther.Name = "rdioBtnOther";
            this.rdioBtnOther.Size = new System.Drawing.Size(86, 29);
            this.rdioBtnOther.TabIndex = 20;
            this.rdioBtnOther.TabStop = true;
            this.rdioBtnOther.Text = "Other";
            this.rdioBtnOther.UseVisualStyleBackColor = true;
            // 
            // rdioBtnFemale
            // 
            this.rdioBtnFemale.AutoSize = true;
            this.rdioBtnFemale.Location = new System.Drawing.Point(141, 385);
            this.rdioBtnFemale.Name = "rdioBtnFemale";
            this.rdioBtnFemale.Size = new System.Drawing.Size(102, 29);
            this.rdioBtnFemale.TabIndex = 19;
            this.rdioBtnFemale.TabStop = true;
            this.rdioBtnFemale.Text = "Female";
            this.rdioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdioBtnMale
            // 
            this.rdioBtnMale.AutoSize = true;
            this.rdioBtnMale.Location = new System.Drawing.Point(23, 385);
            this.rdioBtnMale.Name = "rdioBtnMale";
            this.rdioBtnMale.Size = new System.Drawing.Size(80, 29);
            this.rdioBtnMale.TabIndex = 18;
            this.rdioBtnMale.TabStop = true;
            this.rdioBtnMale.Text = "Male";
            this.rdioBtnMale.UseVisualStyleBackColor = true;
            // 
            // addDateBirthBox
            // 
            this.addDateBirthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addDateBirthBox.Location = new System.Drawing.Point(23, 270);
            this.addDateBirthBox.Name = "addDateBirthBox";
            this.addDateBirthBox.Size = new System.Drawing.Size(248, 35);
            this.addDateBirthBox.TabIndex = 17;
            // 
            // addFullNameBox
            // 
            this.addFullNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addFullNameBox.Location = new System.Drawing.Point(23, 172);
            this.addFullNameBox.Name = "addFullNameBox";
            this.addFullNameBox.Size = new System.Drawing.Size(248, 35);
            this.addFullNameBox.TabIndex = 16;
            // 
            // addStudNumBox
            // 
            this.addStudNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addStudNumBox.Location = new System.Drawing.Point(23, 77);
            this.addStudNumBox.Name = "addStudNumBox";
            this.addStudNumBox.Size = new System.Drawing.Size(248, 35);
            this.addStudNumBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(18, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Physical Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(18, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(18, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(18, 49);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(168, 25);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Student Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addModuleDesBox);
            this.groupBox2.Controls.Add(this.addModuleNameBox);
            this.groupBox2.Controls.Add(this.addModuleCodeBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(469, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 348);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Modules";
            // 
            // addModuleDesBox
            // 
            this.addModuleDesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addModuleDesBox.Location = new System.Drawing.Point(23, 270);
            this.addModuleDesBox.Name = "addModuleDesBox";
            this.addModuleDesBox.Size = new System.Drawing.Size(248, 35);
            this.addModuleDesBox.TabIndex = 17;
            // 
            // addModuleNameBox
            // 
            this.addModuleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addModuleNameBox.Location = new System.Drawing.Point(23, 172);
            this.addModuleNameBox.Name = "addModuleNameBox";
            this.addModuleNameBox.Size = new System.Drawing.Size(248, 35);
            this.addModuleNameBox.TabIndex = 16;
            // 
            // addModuleCodeBox
            // 
            this.addModuleCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addModuleCodeBox.Location = new System.Drawing.Point(23, 77);
            this.addModuleCodeBox.Name = "addModuleCodeBox";
            this.addModuleCodeBox.Size = new System.Drawing.Size(248, 35);
            this.addModuleCodeBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(18, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Module Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Module Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(18, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Module Code";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(469, 491);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(401, 54);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "ADD STUDENT";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(469, 559);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(401, 54);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "CLEAR ALL";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackSystem
            // 
            this.btnBackSystem.Location = new System.Drawing.Point(469, 633);
            this.btnBackSystem.Name = "btnBackSystem";
            this.btnBackSystem.Size = new System.Drawing.Size(401, 54);
            this.btnBackSystem.TabIndex = 26;
            this.btnBackSystem.Text = "BACK TO SYSTEM";
            this.btnBackSystem.UseVisualStyleBackColor = true;
            this.btnBackSystem.Click += new System.EventHandler(this.btnBackSystem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 704);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(401, 54);
            this.button3.TabIndex = 27;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCreateStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 787);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBackSystem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLogin);
            this.Name = "frmCreateStudents";
            this.Text = "frmCreateStudents";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox addAddressBox;
        private System.Windows.Forms.TextBox addPhoneBox;
        private System.Windows.Forms.RadioButton rdioBtnOther;
        private System.Windows.Forms.RadioButton rdioBtnFemale;
        private System.Windows.Forms.RadioButton rdioBtnMale;
        private System.Windows.Forms.TextBox addDateBirthBox;
        private System.Windows.Forms.TextBox addFullNameBox;
        private System.Windows.Forms.TextBox addStudNumBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addModuleDesBox;
        private System.Windows.Forms.TextBox addModuleNameBox;
        private System.Windows.Forms.TextBox addModuleCodeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackSystem;
        private System.Windows.Forms.Button button3;
    }
}