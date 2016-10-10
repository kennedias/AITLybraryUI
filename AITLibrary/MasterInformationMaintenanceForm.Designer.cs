namespace AITLibrary
{
    partial class MasterInformationMaintenanceForm
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
            this.comboBoxMasterInformation = new System.Windows.Forms.ComboBox();
            this.labelSelectInformation = new System.Windows.Forms.Label();
            this.dataGridViewMasterInformation = new System.Windows.Forms.DataGridView();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxInformationMaintenance = new System.Windows.Forms.GroupBox();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioInsert = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasterInformation)).BeginInit();
            this.groupBoxInformationMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMasterInformation
            // 
            this.comboBoxMasterInformation.DisplayMember = "Author";
            this.comboBoxMasterInformation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMasterInformation.FormattingEnabled = true;
            this.comboBoxMasterInformation.Items.AddRange(new object[] {
            "Author",
            "Category",
            "Language"});
            this.comboBoxMasterInformation.Location = new System.Drawing.Point(130, 54);
            this.comboBoxMasterInformation.Name = "comboBoxMasterInformation";
            this.comboBoxMasterInformation.Size = new System.Drawing.Size(229, 21);
            this.comboBoxMasterInformation.TabIndex = 2;
            this.comboBoxMasterInformation.SelectedIndexChanged += new System.EventHandler(this.comboBoxMasterInformation_SelectedIndexChanged);
            // 
            // labelSelectInformation
            // 
            this.labelSelectInformation.AutoSize = true;
            this.labelSelectInformation.Location = new System.Drawing.Point(15, 57);
            this.labelSelectInformation.Name = "labelSelectInformation";
            this.labelSelectInformation.Size = new System.Drawing.Size(109, 13);
            this.labelSelectInformation.TabIndex = 3;
            this.labelSelectInformation.Text = "Select the information";
            // 
            // dataGridViewMasterInformation
            // 
            this.dataGridViewMasterInformation.AllowUserToAddRows = false;
            this.dataGridViewMasterInformation.AllowUserToDeleteRows = false;
            this.dataGridViewMasterInformation.AllowUserToOrderColumns = true;
            this.dataGridViewMasterInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasterInformation.Location = new System.Drawing.Point(18, 126);
            this.dataGridViewMasterInformation.MultiSelect = false;
            this.dataGridViewMasterInformation.Name = "dataGridViewMasterInformation";
            this.dataGridViewMasterInformation.ReadOnly = true;
            this.dataGridViewMasterInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMasterInformation.Size = new System.Drawing.Size(192, 194);
            this.dataGridViewMasterInformation.TabIndex = 5;
            this.dataGridViewMasterInformation.Click += new System.EventHandler(this.dataGridViewMasterInformation_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(204, 139);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 7;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // groupBoxInformationMaintenance
            // 
            this.groupBoxInformationMaintenance.Controls.Add(this.radioDelete);
            this.groupBoxInformationMaintenance.Controls.Add(this.radioUpdate);
            this.groupBoxInformationMaintenance.Controls.Add(this.radioInsert);
            this.groupBoxInformationMaintenance.Controls.Add(this.textBoxName);
            this.groupBoxInformationMaintenance.Controls.Add(this.labelName);
            this.groupBoxInformationMaintenance.Controls.Add(this.buttonExecute);
            this.groupBoxInformationMaintenance.Location = new System.Drawing.Point(234, 119);
            this.groupBoxInformationMaintenance.Name = "groupBoxInformationMaintenance";
            this.groupBoxInformationMaintenance.Size = new System.Drawing.Size(297, 201);
            this.groupBoxInformationMaintenance.TabIndex = 8;
            this.groupBoxInformationMaintenance.TabStop = false;
            this.groupBoxInformationMaintenance.Text = "Information  Maintenance ";
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.Location = new System.Drawing.Point(223, 88);
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
            this.radioUpdate.Location = new System.Drawing.Point(138, 88);
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
            this.radioInsert.Location = new System.Drawing.Point(49, 88);
            this.radioInsert.Name = "radioInsert";
            this.radioInsert.Size = new System.Drawing.Size(51, 17);
            this.radioInsert.TabIndex = 10;
            this.radioInsert.TabStop = true;
            this.radioInsert.Text = "Insert";
            this.radioInsert.UseVisualStyleBackColor = true;
            this.radioInsert.Click += new System.EventHandler(this.radioInsert_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(49, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // MasterInformationMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBoxInformationMaintenance);
            this.Controls.Add(this.dataGridViewMasterInformation);
            this.Controls.Add(this.labelSelectInformation);
            this.Controls.Add(this.comboBoxMasterInformation);
            this.Name = "MasterInformationMaintenanceForm";
            this.Text = "MasterInformationMaintenanceForm";
            this.Load += new System.EventHandler(this.MasterInformationMaintenanceForm_Load);
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.comboBoxMasterInformation, 0);
            this.Controls.SetChildIndex(this.labelSelectInformation, 0);
            this.Controls.SetChildIndex(this.dataGridViewMasterInformation, 0);
            this.Controls.SetChildIndex(this.groupBoxInformationMaintenance, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasterInformation)).EndInit();
            this.groupBoxInformationMaintenance.ResumeLayout(false);
            this.groupBoxInformationMaintenance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectInformation;
        private System.Windows.Forms.DataGridView dataGridViewMasterInformation;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.GroupBox groupBoxInformationMaintenance;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioInsert;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxMasterInformation;

    }
}