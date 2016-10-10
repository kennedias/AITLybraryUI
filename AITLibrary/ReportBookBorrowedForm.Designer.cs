namespace AITLibrary
{
    partial class ReportBookBorrowedForm
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
            this.dataGridViewBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.labelReportDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrowedBooks
            // 
            this.dataGridViewBorrowedBooks.AllowUserToAddRows = false;
            this.dataGridViewBorrowedBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBorrowedBooks.AllowUserToOrderColumns = true;
            this.dataGridViewBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowedBooks.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewBorrowedBooks.Name = "dataGridViewBorrowedBooks";
            this.dataGridViewBorrowedBooks.ReadOnly = true;
            this.dataGridViewBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBorrowedBooks.Size = new System.Drawing.Size(1052, 506);
            this.dataGridViewBorrowedBooks.TabIndex = 2;
            // 
            // labelReportDescription
            // 
            this.labelReportDescription.AutoSize = true;
            this.labelReportDescription.Location = new System.Drawing.Point(13, 43);
            this.labelReportDescription.Name = "labelReportDescription";
            this.labelReportDescription.Size = new System.Drawing.Size(208, 13);
            this.labelReportDescription.TabIndex = 3;
            this.labelReportDescription.Text = "Borrowed Books Ordered by Book Name.  ";
            // 
            // ReportBookBorrowedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.labelReportDescription);
            this.Controls.Add(this.dataGridViewBorrowedBooks);
            this.Name = "ReportBookBorrowedForm";
            this.Text = "ReportBookBorrowedForm";
            this.Load += new System.EventHandler(this.ReportBookBorrowedForm_Load);
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.dataGridViewBorrowedBooks, 0);
            this.Controls.SetChildIndex(this.labelReportDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBorrowedBooks;
        private System.Windows.Forms.Label labelReportDescription;
    }
}