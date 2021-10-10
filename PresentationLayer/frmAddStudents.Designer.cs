
namespace Group_Project_PRG282.Presentation_Layer
{
    partial class frmAddStudents
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
            this.lblAddStudents = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.picStudentUpload = new System.Windows.Forms.PictureBox();
            this.addStudAddress = new System.Windows.Forms.TextBox();
            this.addStudPhone = new System.Windows.Forms.TextBox();
            this.rdioAddFemale = new System.Windows.Forms.RadioButton();
            this.rdioAddMale = new System.Windows.Forms.RadioButton();
            this.addDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addFullName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModuleDetails = new System.Windows.Forms.GroupBox();
            this.addStudModuleDes = new System.Windows.Forms.TextBox();
            this.addStudModuleName = new System.Windows.Forms.TextBox();
            this.addStudCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentUpload)).BeginInit();
            this.ModuleDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddStudents
            // 
            this.lblAddStudents.AutoSize = true;
            this.lblAddStudents.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudents.Location = new System.Drawing.Point(23, 25);
            this.lblAddStudents.Name = "lblAddStudents";
            this.lblAddStudents.Size = new System.Drawing.Size(277, 47);
            this.lblAddStudents.TabIndex = 7;
            this.lblAddStudents.Text = "ADD STUDENT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUploadPhoto);
            this.groupBox1.Controls.Add(this.picStudentUpload);
            this.groupBox1.Controls.Add(this.addStudAddress);
            this.groupBox1.Controls.Add(this.addStudPhone);
            this.groupBox1.Controls.Add(this.rdioAddFemale);
            this.groupBox1.Controls.Add(this.rdioAddMale);
            this.groupBox1.Controls.Add(this.addDatePicker);
            this.groupBox1.Controls.Add(this.addFullName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(32, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(313, 750);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Student Picture";
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.Location = new System.Drawing.Point(20, 302);
            this.btnUploadPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(269, 34);
            this.btnUploadPhoto.TabIndex = 28;
            this.btnUploadPhoto.Text = "UPLOAD PHOTO";
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // picStudentUpload
            // 
            this.picStudentUpload.Location = new System.Drawing.Point(20, 63);
            this.picStudentUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picStudentUpload.Name = "picStudentUpload";
            this.picStudentUpload.Size = new System.Drawing.Size(269, 230);
            this.picStudentUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudentUpload.TabIndex = 23;
            this.picStudentUpload.TabStop = false;
            // 
            // addStudAddress
            // 
            this.addStudAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addStudAddress.Location = new System.Drawing.Point(20, 700);
            this.addStudAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStudAddress.Name = "addStudAddress";
            this.addStudAddress.Size = new System.Drawing.Size(270, 30);
            this.addStudAddress.TabIndex = 22;
            // 
            // addStudPhone
            // 
            this.addStudPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addStudPhone.Location = new System.Drawing.Point(20, 618);
            this.addStudPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStudPhone.Name = "addStudPhone";
            this.addStudPhone.Size = new System.Drawing.Size(270, 30);
            this.addStudPhone.TabIndex = 21;
            // 
            // rdioAddFemale
            // 
            this.rdioAddFemale.AutoSize = true;
            this.rdioAddFemale.Location = new System.Drawing.Point(170, 542);
            this.rdioAddFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioAddFemale.Name = "rdioAddFemale";
            this.rdioAddFemale.Size = new System.Drawing.Size(85, 24);
            this.rdioAddFemale.TabIndex = 20;
            this.rdioAddFemale.TabStop = true;
            this.rdioAddFemale.Text = "Female";
            this.rdioAddFemale.UseVisualStyleBackColor = true;
            // 
            // rdioAddMale
            // 
            this.rdioAddMale.AutoSize = true;
            this.rdioAddMale.Location = new System.Drawing.Point(42, 542);
            this.rdioAddMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioAddMale.Name = "rdioAddMale";
            this.rdioAddMale.Size = new System.Drawing.Size(66, 24);
            this.rdioAddMale.TabIndex = 19;
            this.rdioAddMale.TabStop = true;
            this.rdioAddMale.Text = "Male";
            this.rdioAddMale.UseVisualStyleBackColor = true;
            // 
            // addDatePicker
            // 
            this.addDatePicker.Location = new System.Drawing.Point(20, 457);
            this.addDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDatePicker.Name = "addDatePicker";
            this.addDatePicker.Size = new System.Drawing.Size(270, 26);
            this.addDatePicker.TabIndex = 18;
            // 
            // addFullName
            // 
            this.addFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addFullName.Location = new System.Drawing.Point(20, 374);
            this.addFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFullName.Name = "addFullName";
            this.addFullName.Size = new System.Drawing.Size(270, 30);
            this.addFullName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 678);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Physical Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(16, 596);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(16, 518);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name";
            // 
            // ModuleDetails
            // 
            this.ModuleDetails.Controls.Add(this.addStudModuleDes);
            this.ModuleDetails.Controls.Add(this.addStudModuleName);
            this.ModuleDetails.Controls.Add(this.addStudCode);
            this.ModuleDetails.Controls.Add(this.label2);
            this.ModuleDetails.Controls.Add(this.label7);
            this.ModuleDetails.Controls.Add(this.label9);
            this.ModuleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ModuleDetails.Location = new System.Drawing.Point(369, 86);
            this.ModuleDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModuleDetails.Name = "ModuleDetails";
            this.ModuleDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModuleDetails.Size = new System.Drawing.Size(313, 282);
            this.ModuleDetails.TabIndex = 23;
            this.ModuleDetails.TabStop = false;
            this.ModuleDetails.Text = "Student Modules";
            // 
            // addStudModuleDes
            // 
            this.addStudModuleDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addStudModuleDes.Location = new System.Drawing.Point(17, 226);
            this.addStudModuleDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStudModuleDes.Name = "addStudModuleDes";
            this.addStudModuleDes.Size = new System.Drawing.Size(270, 30);
            this.addStudModuleDes.TabIndex = 21;
            // 
            // addStudModuleName
            // 
            this.addStudModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addStudModuleName.Location = new System.Drawing.Point(17, 144);
            this.addStudModuleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStudModuleName.Name = "addStudModuleName";
            this.addStudModuleName.Size = new System.Drawing.Size(270, 30);
            this.addStudModuleName.TabIndex = 16;
            // 
            // addStudCode
            // 
            this.addStudCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addStudCode.Location = new System.Drawing.Point(17, 63);
            this.addStudCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStudCode.Name = "addStudCode";
            this.addStudCode.Size = new System.Drawing.Size(270, 30);
            this.addStudCode.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Module Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Module Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(12, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Module Code";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(369, 386);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(313, 43);
            this.btnAddStudent.TabIndex = 24;
            this.btnAddStudent.Text = "ADD STUDENT";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(369, 438);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(313, 43);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "CLEAR ALL";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(369, 494);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(313, 43);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "BACK TO MAIN";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(369, 550);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(313, 43);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(718, 844);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.ModuleDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddStudents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddStudents";
            this.Text = "frmAddStudents";
            this.Load += new System.EventHandler(this.frmAddStudents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentUpload)).EndInit();
            this.ModuleDetails.ResumeLayout(false);
            this.ModuleDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addStudAddress;
        private System.Windows.Forms.TextBox addStudPhone;
        private System.Windows.Forms.RadioButton rdioAddFemale;
        private System.Windows.Forms.RadioButton rdioAddMale;
        private System.Windows.Forms.DateTimePicker addDatePicker;
        private System.Windows.Forms.TextBox addFullName;
        private System.Windows.Forms.GroupBox ModuleDetails;
        private System.Windows.Forms.TextBox addStudModuleDes;
        private System.Windows.Forms.TextBox addStudModuleName;
        private System.Windows.Forms.TextBox addStudCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.PictureBox picStudentUpload;
    }
}