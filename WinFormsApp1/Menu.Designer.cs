namespace WinFormsApp1
{
    partial class Menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnAccountDetails = new System.Windows.Forms.Button();
            this.btnAccountStatement = new System.Windows.Forms.Button();
            this.btnFund = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(796, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Winform Bank";
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(796, 326);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(300, 34);
            this.btnOpenAccount.TabIndex = 2;
            this.btnOpenAccount.Text = "Open Acoount";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(796, 399);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(300, 34);
            this.btnBalance.TabIndex = 3;
            this.btnBalance.Text = "Check Account Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(796, 478);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(300, 34);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Make Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(796, 551);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(300, 34);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "Make withdrawal";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnAccountDetails
            // 
            this.btnAccountDetails.Location = new System.Drawing.Point(796, 622);
            this.btnAccountDetails.Name = "btnAccountDetails";
            this.btnAccountDetails.Size = new System.Drawing.Size(300, 34);
            this.btnAccountDetails.TabIndex = 6;
            this.btnAccountDetails.Text = "Account Details";
            this.btnAccountDetails.UseVisualStyleBackColor = true;
            this.btnAccountDetails.Click += new System.EventHandler(this.btnAccountDetails_Click);
            // 
            // btnAccountStatement
            // 
            this.btnAccountStatement.Location = new System.Drawing.Point(796, 690);
            this.btnAccountStatement.Name = "btnAccountStatement";
            this.btnAccountStatement.Size = new System.Drawing.Size(300, 34);
            this.btnAccountStatement.TabIndex = 7;
            this.btnAccountStatement.Text = "Account Statement";
            this.btnAccountStatement.UseVisualStyleBackColor = true;
            this.btnAccountStatement.Click += new System.EventHandler(this.btnAccountStatement_Click);
            // 
            // btnFund
            // 
            this.btnFund.Location = new System.Drawing.Point(796, 760);
            this.btnFund.Name = "btnFund";
            this.btnFund.Size = new System.Drawing.Size(300, 34);
            this.btnFund.TabIndex = 8;
            this.btnFund.Text = "Transfer Fund";
            this.btnFund.UseVisualStyleBackColor = true;
            this.btnFund.Click += new System.EventHandler(this.btnFund_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.Location = new System.Drawing.Point(796, 826);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(300, 34);
            this.btnSignout.TabIndex = 9;
            this.btnSignout.Text = "Signout";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.txtSignout_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(709, 199);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 25);
            this.name.TabIndex = 12;
            this.name.Text = "label3";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.btnFund);
            this.Controls.Add(this.btnAccountStatement);
            this.Controls.Add(this.btnAccountDetails);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.label2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnAccountDetails;
        private System.Windows.Forms.Button btnAccountStatement;
        private System.Windows.Forms.Button btnFund;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Label name;
    }
}