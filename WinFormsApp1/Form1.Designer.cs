namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfPassword = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(222, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Enter firstname";
            this.txtFirstName.Size = new System.Drawing.Size(313, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(222, 172);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Enter lastname";
            this.txtLastName.Size = new System.Drawing.Size(313, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(222, 248);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter email";
            this.txtEmail.Size = new System.Drawing.Size(313, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(222, 319);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter password";
            this.txtPassword.Size = new System.Drawing.Size(313, 31);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfPassword
            // 
            this.txtConfPassword.Location = new System.Drawing.Point(222, 390);
            this.txtConfPassword.Name = "txtConfPassword";
            this.txtConfPassword.PlaceholderText = "Confirm Password";
            this.txtConfPassword.Size = new System.Drawing.Size(313, 31);
            this.txtConfPassword.TabIndex = 5;
            this.txtConfPassword.UseSystemPasswordChar = true;
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(309, 500);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(112, 34);
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.Red;
            this.lblFirstName.Location = new System.Drawing.Point(222, 123);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(193, 21);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "Name must be letters only";
            this.lblFirstName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.Red;
            this.lblLastName.Location = new System.Drawing.Point(222, 206);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(222, 21);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last name must be letters only";
            this.lblLastName.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(222, 282);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(188, 21);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Enter a valid email format";
            this.lblEmail.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(222, 353);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(166, 21);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Enter a valid password";
            this.lblPassword.Visible = false;
            // 
            // lblConfPassword
            // 
            this.lblConfPassword.AutoSize = true;
            this.lblConfPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfPassword.ForeColor = System.Drawing.Color.Red;
            this.lblConfPassword.Location = new System.Drawing.Point(224, 424);
            this.lblConfPassword.Name = "lblConfPassword";
            this.lblConfPassword.Size = new System.Drawing.Size(163, 21);
            this.lblConfPassword.TabIndex = 11;
            this.lblConfPassword.Text = "password must match";
            this.lblConfPassword.Visible = false;
            // 
            // lblLogin
            // 
            this.lblLogin.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(440, 458);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 22);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.TabStop = true;
            this.lblLogin.Text = "Login";
            this.lblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogin_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Do you have an account?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblConfPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtConfPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfPassword;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfPassword;
        private System.Windows.Forms.LinkLabel lblLogin;
        private System.Windows.Forms.Label label2;
    }
}
