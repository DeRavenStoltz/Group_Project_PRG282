namespace Group_Project_PRG282
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtusernameBoxLogin = new System.Windows.Forms.TextBox();
            this.txtpasswordBoxLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClearLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(235, 244);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.Location = new System.Drawing.Point(121, 85);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtusernameBoxLogin
            // 
            this.txtusernameBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtusernameBoxLogin.Location = new System.Drawing.Point(127, 111);
            this.txtusernameBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusernameBoxLogin.Name = "txtusernameBoxLogin";
            this.txtusernameBoxLogin.Size = new System.Drawing.Size(220, 30);
            this.txtusernameBoxLogin.TabIndex = 2;
            // 
            // txtpasswordBoxLogin
            // 
            this.txtpasswordBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpasswordBoxLogin.Location = new System.Drawing.Point(127, 183);
            this.txtpasswordBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpasswordBoxLogin.Name = "txtpasswordBoxLogin";
            this.txtpasswordBoxLogin.PasswordChar = '*';
            this.txtpasswordBoxLogin.Size = new System.Drawing.Size(220, 30);
            this.txtpasswordBoxLogin.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(121, 158);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(156, 23);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(147, 47);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnClearLogin
            // 
            this.btnClearLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearLogin.Location = new System.Drawing.Point(92, 244);
            this.btnClearLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearLogin.Name = "btnClearLogin";
            this.btnClearLogin.Size = new System.Drawing.Size(137, 36);
            this.btnClearLogin.TabIndex = 6;
            this.btnClearLogin.Text = "CLEAR";
            this.btnClearLogin.UseVisualStyleBackColor = true;
            this.btnClearLogin.Click += new System.EventHandler(this.btnClearLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(81, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Not registered? ";
            // 
            // linkRegister
            // 
            this.linkRegister.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkRegister.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkRegister.Location = new System.Drawing.Point(243, 297);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(123, 20);
            this.linkRegister.TabIndex = 8;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register here";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnClearLogin;
            this.ClientSize = new System.Drawing.Size(476, 338);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtpasswordBoxLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtusernameBoxLogin);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtusernameBoxLogin;
        private System.Windows.Forms.TextBox txtpasswordBoxLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnClearLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkRegister;
    }
}

