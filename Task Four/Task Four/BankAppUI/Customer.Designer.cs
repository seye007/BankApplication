
namespace BankAppUI
{
    partial class Customer
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.lblCustomerWelcome = new System.Windows.Forms.Label();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBalanceAmt = new System.Windows.Forms.Label();
            this.cmbAccountNum = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.rtbBalance = new System.Windows.Forms.RichTextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeposit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.Location = new System.Drawing.Point(81, 242);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(272, 53);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTransfer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.Location = new System.Drawing.Point(83, 398);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(270, 51);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTransactions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransactions.Location = new System.Drawing.Point(83, 470);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(270, 51);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Text = "Account Statement";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // lblCustomerWelcome
            // 
            this.lblCustomerWelcome.AutoSize = true;
            this.lblCustomerWelcome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerWelcome.Location = new System.Drawing.Point(81, 51);
            this.lblCustomerWelcome.Name = "lblCustomerWelcome";
            this.lblCustomerWelcome.Size = new System.Drawing.Size(0, 32);
            this.lblCustomerWelcome.TabIndex = 4;
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccounts.Location = new System.Drawing.Point(562, 193);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(202, 25);
            this.lblAccounts.TabIndex = 5;
            this.lblAccounts.Text = "Account Numbers:";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnter.Location = new System.Drawing.Point(562, 470);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(508, 50);
            this.lblEnter.TabIndex = 6;
            this.lblEnter.Text = "Please Enter the Amount To Deposit or Withdraw\r\n\r\n";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(709, 532);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(361, 33);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(910, 587);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBalanceAmt
            // 
            this.lblBalanceAmt.AutoSize = true;
            this.lblBalanceAmt.Location = new System.Drawing.Point(693, 196);
            this.lblBalanceAmt.Name = "lblBalanceAmt";
            this.lblBalanceAmt.Size = new System.Drawing.Size(0, 20);
            this.lblBalanceAmt.TabIndex = 9;
            // 
            // cmbAccountNum
            // 
            this.cmbAccountNum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbAccountNum.FormattingEnabled = true;
            this.cmbAccountNum.Location = new System.Drawing.Point(771, 185);
            this.cmbAccountNum.Name = "cmbAccountNum";
            this.cmbAccountNum.Size = new System.Drawing.Size(239, 33);
            this.cmbAccountNum.TabIndex = 10;
            this.cmbAccountNum.SelectedIndexChanged += new System.EventHandler(this.cmbAccountNum_SelectedIndexChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(573, 255);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(92, 25);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "Balance";
            this.lblBalance.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateAccount.Location = new System.Drawing.Point(81, 165);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(272, 53);
            this.btnCreateAccount.TabIndex = 13;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // rtbBalance
            // 
            this.rtbBalance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbBalance.Location = new System.Drawing.Point(570, 299);
            this.rtbBalance.Name = "rtbBalance";
            this.rtbBalance.Size = new System.Drawing.Size(441, 81);
            this.rtbBalance.TabIndex = 12;
            this.rtbBalance.Text = "Please Select an Account Number";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWithdraw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.Location = new System.Drawing.Point(81, 317);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(272, 53);
            this.btnWithdraw.TabIndex = 14;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(81, 546);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(270, 51);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LogOut\r\n";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1120, 717);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.rtbBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.cmbAccountNum);
            this.Controls.Add(this.lblBalanceAmt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.lblCustomerWelcome);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnDeposit);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.Click += new System.EventHandler(this.txtAmount_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Label lblCustomerWelcome;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBalanceAmt;
        private System.Windows.Forms.ComboBox cmbAccountNum;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.RichTextBox rtbBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnLogout;
    }
}