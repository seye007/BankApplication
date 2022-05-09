
namespace BankAppUI
{
    partial class Admin
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblAdminDashbaord = new System.Windows.Forms.Label();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.btnGetAUser = new System.Windows.Forms.Button();
            this.btnGetAllTransactions = new System.Windows.Forms.Button();
            this.btnAddUserRole = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(39, 170);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(227, 52);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblAdminDashbaord
            // 
            this.lblAdminDashbaord.AutoSize = true;
            this.lblAdminDashbaord.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdminDashbaord.Location = new System.Drawing.Point(71, 40);
            this.lblAdminDashbaord.Name = "lblAdminDashbaord";
            this.lblAdminDashbaord.Size = new System.Drawing.Size(474, 35);
            this.lblAdminDashbaord.TabIndex = 1;
            this.lblAdminDashbaord.Text = "ADMINISTRATOR DASHBOARD";
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAllUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllUsers.Location = new System.Drawing.Point(299, 170);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(246, 52);
            this.btnAllUsers.TabIndex = 2;
            this.btnAllUsers.Text = "Get All Users";
            this.btnAllUsers.UseVisualStyleBackColor = false;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // btnGetAUser
            // 
            this.btnGetAUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetAUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetAUser.Location = new System.Drawing.Point(39, 298);
            this.btnGetAUser.Name = "btnGetAUser";
            this.btnGetAUser.Size = new System.Drawing.Size(227, 52);
            this.btnGetAUser.TabIndex = 3;
            this.btnGetAUser.Text = "Get A User";
            this.btnGetAUser.UseVisualStyleBackColor = false;
            // 
            // btnGetAllTransactions
            // 
            this.btnGetAllTransactions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetAllTransactions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetAllTransactions.Location = new System.Drawing.Point(39, 424);
            this.btnGetAllTransactions.Name = "btnGetAllTransactions";
            this.btnGetAllTransactions.Size = new System.Drawing.Size(227, 52);
            this.btnGetAllTransactions.TabIndex = 4;
            this.btnGetAllTransactions.Text = "Get All Transactions";
            this.btnGetAllTransactions.UseVisualStyleBackColor = false;
            // 
            // btnAddUserRole
            // 
            this.btnAddUserRole.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddUserRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUserRole.Location = new System.Drawing.Point(299, 298);
            this.btnAddUserRole.Name = "btnAddUserRole";
            this.btnAddUserRole.Size = new System.Drawing.Size(246, 52);
            this.btnAddUserRole.TabIndex = 5;
            this.btnAddUserRole.Text = "Add User to Role";
            this.btnAddUserRole.UseVisualStyleBackColor = false;
            this.btnAddUserRole.Click += new System.EventHandler(this.btnAddUserRole_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(299, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(927, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddUserRole);
            this.Controls.Add(this.btnGetAllTransactions);
            this.Controls.Add(this.btnGetAUser);
            this.Controls.Add(this.btnAllUsers);
            this.Controls.Add(this.lblAdminDashbaord);
            this.Controls.Add(this.btnAddUser);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblAdminDashbaord;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.Button btnGetAUser;
        private System.Windows.Forms.Button btnGetAllTransactions;
        private System.Windows.Forms.Button btnAddUserRole;
        private System.Windows.Forms.Button button1;
    }
}