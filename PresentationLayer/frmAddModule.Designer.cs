
namespace Group_Project_PRG282.PresentationLayer
{
    partial class frmAddModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddModule));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModuleDescription = new System.Windows.Forms.TextBox();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.txtModuleID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddStudents = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.redCross = new System.Windows.Forms.PictureBox();
            this.greenTick = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTick)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.greenTick);
            this.groupBox1.Controls.Add(this.redCross);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtModuleDescription);
            this.groupBox1.Controls.Add(this.txtModuleName);
            this.groupBox1.Controls.Add(this.txtModuleID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(27, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 400);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Details";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLink.Location = new System.Drawing.Point(15, 340);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(302, 35);
            this.txtLink.TabIndex = 24;
            this.txtLink.TextChanged += new System.EventHandler(this.txtLink_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Module Link";
            // 
            // txtModuleDescription
            // 
            this.txtModuleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModuleDescription.Location = new System.Drawing.Point(15, 249);
            this.txtModuleDescription.Name = "txtModuleDescription";
            this.txtModuleDescription.Size = new System.Drawing.Size(302, 35);
            this.txtModuleDescription.TabIndex = 22;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModuleName.Location = new System.Drawing.Point(15, 146);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(302, 35);
            this.txtModuleName.TabIndex = 21;
            // 
            // txtModuleID
            // 
            this.txtModuleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModuleID.Location = new System.Drawing.Point(15, 55);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(302, 35);
            this.txtModuleID.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(10, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Module Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(10, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Module Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Module ID";
            // 
            // lblAddStudents
            // 
            this.lblAddStudents.AutoSize = true;
            this.lblAddStudents.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudents.Location = new System.Drawing.Point(16, 14);
            this.lblAddStudents.Name = "lblAddStudents";
            this.lblAddStudents.Size = new System.Drawing.Size(335, 56);
            this.lblAddStudents.TabIndex = 9;
            this.lblAddStudents.Text = "ADD MODULE";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 522);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Module";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(146, 522);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 522);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // redCross
            // 
            this.redCross.Image = ((System.Drawing.Image)(resources.GetObject("redCross.Image")));
            this.redCross.Location = new System.Drawing.Point(323, 340);
            this.redCross.Name = "redCross";
            this.redCross.Size = new System.Drawing.Size(35, 35);
            this.redCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redCross.TabIndex = 25;
            this.redCross.TabStop = false;
            // 
            // greenTick
            // 
            this.greenTick.Image = ((System.Drawing.Image)(resources.GetObject("greenTick.Image")));
            this.greenTick.Location = new System.Drawing.Point(323, 340);
            this.greenTick.Name = "greenTick";
            this.greenTick.Size = new System.Drawing.Size(35, 35);
            this.greenTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenTick.TabIndex = 26;
            this.greenTick.TabStop = false;
            this.greenTick.Visible = false;
            // 
            // frmAddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 666);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddModule";
            this.Load += new System.EventHandler(this.frmAddModule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModuleDescription;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.TextBox txtModuleID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox greenTick;
        private System.Windows.Forms.PictureBox redCross;
    }
}