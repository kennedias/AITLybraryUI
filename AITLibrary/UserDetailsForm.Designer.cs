namespace AITLibrary
{
    partial class UserDetailsForm
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
            this.groupBoxUserInformation = new System.Windows.Forms.GroupBox();
            this.comboBoxUserLevel = new System.Windows.Forms.ComboBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonSaveUserModification = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.labelUserLevel = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.groupBoxUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUserInformation
            // 
            this.groupBoxUserInformation.Controls.Add(this.comboBoxUserLevel);
            this.groupBoxUserInformation.Controls.Add(this.textBoxUserName);
            this.groupBoxUserInformation.Controls.Add(this.buttonSaveUserModification);
            this.groupBoxUserInformation.Controls.Add(this.buttonChangePassword);
            this.groupBoxUserInformation.Controls.Add(this.labelUserLevel);
            this.groupBoxUserInformation.Controls.Add(this.labelUserName);
            this.groupBoxUserInformation.Location = new System.Drawing.Point(13, 28);
            this.groupBoxUserInformation.Name = "groupBoxUserInformation";
            this.groupBoxUserInformation.Size = new System.Drawing.Size(572, 222);
            this.groupBoxUserInformation.TabIndex = 1;
            this.groupBoxUserInformation.TabStop = false;
            this.groupBoxUserInformation.Text = "User Information";
            // 
            // comboBoxUserLevel
            // 
            this.comboBoxUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserLevel.FormattingEnabled = true;
            this.comboBoxUserLevel.Location = new System.Drawing.Point(86, 67);
            this.comboBoxUserLevel.Name = "comboBoxUserLevel";
            this.comboBoxUserLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserLevel.TabIndex = 5;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(86, 34);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserName.TabIndex = 4;
            // 
            // buttonSaveUserModification
            // 
            this.buttonSaveUserModification.Location = new System.Drawing.Point(14, 127);
            this.buttonSaveUserModification.Name = "buttonSaveUserModification";
            this.buttonSaveUserModification.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveUserModification.TabIndex = 3;
            this.buttonSaveUserModification.Text = "Save";
            this.buttonSaveUserModification.UseVisualStyleBackColor = true;
            this.buttonSaveUserModification.Click += new System.EventHandler(this.buttonSaveUserModification_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(107, 127);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(116, 23);
            this.buttonChangePassword.TabIndex = 2;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // labelUserLevel
            // 
            this.labelUserLevel.AutoSize = true;
            this.labelUserLevel.Location = new System.Drawing.Point(23, 72);
            this.labelUserLevel.Name = "labelUserLevel";
            this.labelUserLevel.Size = new System.Drawing.Size(61, 13);
            this.labelUserLevel.TabIndex = 1;
            this.labelUserLevel.Text = "User Level:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(21, 38);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(63, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name:";
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBoxUserInformation);
            this.Name = "UserDetailsForm";
            this.Text = "UserDetailsForm";
            this.Load += new System.EventHandler(this.UserDetailsForm_Load);
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.groupBoxUserInformation, 0);
            this.groupBoxUserInformation.ResumeLayout(false);
            this.groupBoxUserInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserInformation;
        private System.Windows.Forms.ComboBox comboBoxUserLevel;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonSaveUserModification;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Label labelUserLevel;
        private System.Windows.Forms.Label labelUserName;
    }
}