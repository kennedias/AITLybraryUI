namespace AITLibrary
{
    partial class ReturnBookForm
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
            this.dataGridViewBooksBorrowed = new System.Windows.Forms.DataGridView();
            this.groupBoxReturnBook = new System.Windows.Forms.GroupBox();
            this.buttonListAllBorrowedBooks = new System.Windows.Forms.Button();
            this.buttonSearchByCriteria = new System.Windows.Forms.Button();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelOrBookSearch = new System.Windows.Forms.Label();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksBorrowed)).BeginInit();
            this.groupBoxReturnBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooksBorrowed
            // 
            this.dataGridViewBooksBorrowed.AllowUserToAddRows = false;
            this.dataGridViewBooksBorrowed.AllowUserToDeleteRows = false;
            this.dataGridViewBooksBorrowed.AllowUserToOrderColumns = true;
            this.dataGridViewBooksBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksBorrowed.Location = new System.Drawing.Point(226, 62);
            this.dataGridViewBooksBorrowed.MultiSelect = false;
            this.dataGridViewBooksBorrowed.Name = "dataGridViewBooksBorrowed";
            this.dataGridViewBooksBorrowed.ReadOnly = true;
            this.dataGridViewBooksBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooksBorrowed.Size = new System.Drawing.Size(846, 484);
            this.dataGridViewBooksBorrowed.TabIndex = 2;
            // 
            // groupBoxReturnBook
            // 
            this.groupBoxReturnBook.Controls.Add(this.buttonListAllBorrowedBooks);
            this.groupBoxReturnBook.Controls.Add(this.buttonSearchByCriteria);
            this.groupBoxReturnBook.Controls.Add(this.textBoxBookName);
            this.groupBoxReturnBook.Controls.Add(this.labelBookName);
            this.groupBoxReturnBook.Controls.Add(this.labelOrBookSearch);
            this.groupBoxReturnBook.Location = new System.Drawing.Point(12, 55);
            this.groupBoxReturnBook.Name = "groupBoxReturnBook";
            this.groupBoxReturnBook.Size = new System.Drawing.Size(209, 150);
            this.groupBoxReturnBook.TabIndex = 3;
            this.groupBoxReturnBook.TabStop = false;
            this.groupBoxReturnBook.Text = "Borrowed Book Search";
            // 
            // buttonListAllBorrowedBooks
            // 
            this.buttonListAllBorrowedBooks.Location = new System.Drawing.Point(70, 117);
            this.buttonListAllBorrowedBooks.Name = "buttonListAllBorrowedBooks";
            this.buttonListAllBorrowedBooks.Size = new System.Drawing.Size(133, 23);
            this.buttonListAllBorrowedBooks.TabIndex = 14;
            this.buttonListAllBorrowedBooks.Text = "List All Borrowed Books";
            this.buttonListAllBorrowedBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBorrowedBooks.Click += new System.EventHandler(this.buttonListAllBorrowedBooks_Click);
            // 
            // buttonSearchByCriteria
            // 
            this.buttonSearchByCriteria.Location = new System.Drawing.Point(70, 61);
            this.buttonSearchByCriteria.Name = "buttonSearchByCriteria";
            this.buttonSearchByCriteria.Size = new System.Drawing.Size(133, 23);
            this.buttonSearchByCriteria.TabIndex = 13;
            this.buttonSearchByCriteria.Text = "Search";
            this.buttonSearchByCriteria.UseVisualStyleBackColor = true;
            this.buttonSearchByCriteria.Click += new System.EventHandler(this.buttonSearchByCriteria_Click);
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(70, 28);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(134, 20);
            this.textBoxBookName.TabIndex = 11;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(6, 31);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(63, 13);
            this.labelBookName.TabIndex = 10;
            this.labelBookName.Text = "Book Name";
            // 
            // labelOrBookSearch
            // 
            this.labelOrBookSearch.AutoSize = true;
            this.labelOrBookSearch.Location = new System.Drawing.Point(71, 90);
            this.labelOrBookSearch.Name = "labelOrBookSearch";
            this.labelOrBookSearch.Size = new System.Drawing.Size(16, 13);
            this.labelOrBookSearch.TabIndex = 8;
            this.labelOrBookSearch.Text = "or";
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Location = new System.Drawing.Point(82, 215);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(133, 23);
            this.buttonReturnBook.TabIndex = 4;
            this.buttonReturnBook.Text = "Return Book";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.groupBoxReturnBook);
            this.Controls.Add(this.dataGridViewBooksBorrowed);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.dataGridViewBooksBorrowed, 0);
            this.Controls.SetChildIndex(this.groupBoxReturnBook, 0);
            this.Controls.SetChildIndex(this.buttonReturnBook, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksBorrowed)).EndInit();
            this.groupBoxReturnBook.ResumeLayout(false);
            this.groupBoxReturnBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooksBorrowed;
        private System.Windows.Forms.GroupBox groupBoxReturnBook;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelOrBookSearch;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.Button buttonSearchByCriteria;
        private System.Windows.Forms.Button buttonListAllBorrowedBooks;
    }
}