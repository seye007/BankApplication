
namespace BankAppUI
{
    partial class CreateAccount
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
            this.lblInitialAmt = new System.Windows.Forms.Label();
            this.txtInitailAmt = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.rdbSaving = new System.Windows.Forms.RadioButton();
            this.rdbCurrent = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInitialAmt
            // 
            this.lblInitialAmt.AutoSize = true;
            this.lblInitialAmt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInitialAmt.Location = new System.Drawing.Point(150, 136);
            this.lblInitialAmt.Name = "lblInitialAmt";
            this.lblInitialAmt.Size = new System.Drawing.Size(155, 25);
            this.lblInitialAmt.TabIndex = 0;
            this.lblInitialAmt.Text = "Initial Amount";
            // 
            // txtInitailAmt
            // 
            this.txtInitailAmt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInitailAmt.Location = new System.Drawing.Point(366, 134);
            this.txtInitailAmt.Name = "txtInitailAmt";
            this.txtInitailAmt.Size = new System.Drawing.Size(255, 34);
            this.txtInitailAmt.TabIndex = 1;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountType.Location = new System.Drawing.Point(150, 233);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(150, 25);
            this.lblAccountType.TabIndex = 2;
            this.lblAccountType.Text = "Account Type";
            // 
            // rdbSaving
            // 
            this.rdbSaving.AutoSize = true;
            this.rdbSaving.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbSaving.Location = new System.Drawing.Point(366, 235);
            this.rdbSaving.Name = "rdbSaving";
            this.rdbSaving.Size = new System.Drawing.Size(97, 30);
            this.rdbSaving.TabIndex = 3;
            this.rdbSaving.TabStop = true;
            this.rdbSaving.Text = "Saving";
            this.rdbSaving.UseVisualStyleBackColor = true;
            // 
            // rdbCurrent
            // 
            this.rdbCurrent.AutoSize = true;
            this.rdbCurrent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbCurrent.Location = new System.Drawing.Point(503, 235);
            this.rdbCurrent.Name = "rdbCurrent";
            this.rdbCurrent.Size = new System.Drawing.Size(104, 30);
            this.rdbCurrent.TabIndex = 4;
            this.rdbCurrent.TabStop = true;
            this.rdbCurrent.Text = "Current";
            this.rdbCurrent.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(467, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbCurrent);
            this.Controls.Add(this.rdbSaving);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.txtInitailAmt);
            this.Controls.Add(this.lblInitialAmt);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitialAmt;
        private System.Windows.Forms.TextBox txtInitailAmt;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.RadioButton rdbSaving;
        private System.Windows.Forms.RadioButton rdbCurrent;
        private System.Windows.Forms.Button button1;
    }
}