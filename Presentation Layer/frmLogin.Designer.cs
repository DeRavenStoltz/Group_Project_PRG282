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
            this.usernameBoxLogin = new System.Windows.Forms.TextBox();
            this.passwordBoxLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClearLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(264, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 45);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.Location = new System.Drawing.Point(137, 106);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // usernameBoxLogin
            // 
            this.usernameBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameBoxLogin.Location = new System.Drawing.Point(142, 138);
            this.usernameBoxLogin.Name = "usernameBoxLogin";
            this.usernameBoxLogin.Size = new System.Drawing.Size(247, 35);
            this.usernameBoxLogin.TabIndex = 2;
            // 
            // passwordBoxLogin
            // 
            this.passwordBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordBoxLogin.Location = new System.Drawing.Point(142, 229);
            this.passwordBoxLogin.Name = "passwordBoxLogin";
            this.passwordBoxLogin.Size = new System.Drawing.Size(247, 35);
            this.passwordBoxLogin.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(137, 197);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(176, 29);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(174, 56);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnClearLogin
            // 
            this.btnClearLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearLogin.Location = new System.Drawing.Point(103, 304);
            this.btnClearLogin.Name = "btnClearLogin";
            this.btnClearLogin.Size = new System.Drawing.Size(155, 45);
            this.btnClearLogin.TabIndex = 6;
            this.btnClearLogin.Text = "CLEAR";
            this.btnClearLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(92, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
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
            this.linkRegister.Location = new System.Drawing.Point(273, 371);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(140, 25);
            this.linkRegister.TabIndex = 8;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register here";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnClearLogin;
            this.ClientSize = new System.Drawing.Size(535, 423);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.passwordBoxLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.usernameBoxLogin);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.KeyPreview = true;
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
        private System.Windows.Forms.TextBox usernameBoxLogin;
        private System.Windows.Forms.TextBox passwordBoxLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnClearLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkRegister;
    }
}

