namespace WinFormsApp1
{
    partial class Form3
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
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(867, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Winform Bank";
            // 
            // btnSavings
            // 
            this.btnSavings.Location = new System.Drawing.Point(867, 289);
            this.btnSavings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Padding = new System.Windows.Forms.Padding(3);
            this.btnSavings.Size = new System.Drawing.Size(300, 34);
            this.btnSavings.TabIndex = 11;
            this.btnSavings.Text = "Open Savings Account";
            this.btnSavings.UseVisualStyleBackColor = true;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(867, 413);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(300, 34);
            this.btnCurrent.TabIndex = 12;
            this.btnCurrent.Text = "Open Current Account";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(777, 219);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(628, 41);
            this.txtName.TabIndex = 13;
            this.txtName.Text = "Congratulations, account successfully created!";
            this.txtName.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1054, 336);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(113, 31);
            this.txtAmount.TabIndex = 15;
            this.txtAmount.Visible = false;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeposit.Location = new System.Drawing.Point(867, 336);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(181, 28);
            this.lblDeposit.TabIndex = 16;
            this.lblDeposit.Text = "Enter initial deposit";
            this.lblDeposit.Visible = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.BtnCreate.ForeColor = System.Drawing.Color.White;
            this.BtnCreate.Location = new System.Drawing.Point(920, 405);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(193, 51);
            this.BtnCreate.TabIndex = 17;
            this.BtnCreate.Text = "Create Account";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Visible = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrent.Location = new System.Drawing.Point(867, 339);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(181, 28);
            this.lblCurrent.TabIndex = 18;
            this.lblCurrent.Text = "Enter initial deposit";
            this.lblCurrent.Visible = false;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccount.Location = new System.Drawing.Point(777, 260);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(78, 32);
            this.lblAccount.TabIndex = 20;
            this.lblAccount.Text = "label1";
            this.lblAccount.Visible = false;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(53)))), ((int)(((byte)(245)))));
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirm.ForeColor = System.Drawing.Color.White;
            this.lblConfirm.Location = new System.Drawing.Point(951, 415);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblConfirm.Size = new System.Drawing.Size(130, 32);
            this.lblConfirm.TabIndex = 21;
            this.lblConfirm.Text = "Confirm";
            this.lblConfirm.Visible = false;
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.btnSavings);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblConfirm;
    }
}