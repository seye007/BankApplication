
namespace BankAppUI
{
    partial class UserRole
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
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAddUserRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserId.Location = new System.Drawing.Point(125, 138);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(81, 25);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "UserId";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserId.Location = new System.Drawing.Point(268, 136);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(267, 34);
            this.txtUserId.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(125, 198);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(57, 25);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(268, 195);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(267, 30);
            this.cmbRole.TabIndex = 3;
            // 
            // btnAddUserRole
            // 
            this.btnAddUserRole.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddUserRole.Location = new System.Drawing.Point(405, 297);
            this.btnAddUserRole.Name = "btnAddUserRole";
            this.btnAddUserRole.Size = new System.Drawing.Size(130, 41);
            this.btnAddUserRole.TabIndex = 4;
            this.btnAddUserRole.Text = "ADD";
            this.btnAddUserRole.UseVisualStyleBackColor = false;
            this.btnAddUserRole.Click += new System.EventHandler(this.btnAddUserRole_Click);
            // 
            // UserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddUserRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Name = "UserRole";
            this.Text = "UserRole";
            this.Load += new System.EventHandler(this.UserRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAddUserRole;
    }
}