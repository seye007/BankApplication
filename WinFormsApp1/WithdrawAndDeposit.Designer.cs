namespace WinFormsApp1
{
    partial class WithdrawAndDeposit
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
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnProceed = new System.Windows.Forms.Label();
            this.btnDepositDepositAgain = new System.Windows.Forms.Label();
            this.lblMenu2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(846, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Winform Bank";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(1088, 299);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(150, 31);
            this.txtAccountNumber.TabIndex = 6;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstruction.Location = new System.Drawing.Point(785, 291);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(297, 38);
            this.lblInstruction.TabIndex = 7;
            this.lblInstruction.Text = "Enter account number:";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetail.Location = new System.Drawing.Point(827, 214);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(466, 45);
            this.lblDetail.TabIndex = 9;
            this.lblDetail.Text = "Account number does not exist";
            this.lblDetail.Visible = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(827, 568);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMenu.Size = new System.Drawing.Size(77, 25);
            this.lblMenu.TabIndex = 11;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Visible = false;
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(785, 344);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(190, 38);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Enter amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1088, 352);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 31);
            this.txtAmount.TabIndex = 14;
            // 
            // btnProceed
            // 
            this.btnProceed.AutoSize = true;
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(952, 568);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnProceed.Size = new System.Drawing.Size(96, 25);
            this.btnProceed.TabIndex = 15;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnDepositDepositAgain
            // 
            this.btnDepositDepositAgain.AutoSize = true;
            this.btnDepositDepositAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.btnDepositDepositAgain.ForeColor = System.Drawing.Color.White;
            this.btnDepositDepositAgain.Location = new System.Drawing.Point(943, 302);
            this.btnDepositDepositAgain.Name = "btnDepositDepositAgain";
            this.btnDepositDepositAgain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDepositDepositAgain.Size = new System.Drawing.Size(142, 25);
            this.btnDepositDepositAgain.TabIndex = 16;
            this.btnDepositDepositAgain.Text = "Make Deposit";
            this.btnDepositDepositAgain.Visible = false;
            this.btnDepositDepositAgain.Click += new System.EventHandler(this.btnDepositAgain_Click);
            // 
            // lblMenu2
            // 
            this.lblMenu2.AutoSize = true;
            this.lblMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.lblMenu2.ForeColor = System.Drawing.Color.White;
            this.lblMenu2.Location = new System.Drawing.Point(846, 302);
            this.lblMenu2.Name = "lblMenu2";
            this.lblMenu2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMenu2.Size = new System.Drawing.Size(77, 25);
            this.lblMenu2.TabIndex = 17;
            this.lblMenu2.Text = "Menu";
            this.lblMenu2.Visible = false;
            this.lblMenu2.Click += new System.EventHandler(this.lblMenu2_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(794, 411);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Enter Transaction Decription";
            this.txtDescription.Size = new System.Drawing.Size(423, 84);
            this.txtDescription.TabIndex = 18;
            // 
            // WithdrawAndDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblMenu2);
            this.Controls.Add(this.btnDepositDepositAgain);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label2);
            this.Name = "WithdrawAndDeposit";
            this.Text = "WithdrawAndDeposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblCheckBalance;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label btnProceed;
        private System.Windows.Forms.Label lblMakeDeposit;
        private System.Windows.Forms.Label btnDepositDepositAgain;
        private System.Windows.Forms.Label lblMenu2;
        private System.Windows.Forms.TextBox txtDescription;
    }
}