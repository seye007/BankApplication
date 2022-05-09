namespace WinFormsApp1
{
    partial class Transfer
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
            this.lblsender = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblreciever = new System.Windows.Forms.Label();
            this.txtSenderAccountNo = new System.Windows.Forms.TextBox();
            this.txtRecieverAccNo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenu2 = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Label();
            this.lblTransactionStatus = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsender
            // 
            this.lblsender.AutoSize = true;
            this.lblsender.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsender.Location = new System.Drawing.Point(679, 321);
            this.lblsender.Name = "lblsender";
            this.lblsender.Size = new System.Drawing.Size(361, 38);
            this.lblsender.TabIndex = 8;
            this.lblsender.Text = "Enter your account number:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(679, 391);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(190, 38);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Enter amount:";
            // 
            // lblreciever
            // 
            this.lblreciever.AutoSize = true;
            this.lblreciever.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblreciever.Location = new System.Drawing.Point(679, 459);
            this.lblreciever.Name = "lblreciever";
            this.lblreciever.Size = new System.Drawing.Size(431, 38);
            this.lblreciever.TabIndex = 15;
            this.lblreciever.Text = "Enter recipient\'s account number:";
            // 
            // txtSenderAccountNo
            // 
            this.txtSenderAccountNo.Location = new System.Drawing.Point(1166, 328);
            this.txtSenderAccountNo.Name = "txtSenderAccountNo";
            this.txtSenderAccountNo.Size = new System.Drawing.Size(150, 31);
            this.txtSenderAccountNo.TabIndex = 16;
            // 
            // txtRecieverAccNo
            // 
            this.txtRecieverAccNo.Location = new System.Drawing.Point(1166, 466);
            this.txtRecieverAccNo.Name = "txtRecieverAccNo";
            this.txtRecieverAccNo.Size = new System.Drawing.Size(150, 31);
            this.txtRecieverAccNo.TabIndex = 17;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1166, 398);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 31);
            this.txtAmount.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(822, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 54);
            this.label2.TabIndex = 19;
            this.label2.Text = "Winform Bank";
            // 
            // btnMenu2
            // 
            this.btnMenu2.AutoSize = true;
            this.btnMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.btnMenu2.ForeColor = System.Drawing.Color.White;
            this.btnMenu2.Location = new System.Drawing.Point(739, 542);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMenu2.Size = new System.Drawing.Size(77, 25);
            this.btnMenu2.TabIndex = 20;
            this.btnMenu2.Text = "Menu";
            this.btnMenu2.Click += new System.EventHandler(this.lblMenu2_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.AutoSize = true;
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(862, 542);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnProceed.Size = new System.Drawing.Size(96, 25);
            this.btnProceed.TabIndex = 21;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblTransactionStatus
            // 
            this.lblTransactionStatus.AutoSize = true;
            this.lblTransactionStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransactionStatus.ForeColor = System.Drawing.Color.Green;
            this.lblTransactionStatus.Location = new System.Drawing.Point(696, 255);
            this.lblTransactionStatus.Name = "lblTransactionStatus";
            this.lblTransactionStatus.Size = new System.Drawing.Size(249, 38);
            this.lblTransactionStatus.TabIndex = 22;
            this.lblTransactionStatus.Text = "Transfer successful";
            this.lblTransactionStatus.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(739, 334);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMenu.Size = new System.Drawing.Size(77, 25);
            this.btnMenu.TabIndex = 23;
            this.btnMenu.Text = "Menu";
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.AccessibleName = "btnTransfer";
            this.btnTransfer.AutoSize = true;
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(862, 334);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTransfer.Size = new System.Drawing.Size(93, 25);
            this.btnTransfer.TabIndex = 24;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Visible = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblTransactionStatus);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnMenu2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRecieverAccNo);
            this.Controls.Add(this.txtSenderAccountNo);
            this.Controls.Add(this.lblreciever);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblsender);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsender;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblreciever;
        private System.Windows.Forms.TextBox txtSenderAccountNo;
        private System.Windows.Forms.TextBox txtRecieverAccNo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnMenu2;
        private System.Windows.Forms.Label btnProceed;
        private System.Windows.Forms.Label lblTransactionStatus;
        private System.Windows.Forms.Label btnMenu;
        private System.Windows.Forms.Label btnTransfer;
    }
}