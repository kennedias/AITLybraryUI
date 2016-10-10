namespace AITLibrary
{
    partial class UserMaintenanceForm
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
            this.groupBoxStudentSearch = new System.Windows.Forms.GroupBox();
            this.buttonListAllUsers = new System.Windows.Forms.Button();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.textBoxNameForSearch = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.groupBoxUserMaintenance = new System.Windows.Forms.GroupBox();
            this.comboBoxUserLevel = new System.Windows.Forms.ComboBox();
            this.labelUserLevel = new System.Windows.Forms.Label();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioInsert = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUsers)).BeginInit();
            this.groupBoxStudentSearch.SuspendLayout();
            this.groupBoxUserMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListUsers
            // 
            this.dataGridViewListUsers.AllowUserToAddRows = false;
            this.dataGridViewListUsers.AllowUserToDeleteRows = false;
            this.dataGridViewListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListUsers.Location = new System.Drawing.Point(281, 50);
            this.dataGridViewListUsers.MultiSelect = false;
            this.dataGridViewListUsers.Name = "dataGridViewListUsers";
            this.dataGridViewListUsers.ReadOnly = true;
            this.dataGridViewListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListUsers.Size = new System.Drawing.Size(597, 397);
            this.dataGridViewListUsers.TabIndex = 15;
            this.dataGridViewListUsers.Click += new System.EventHandler(this.dataGridViewListUsers_Click);
            // 
            // groupBoxStudentSearch
            // 
            this.groupBoxStudentSearch.Controls.Add(this.buttonListAllUsers);
            this.groupBoxStudentSearch.Controls.Add(this.buttonSearchStudent);
            this.groupBoxStudentSearch.Controls.Add(this.textBoxNameForSearch);
            this.groupBoxStudentSearch.Controls.Add(this.labelStudentName);
            this.groupBoxStudentSearch.Location = new System.Drawing.Point(11, 44);
            this.groupBoxStudentSearch.Name = "groupBoxStudentSearch";
            this.groupBoxStudentSearch.Size = new System.Drawing.Size(244, 134);
            this.groupBoxStudentSearch.TabIndex = 14;
            this.groupBoxStudentSearch.TabStop = false;
            this.groupBoxStudentSearch.Text = "Student Search";
            // 
            // buttonListAllUsers
            // 
            this.buttonListAllUsers.Location = new System.Drawing.Point(134, 102);
            this.buttonListAllUsers.Name = "buttonListAllUsers";
            this.buttonListAllUsers.Size = new System.Drawing.Size(102, 23);
            this.buttonListAllUsers.TabIndex = 15;
            this.buttonListAllUsers.Text = "List All Users";
            this.buttonListAllUsers.UseVisualStyleBackColor = true;
            this.buttonListAllUsers.Click += new System.EventHandler(this.buttonListAllUsers_Click);
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.Location = new System.Drawing.Point(134, 62);
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.Size = new System.Drawing.Size(102, 23);
            this.buttonSearchStudent.TabIndex = 14;
            this.buttonSearchStudent.Text = "Search";
            this.buttonSearchStudent.UseVisualStyleBackColor = true;
            this.buttonSearchStudent.Click += new System.EventHandler(this.buttonSearchStudent_Click);
            // 
            // textBoxNameForSearch
            // 
            this.textBoxNameForSearch.Location = new System.Drawing.Point(100, 19);
            this.textBoxNameForSearch.Name = "textBoxNameForSearch";
            this.textBoxNameForSearch.Size = new System.Drawing.Size(136, 20);
            this.textBoxNameForSearch.TabIndex = 12;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(64, 22);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(35, 13);
            this.labelStudentName.TabIndex = 9;
            this.labelStudentName.Text = "Name";
            // 
            // groupBoxUserMaintenance
            // 
            this.groupBoxUserMaintenance.Controls.Add(this.comboBoxUserLevel);
            this.groupBoxUserMaintenance.Controls.Add(this.labelUserLevel);
            this.groupBoxUserMaintenance.Controls.Add(this.radioDelete);
            this.groupBoxUserMaintenance.Controls.Add(this.radioUpdate);
            this.groupBoxUserMaintenance.Controls.Add(this.radioInsert);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxName);
            this.groupBoxUserMaintenance.Controls.Add(this.labelName);
            this.groupBoxUserMaintenance.Controls.Add(this.buttonExecute);
            this.groupBoxUserMaintenance.Location = new System.Drawing.Point(11, 203);
            this.groupBoxUserMaintenance.Name = "groupBoxUserMaintenance";
            this.groupBoxUserMaintenance.Size = new System.Drawing.Size(244, 244);
            this.groupBoxUserMaintenance.TabIndex = 16;
            this.groupBoxUserMaintenance.TabStop = false;
            this.groupBoxUserMaintenance.Text = "User Maintenance ";
            // 
            // comboBoxUserLevel
            // 
            this.comboBoxUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserLevel.FormattingEnabled = true;
            this.comboBoxUserLevel.Location = new System.Drawing.Point(105, 76);
            this.comboBoxUserLevel.Name = "comboBoxUserLevel";
            this.comboBoxUserLevel.Size = new System.Drawing.Size(131, 21);
            this.comboBoxUserLevel.TabIndex = 18;
            // 
            // labelUserLevel
            // 
            this.labelUserLevel.AutoSize = true;
            this.labelUserLevel.Location = new System.Drawing.Point(42, 81);
            this.labelUserLevel.Name = "labelUserLevel";
            this.labelUserLevel.Size = new System.Drawing.Size(58, 13);
            this.labelUserLevel.TabIndex = 17;
            this.labelUserLevel.Text = "User Level";
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.Location = new System.Drawing.Point(180, 116);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.Size = new System.Drawing.Size(56, 17);
            this.radioDelete.TabIndex = 12;
            this.radioDelete.TabStop = true;
            this.radioDelete.Text = "Delete";
            this.radioDelete.UseVisualStyleBackColor = true;
            // 
            // radioUpdate
            // 
            this.radioUpdate.AutoSize = true;
            this.radioUpdate.Location = new System.Drawing.Point(95, 116);
            this.radioUpdate.Name = "radioUpdate";
            this.radioUpdate.Size = new System.Drawing.Size(60, 17);
            this.radioUpdate.TabIndex = 11;
            this.radioUpdate.TabStop = true;
            this.radioUpdate.Text = "Update";
            this.radioUpdate.UseVisualStyleBackColor = true;
            // 
            // radioInsert
            // 
            this.radioInsert.AutoSize = true;
            this.radioInsert.Location = new System.Drawing.Point(6, 116);
            this.radioInsert.Name = "radioInsert";
            this.radioInsert.Size = new System.Drawing.Size(51, 17);
            this.radioInsert.TabIndex = 10;
            this.radioInsert.TabStop = true;
            this.radioInsert.Text = "Insert";
            this.radioInsert.UseVisualStyleBackColor = true;
            this.radioInsert.CheckedChanged += new System.EventHandler(this.radioInsert_CheckedChanged);
            this.radioInsert.Click += new System.EventHandler(this.radioInsert_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(105, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(64, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(161, 209);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 7;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // UserMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBoxUserMaintenance);
            this.Controls.Add(this.dataGridViewListUsers);
            this.Controls.Add(this.groupBoxStudentSearch);
            this.Name = "UserMaintenanceForm";
            this.Text = "UserMaintenanceForm";
            this.Load += new System.EventHandler(this.UserMaintenanceForm_Load);
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.groupBoxStudentSearch, 0);
            this.Controls.SetChildIndex(this.dataGridViewListUsers, 0);
            this.Controls.SetChildIndex(this.groupBoxUserMaintenance, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUsers)).EndInit();
            this.groupBoxStudentSearch.ResumeLayout(false);
            this.groupBoxStudentSearch.PerformLayout();
            this.groupBoxUserMaintenance.ResumeLayout(false);
            this.groupBoxUserMaintenance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListUsers;
        private System.Windows.Forms.GroupBox groupBoxStudentSearch;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.TextBox textBoxNameForSearch;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.GroupBox groupBoxUserMaintenance;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioInsert;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.ComboBox comboBoxUserLevel;
        private System.Windows.Forms.Label labelUserLevel;
        private System.Windows.Forms.Button buttonListAllUsers;
    }
}