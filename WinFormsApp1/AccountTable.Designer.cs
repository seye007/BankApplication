namespace WinFormsApp1
{
    partial class AccountTable
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
            this.tbAccounts = new System.Windows.Forms.DataGridView();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTransaction = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblTotalDeposit = new System.Windows.Forms.Label();
            this.lblTotalWithdrawal = new System.Windows.Forms.Label();
            this.lblAvailableBalance = new System.Windows.Forms.Label();
            this.lblAccountSummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAccounts
            // 
            this.tbAccounts.AccessibleName = "";
            this.tbAccounts.BackgroundColor = System.Drawing.Color.White;
            this.tbAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tbAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNumber,
            this.accountName,
            this.accountNumber,
            this.accountType,
            this.accountBalance});
            this.tbAccounts.Location = new System.Drawing.Point(548, 470);
            this.tbAccounts.Name = "tbAccounts";
            this.tbAccounts.RowHeadersWidth = 5;
            this.tbAccounts.RowTemplate.Height = 33;
            this.tbAccounts.Size = new System.Drawing.Size(908, 294);
            this.tbAccounts.TabIndex = 2;
            // 
            // serialNumber
            // 
            this.serialNumber.HeaderText = "S/N";
            this.serialNumber.MinimumWidth = 8;
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Width = 150;
            // 
            // accountName
            // 
            this.accountName.HeaderText = "Account Name";
            this.accountName.MinimumWidth = 8;
            this.accountName.Name = "accountName";
            this.accountName.Width = 150;
            // 
            // accountNumber
            // 
            this.accountNumber.HeaderText = "Account Number";
            this.accountNumber.MinimumWidth = 8;
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Width = 150;
            // 
            // accountType
            // 
            this.accountType.HeaderText = "Account Type";
            this.accountType.MinimumWidth = 8;
            this.accountType.Name = "accountType";
            this.accountType.Width = 150;
            // 
            // accountBalance
            // 
            this.accountBalance.HeaderText = "Balance";
            this.accountBalance.MinimumWidth = 8;
            this.accountBalance.Name = "accountBalance";
            this.accountBalance.Width = 150;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(925, 925);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMenu.Size = new System.Drawing.Size(77, 25);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(811, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 54);
            this.label2.TabIndex = 13;
            this.label2.Text = "Winform Bank";
            // 
            // tbTransaction
            // 
            this.tbTransaction.AccessibleName = "";
            this.tbTransaction.AllowUserToAddRows = false;
            this.tbTransaction.AllowUserToDeleteRows = false;
            this.tbTransaction.AllowUserToResizeColumns = false;
            this.tbTransaction.AllowUserToResizeRows = false;
            this.tbTransaction.BackgroundColor = System.Drawing.Color.White;
            this.tbTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tbTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbTransaction.Location = new System.Drawing.Point(548, 470);
            this.tbTransaction.Name = "tbTransaction";
            this.tbTransaction.RowHeadersWidth = 5;
            this.tbTransaction.RowTemplate.Height = 33;
            this.tbTransaction.Size = new System.Drawing.Size(1009, 294);
            this.tbTransaction.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Transaction Date";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Transaction Details";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Withdrawal";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Deposits";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccountNumber.Location = new System.Drawing.Point(991, 191);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(258, 32);
            this.lblAccountNumber.TabIndex = 15;
            this.lblAccountNumber.Text = "Enter Account Number";
            this.lblAccountNumber.Visible = false;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(1255, 195);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(163, 31);
            this.txtAccountNumber.TabIndex = 16;
            this.txtAccountNumber.Visible = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(1424, 195);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 34);
            this.btnEnter.TabIndex = 18;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblTotalDeposit
            // 
            this.lblTotalDeposit.AutoSize = true;
            this.lblTotalDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeposit.Location = new System.Drawing.Point(548, 349);
            this.lblTotalDeposit.Name = "lblTotalDeposit";
            this.lblTotalDeposit.Size = new System.Drawing.Size(78, 32);
            this.lblTotalDeposit.TabIndex = 19;
            this.lblTotalDeposit.Text = "label1";
            this.lblTotalDeposit.Visible = false;
            // 
            // lblTotalWithdrawal
            // 
            this.lblTotalWithdrawal.AutoSize = true;
            this.lblTotalWithdrawal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalWithdrawal.Location = new System.Drawing.Point(548, 389);
            this.lblTotalWithdrawal.Name = "lblTotalWithdrawal";
            this.lblTotalWithdrawal.Size = new System.Drawing.Size(78, 32);
            this.lblTotalWithdrawal.TabIndex = 20;
            this.lblTotalWithdrawal.Text = "label3";
            this.lblTotalWithdrawal.Visible = false;
            // 
            // lblAvailableBalance
            // 
            this.lblAvailableBalance.AutoSize = true;
            this.lblAvailableBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableBalance.Location = new System.Drawing.Point(548, 424);
            this.lblAvailableBalance.Name = "lblAvailableBalance";
            this.lblAvailableBalance.Size = new System.Drawing.Size(78, 32);
            this.lblAvailableBalance.TabIndex = 21;
            this.lblAvailableBalance.Text = "label4";
            this.lblAvailableBalance.Visible = false;
            // 
            // lblAccountSummary
            // 
            this.lblAccountSummary.AutoSize = true;
            this.lblAccountSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.lblAccountSummary.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccountSummary.ForeColor = System.Drawing.Color.White;
            this.lblAccountSummary.Location = new System.Drawing.Point(548, 282);
            this.lblAccountSummary.Name = "lblAccountSummary";
            this.lblAccountSummary.Padding = new System.Windows.Forms.Padding(10);
            this.lblAccountSummary.Size = new System.Drawing.Size(263, 58);
            this.lblAccountSummary.TabIndex = 22;
            this.lblAccountSummary.Text = "Account Summary";
            this.lblAccountSummary.Visible = false;
            // 
            // AccountTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lblAccountSummary);
            this.Controls.Add(this.lblAvailableBalance);
            this.Controls.Add(this.lblTotalWithdrawal);
            this.Controls.Add(this.lblTotalDeposit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.tbTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.tbAccounts);
            this.Name = "AccountTable";
            this.Text = "AccountTable";
            this.Load += new System.EventHandler(this.AccountTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tbAccounts;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tbTransaction;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountBalance;
        private System.Windows.Forms.Label lblTotalDeposit;
        private System.Windows.Forms.Label lblTotalWithdrawal;
        private System.Windows.Forms.Label lblAvailableBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblAccountSummary;
    }
}