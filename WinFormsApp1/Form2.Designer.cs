namespace WinFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.lblInvalidPassword = new System.Windows.Forms.Label();
            this.lblInvalidCredential = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(222, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to Account";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(222, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter email";
            this.txtEmail.Size = new System.Drawing.Size(313, 31);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(222, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter password";
            this.txtPassword.Size = new System.Drawing.Size(313, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(309, 351);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.ForeColor = System.Drawing.Color.Blue;
            this.lblRegister.Location = new System.Drawing.Point(427, 319);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(75, 25);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "Register";
            this.lblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegister_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dont have an account?";
            // 
            // lblInvalidEmail
            // 
            this.lblInvalidEmail.AutoSize = true;
            this.lblInvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidEmail.Location = new System.Drawing.Point(222, 182);
            this.lblInvalidEmail.Name = "lblInvalidEmail";
            this.lblInvalidEmail.Size = new System.Drawing.Size(178, 25);
            this.lblInvalidEmail.TabIndex = 7;
            this.lblInvalidEmail.Text = "Invalid email address";
            this.lblInvalidEmail.Visible = false;
            // 
            // lblInvalidPassword
            // 
            this.lblInvalidPassword.AutoSize = true;
            this.lblInvalidPassword.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPassword.Location = new System.Drawing.Point(228, 258);
            this.lblInvalidPassword.Name = "lblInvalidPassword";
            this.lblInvalidPassword.Size = new System.Drawing.Size(135, 25);
            this.lblInvalidPassword.TabIndex = 8;
            this.lblInvalidPassword.Text = "Invalid passwor";
            this.lblInvalidPassword.Visible = false;
            // 
            // lblInvalidCredential
            // 
            this.lblInvalidCredential.AutoSize = true;
            this.lblInvalidCredential.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInvalidCredential.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInvalidCredential.ForeColor = System.Drawing.Color.White;
            this.lblInvalidCredential.Location = new System.Drawing.Point(222, 100);
            this.lblInvalidCredential.Name = "lblInvalidCredential";
            this.lblInvalidCredential.Padding = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.lblInvalidCredential.Size = new System.Drawing.Size(311, 48);
            this.lblInvalidCredential.TabIndex = 10;
            this.lblInvalidCredential.Text = "Invalid login credentitials";
            this.lblInvalidCredential.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lblInvalidCredential);
            this.Controls.Add(this.lblInvalidPassword);
            this.Controls.Add(this.lblInvalidEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInvalidEmail;
        private System.Windows.Forms.Label lblInvalidPassword;
        private System.Windows.Forms.Label lblInvalidCredential;
    }
}