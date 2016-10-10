namespace AITLibrary
{
    partial class BorrowBookForm
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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.groupBoxStudentSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.buttonBorrowBook = new System.Windows.Forms.Button();
            this.groupBoxSearchBooks = new System.Windows.Forms.GroupBox();
            this.buttonSearchBooks = new System.Windows.Forms.Button();
            this.buttonListAllBooks = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelOrBookSearch = new System.Windows.Forms.Label();
            this.dataGridViewListBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.groupBoxStudentSearch.SuspendLayout();
            this.groupBoxSearchBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(238, 34);
            this.dataGridViewUser.MultiSelect = false;
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(817, 134);
            this.dataGridViewUser.TabIndex = 13;
            // 
            // groupBoxStudentSearch
            // 
            this.groupBoxStudentSearch.Controls.Add(this.buttonSearchStudent);
            this.groupBoxStudentSearch.Controls.Add(this.textBoxUserName);
            this.groupBoxStudentSearch.Controls.Add(this.labelStudentName);
            this.groupBoxStudentSearch.Location = new System.Drawing.Point(14, 34);
            this.groupBoxStudentSearch.Name = "groupBoxStudentSearch";
            this.groupBoxStudentSearch.Size = new System.Drawing.Size(214, 134);
            this.groupBoxStudentSearch.TabIndex = 12;
            this.groupBoxStudentSearch.TabStop = false;
            this.groupBoxStudentSearch.Text = "Student Search";
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.Location = new System.Drawing.Point(104, 82);
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.Size = new System.Drawing.Size(102, 23);
            this.buttonSearchStudent.TabIndex = 14;
            this.buttonSearchStudent.Text = "Search";
            this.buttonSearchStudent.UseVisualStyleBackColor = true;
            this.buttonSearchStudent.Click += new System.EventHandler(this.buttonSearchStudent_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(70, 37);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(136, 20);
            this.textBoxUserName.TabIndex = 12;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(9, 40);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(60, 13);
            this.labelStudentName.TabIndex = 9;
            this.labelStudentName.Text = "User Name";
            // 
            // buttonBorrowBook
            // 
            this.buttonBorrowBook.Location = new System.Drawing.Point(12, 367);
            this.buttonBorrowBook.Name = "buttonBorrowBook";
            this.buttonBorrowBook.Size = new System.Drawing.Size(216, 23);
            this.buttonBorrowBook.TabIndex = 11;
            this.buttonBorrowBook.Text = "Borrow Book";
            this.buttonBorrowBook.UseVisualStyleBackColor = true;
            this.buttonBorrowBook.Click += new System.EventHandler(this.buttonBorrowBook_Click);
            // 
            // groupBoxSearchBooks
            // 
            this.groupBoxSearchBooks.Controls.Add(this.buttonSearchBooks);
            this.groupBoxSearchBooks.Controls.Add(this.buttonListAllBooks);
            this.groupBoxSearchBooks.Controls.Add(this.textBoxAuthor);
            this.groupBoxSearchBooks.Controls.Add(this.labelAuthor);
            this.groupBoxSearchBooks.Controls.Add(this.textBoxBookName);
            this.groupBoxSearchBooks.Controls.Add(this.labelBookName);
            this.groupBoxSearchBooks.Controls.Add(this.labelOrBookSearch);
            this.groupBoxSearchBooks.Location = new System.Drawing.Point(12, 171);
            this.groupBoxSearchBooks.Name = "groupBoxSearchBooks";
            this.groupBoxSearchBooks.Size = new System.Drawing.Size(216, 190);
            this.groupBoxSearchBooks.TabIndex = 10;
            this.groupBoxSearchBooks.TabStop = false;
            this.groupBoxSearchBooks.Text = "Books Search ";
            // 
            // buttonSearchBooks
            // 
            this.buttonSearchBooks.Location = new System.Drawing.Point(106, 130);
            this.buttonSearchBooks.Name = "buttonSearchBooks";
            this.buttonSearchBooks.Size = new System.Drawing.Size(100, 23);
            this.buttonSearchBooks.TabIndex = 10;
            this.buttonSearchBooks.Text = "Search";
            this.buttonSearchBooks.UseVisualStyleBackColor = true;
            this.buttonSearchBooks.Click += new System.EventHandler(this.buttonSearchBooks_Click);
            // 
            // buttonListAllBooks
            // 
            this.buttonListAllBooks.Location = new System.Drawing.Point(106, 159);
            this.buttonListAllBooks.Name = "buttonListAllBooks";
            this.buttonListAllBooks.Size = new System.Drawing.Size(100, 23);
            this.buttonListAllBooks.TabIndex = 1;
            this.buttonListAllBooks.Text = "List All Books";
            this.buttonListAllBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBooks.Click += new System.EventHandler(this.buttonListAllBooks_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(72, 78);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(134, 20);
            this.textBoxAuthor.TabIndex = 7;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(33, 81);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(72, 35);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(134, 20);
            this.textBoxBookName.TabIndex = 5;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(8, 38);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(63, 13);
            this.labelBookName.TabIndex = 4;
            this.labelBookName.Text = "Book Name";
            // 
            // labelOrBookSearch
            // 
            this.labelOrBookSearch.AutoSize = true;
            this.labelOrBookSearch.Location = new System.Drawing.Point(72, 59);
            this.labelOrBookSearch.Name = "labelOrBookSearch";
            this.labelOrBookSearch.Size = new System.Drawing.Size(39, 13);
            this.labelOrBookSearch.TabIndex = 2;
            this.labelOrBookSearch.Text = "and/or";
            // 
            // dataGridViewListBooks
            // 
            this.dataGridViewListBooks.AllowUserToAddRows = false;
            this.dataGridViewListBooks.AllowUserToDeleteRows = false;
            this.dataGridViewListBooks.AllowUserToOrderColumns = true;
            this.dataGridViewListBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListBooks.Location = new System.Drawing.Point(238, 177);
            this.dataGridViewListBooks.MultiSelect = false;
            this.dataGridViewListBooks.Name = "dataGridViewListBooks";
            this.dataGridViewListBooks.ReadOnly = true;
            this.dataGridViewListBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListBooks.Size = new System.Drawing.Size(817, 184);
            this.dataGridViewListBooks.TabIndex = 9;
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.groupBoxStudentSearch);
            this.Controls.Add(this.buttonBorrowBook);
            this.Controls.Add(this.groupBoxSearchBooks);
            this.Controls.Add(this.dataGridViewListBooks);
            this.Name = "BorrowBookForm";
            this.Text = "BorrowBookForm";
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.dataGridViewListBooks, 0);
            this.Controls.SetChildIndex(this.groupBoxSearchBooks, 0);
            this.Controls.SetChildIndex(this.buttonBorrowBook, 0);
            this.Controls.SetChildIndex(this.groupBoxStudentSearch, 0);
            this.Controls.SetChildIndex(this.dataGridViewUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.groupBoxStudentSearch.ResumeLayout(false);
            this.groupBoxStudentSearch.PerformLayout();
            this.groupBoxSearchBooks.ResumeLayout(false);
            this.groupBoxSearchBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.GroupBox groupBoxStudentSearch;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Button buttonBorrowBook;
        private System.Windows.Forms.GroupBox groupBoxSearchBooks;
        private System.Windows.Forms.Button buttonSearchBooks;
        private System.Windows.Forms.Button buttonListAllBooks;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelOrBookSearch;
        private System.Windows.Forms.DataGridView dataGridViewListBooks;
    }
}