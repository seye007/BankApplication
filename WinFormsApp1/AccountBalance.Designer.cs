namespace WinFormsApp1
{
    partial class AccountBalance
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblCheckBalance = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblEnterAccNo = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(831, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Winform Bank";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(1059, 293);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(150, 31);
            this.txtAccountNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(746, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter account number:";
            // 
            // lblCheckBalance
            // 
            this.lblCheckBalance.AutoSize = true;
            this.lblCheckBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.lblCheckBalance.ForeColor = System.Drawing.Color.White;
            this.lblCheckBalance.Location = new System.Drawing.Point(920, 385);
            this.lblCheckBalance.Name = "lblCheckBalance";
            this.lblCheckBalance.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblCheckBalance.Size = new System.Drawing.Size(143, 25);
            this.lblCheckBalance.TabIndex = 7;
            this.lblCheckBalance.Text = "Check Balance";
            this.lblCheckBalance.Click += new System.EventHandler(this.lblCheckBalance_Click);
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetail.Location = new System.Drawing.Point(743, 285);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(466, 45);
            this.lblDetail.TabIndex = 8;
            this.lblDetail.Text = "Account number does not exist";
            this.lblDetail.Visible = false;
            // 
            // lblEnterAccNo
            // 
            this.lblEnterAccNo.AutoSize = true;
            this.lblEnterAccNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.lblEnterAccNo.ForeColor = System.Drawing.Color.White;
            this.lblEnterAccNo.Location = new System.Drawing.Point(920, 385);
            this.lblEnterAccNo.Name = "lblEnterAccNo";
            this.lblEnterAccNo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblEnterAccNo.Size = new System.Drawing.Size(212, 25);
            this.lblEnterAccNo.TabIndex = 9;
            this.lblEnterAccNo.Text = "Enter Account Number";
            this.lblEnterAccNo.Visible = false;
            this.lblEnterAccNo.Click += new System.EventHandler(this.lblEnterAccNo_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(810, 385);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMenu.Size = new System.Drawing.Size(77, 25);
            this.lblMenu.TabIndex = 10;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Visible = false;
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // AccountBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblEnterAccNo);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblCheckBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label2);
            this.Name = "AccountBalance";
            this.Text = "AccountBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCheckBalance;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblEnterAccNo;
        private System.Windows.Forms.Label lblMenu;
    }
}