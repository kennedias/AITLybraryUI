namespace AITLibrary
{
    partial class BooksBorrowedAndReservedForm
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBoxActivity = new System.Windows.Forms.GroupBox();
            this.radioButtonReserved = new System.Windows.Forms.RadioButton();
            this.radioBorrowed = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.groupBoxActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToOrderColumns = true;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(964, 339);
            this.dataGridViewBooks.TabIndex = 2;
            // 
            // groupBoxActivity
            // 
            this.groupBoxActivity.Controls.Add(this.radioButtonReserved);
            this.groupBoxActivity.Controls.Add(this.radioBorrowed);
            this.groupBoxActivity.Location = new System.Drawing.Point(12, 37);
            this.groupBoxActivity.Name = "groupBoxActivity";
            this.groupBoxActivity.Size = new System.Drawing.Size(168, 42);
            this.groupBoxActivity.TabIndex = 3;
            this.groupBoxActivity.TabStop = false;
            this.groupBoxActivity.Text = "Activity";
            // 
            // radioButtonReserved
            // 
            this.radioButtonReserved.AutoSize = true;
            this.radioButtonReserved.Location = new System.Drawing.Point(92, 19);
            this.radioButtonReserved.Name = "radioButtonReserved";
            this.radioButtonReserved.Size = new System.Drawing.Size(71, 17);
            this.radioButtonReserved.TabIndex = 1;
            this.radioButtonReserved.TabStop = true;
            this.radioButtonReserved.Text = "Reserved";
            this.radioButtonReserved.UseVisualStyleBackColor = true;
            this.radioButtonReserved.CheckedChanged += new System.EventHandler(this.radioButtonReserved_CheckedChanged);
            // 
            // radioBorrowed
            // 
            this.radioBorrowed.AutoSize = true;
            this.radioBorrowed.Location = new System.Drawing.Point(6, 19);
            this.radioBorrowed.Name = "radioBorrowed";
            this.radioBorrowed.Size = new System.Drawing.Size(70, 17);
            this.radioBorrowed.TabIndex = 0;
            this.radioBorrowed.TabStop = true;
            this.radioBorrowed.Text = "Borrowed";
            this.radioBorrowed.UseVisualStyleBackColor = true;
            this.radioBorrowed.CheckedChanged += new System.EventHandler(this.radioBorrowed_CheckedChanged);
            // 
            // BooksBorrowedAndReservedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBoxActivity);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "BooksBorrowedAndReservedForm";
            this.Text = "BooksBorrowedForm";
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.dataGridViewBooks, 0);
            this.Controls.SetChildIndex(this.groupBoxActivity, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.groupBoxActivity.ResumeLayout(false);
            this.groupBoxActivity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.GroupBox groupBoxActivity;
        private System.Windows.Forms.RadioButton radioButtonReserved;
        private System.Windows.Forms.RadioButton radioBorrowed;
    }
}