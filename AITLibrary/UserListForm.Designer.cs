namespace AITLibrary
{
    partial class UserListForm
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
            this.dataGridViewListUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListUsers
            // 
            this.dataGridViewListUsers.AllowUserToAddRows = false;
            this.dataGridViewListUsers.AllowUserToDeleteRows = false;
            this.dataGridViewListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListUsers.Location = new System.Drawing.Point(13, 50);
            this.dataGridViewListUsers.MultiSelect = false;
            this.dataGridViewListUsers.Name = "dataGridViewListUsers";
            this.dataGridViewListUsers.ReadOnly = true;
            this.dataGridViewListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListUsers.Size = new System.Drawing.Size(250, 508);
            this.dataGridViewListUsers.TabIndex = 0;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dataGridViewListUsers);
            this.Name = "UserListForm";
            this.Text = "User List";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.Controls.SetChildIndex(this.dataGridViewListUsers, 0);
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListUsers;
    }
}