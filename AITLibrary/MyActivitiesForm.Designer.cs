namespace AITLibrary
{
    partial class MyActivitiesForm
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
            this.groupBoxMyBooksActivity = new System.Windows.Forms.GroupBox();
            this.radioButtonReserved = new System.Windows.Forms.RadioButton();
            this.radioButtonBorrowed = new System.Windows.Forms.RadioButton();
            this.dataGridViewUserBookActivity = new System.Windows.Forms.DataGridView();

            this.groupBoxMyBooksActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserBookActivity)).BeginInit();
            this.SuspendLayout();

            // 
            // groupBoxMyBooksActivity
            // 
            this.groupBoxMyBooksActivity.Controls.Add(this.radioButtonReserved);
            this.groupBoxMyBooksActivity.Controls.Add(this.radioButtonBorrowed);
            this.groupBoxMyBooksActivity.Location = new System.Drawing.Point(12, 28);
            this.groupBoxMyBooksActivity.Name = "groupBoxMyBooksActivity";
            this.groupBoxMyBooksActivity.Size = new System.Drawing.Size(254, 39);
            this.groupBoxMyBooksActivity.TabIndex = 3;
            this.groupBoxMyBooksActivity.TabStop = false;
            this.groupBoxMyBooksActivity.Text = "My Books Activity";
            // 
            // radioButtonReserved
            // 
            this.radioButtonReserved.AutoSize = true;
            this.radioButtonReserved.Location = new System.Drawing.Point(168, 16);
            this.radioButtonReserved.Name = "radioButtonReserved";
            this.radioButtonReserved.Size = new System.Drawing.Size(71, 17);
            this.radioButtonReserved.TabIndex = 1;
            this.radioButtonReserved.TabStop = true;
            this.radioButtonReserved.Text = "Reserved";
            this.radioButtonReserved.UseVisualStyleBackColor = true;
            this.radioButtonReserved.CheckedChanged += new System.EventHandler(this.radioButtonReserved_CheckedChanged);
            // 
            // radioButtonBorrowed
            // 
            this.radioButtonBorrowed.AutoSize = true;
            this.radioButtonBorrowed.Location = new System.Drawing.Point(7, 16);
            this.radioButtonBorrowed.Name = "radioButtonBorrowed";
            this.radioButtonBorrowed.Size = new System.Drawing.Size(70, 17);
            this.radioButtonBorrowed.TabIndex = 0;
            this.radioButtonBorrowed.TabStop = true;
            this.radioButtonBorrowed.Text = "Borrowed";
            this.radioButtonBorrowed.UseVisualStyleBackColor = true;
            this.radioButtonBorrowed.CheckedChanged += new System.EventHandler(this.radioButtonBorrowed_CheckedChanged);
            // 
            // dataGridViewUserBookActivity
            // 
            this.dataGridViewUserBookActivity.AllowUserToAddRows = false;
            this.dataGridViewUserBookActivity.AllowUserToDeleteRows = false;
            this.dataGridViewUserBookActivity.AllowUserToOrderColumns = true;
            this.dataGridViewUserBookActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserBookActivity.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewUserBookActivity.Name = "dataGridViewUserBookActivity";
            this.dataGridViewUserBookActivity.ReadOnly = true;
            this.dataGridViewUserBookActivity.Size = new System.Drawing.Size(960, 475);
            this.dataGridViewUserBookActivity.TabIndex = 4;
            // 
            // MyActivitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dataGridViewUserBookActivity);
            this.Controls.Add(this.groupBoxMyBooksActivity);
            this.Name = "MyActivitiesForm";
            this.Text = "MyActivitiesForm";

            this.Controls.SetChildIndex(this.groupBoxMyBooksActivity, 0);
            this.Controls.SetChildIndex(this.dataGridViewUserBookActivity, 0);

            this.groupBoxMyBooksActivity.ResumeLayout(false);
            this.groupBoxMyBooksActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserBookActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMyBooksActivity;
        private System.Windows.Forms.RadioButton radioButtonReserved;
        private System.Windows.Forms.RadioButton radioButtonBorrowed;
        private System.Windows.Forms.DataGridView dataGridViewUserBookActivity;
    }
}