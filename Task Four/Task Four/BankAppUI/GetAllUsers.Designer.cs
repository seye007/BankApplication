
namespace BankAppUI
{
    partial class GetAllUsers
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
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAllUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUsers
            // 
            this.dgUsers.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.fullName,
            this.Email,
            this.Phone,
            this.Age});
            this.dgUsers.Location = new System.Drawing.Point(31, 109);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RowHeadersWidth = 51;
            this.dgUsers.RowTemplate.Height = 29;
            this.dgUsers.Size = new System.Drawing.Size(952, 562);
            this.dgUsers.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Full Name";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.Width = 250;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 250;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // lblAllUsers
            // 
            this.lblAllUsers.AutoSize = true;
            this.lblAllUsers.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllUsers.Location = new System.Drawing.Point(95, 32);
            this.lblAllUsers.Name = "lblAllUsers";
            this.lblAllUsers.Size = new System.Drawing.Size(123, 32);
            this.lblAllUsers.TabIndex = 1;
            this.lblAllUsers.Text = "All Users";
            // 
            // GetAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1028, 723);
            this.Controls.Add(this.lblAllUsers);
            this.Controls.Add(this.dgUsers);
            this.Name = "GetAllUsers";
            this.Text = "GetAllUsers";
            this.Load += new System.EventHandler(this.GetAllUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.Label lblAllUsers;
    }
}