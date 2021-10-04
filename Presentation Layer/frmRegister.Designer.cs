namespace Group_Project_PRG282
{
    partial class Register
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
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearLogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLogin
            // 
            this.linkLogin.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLogin.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLogin.Location = new System.Drawing.Point(299, 370);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(114, 25);
            this.linkLogin.TabIndex = 17;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Login here";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(92, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Already registered?";
            // 
            // btnClearLogin
            // 
            this.btnClearLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearLogin.Location = new System.Drawing.Point(102, 304);
            this.btnClearLogin.Name = "btnClearLogin";
            this.btnClearLogin.Size = new System.Drawing.Size(155, 45);
            this.btnClearLogin.TabIndex = 15;
            this.btnClearLogin.Text = "CLEAR";
            this.btnClearLogin.UseVisualStyleBackColor = true;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(148, 23);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(228, 56);
            this.lblRegister.TabIndex = 14;
            this.lblRegister.Text = "REGISTER";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(141, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 35);
            this.textBox2.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(136, 197);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(141, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 35);
            this.textBox1.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.Location = new System.Drawing.Point(136, 106);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(263, 304);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(155, 45);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearLogin;
            this.ClientSize = new System.Drawing.Size(535, 423);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearLogin);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnRegister);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearLogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnRegister;
    }
}