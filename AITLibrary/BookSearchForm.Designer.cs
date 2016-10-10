namespace AITLibrary
{
    partial class BookSearchForm
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
            this.dataGridViewListBooks = new System.Windows.Forms.DataGridView();
            this.buttonListAllBooks = new System.Windows.Forms.Button();
            this.groupBoxSearchBooks = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.labelOr = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelMessageForUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBooks)).BeginInit();
            this.groupBoxSearchBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListBooks
            // 
            this.dataGridViewListBooks.AllowUserToAddRows = false;
            this.dataGridViewListBooks.AllowUserToDeleteRows = false;
            this.dataGridViewListBooks.AllowUserToOrderColumns = true;
            this.dataGridViewListBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListBooks.Location = new System.Drawing.Point(229, 41);
            this.dataGridViewListBooks.Name = "dataGridViewListBooks";
            this.dataGridViewListBooks.ReadOnly = true;
            this.dataGridViewListBooks.Size = new System.Drawing.Size(817, 357);
            this.dataGridViewListBooks.TabIndex = 0;
            // 
            // buttonListAllBooks
            // 
            this.buttonListAllBooks.Location = new System.Drawing.Point(97, 234);
            this.buttonListAllBooks.Name = "buttonListAllBooks";
            this.buttonListAllBooks.Size = new System.Drawing.Size(100, 23);
            this.buttonListAllBooks.TabIndex = 1;
            this.buttonListAllBooks.Text = "List All Books";
            this.buttonListAllBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBooks.Click += new System.EventHandler(this.buttonListBooks_Click);
            // 
            // groupBoxSearchBooks
            // 
            this.groupBoxSearchBooks.Controls.Add(this.buttonSearch);
            this.groupBoxSearchBooks.Controls.Add(this.buttonListAllBooks);
            this.groupBoxSearchBooks.Controls.Add(this.textBoxAuthor);
            this.groupBoxSearchBooks.Controls.Add(this.labelAuthor);
            this.groupBoxSearchBooks.Controls.Add(this.textBoxBookName);
            this.groupBoxSearchBooks.Controls.Add(this.labelBookName);
            this.groupBoxSearchBooks.Controls.Add(this.labelSearchBy);
            this.groupBoxSearchBooks.Controls.Add(this.labelOr);
            this.groupBoxSearchBooks.Controls.Add(this.textBoxISBN);
            this.groupBoxSearchBooks.Controls.Add(this.labelISBN);
            this.groupBoxSearchBooks.Location = new System.Drawing.Point(12, 35);
            this.groupBoxSearchBooks.Name = "groupBoxSearchBooks";
            this.groupBoxSearchBooks.Size = new System.Drawing.Size(207, 268);
            this.groupBoxSearchBooks.TabIndex = 3;
            this.groupBoxSearchBooks.TabStop = false;
            this.groupBoxSearchBooks.Text = "Books Search ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(97, 197);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(63, 131);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(134, 20);
            this.textBoxAuthor.TabIndex = 7;
            this.textBoxAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAuthor_KeyDown);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(24, 134);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(63, 104);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(134, 20);
            this.textBoxBookName.TabIndex = 5;
            this.textBoxBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBookName_KeyDown);
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(-1, 107);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(63, 13);
            this.labelBookName.TabIndex = 4;
            this.labelBookName.Text = "Book Name";
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(7, 20);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(58, 13);
            this.labelSearchBy.TabIndex = 3;
            this.labelSearchBy.Text = "Search by:";
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Location = new System.Drawing.Point(54, 75);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(16, 13);
            this.labelOr.TabIndex = 2;
            this.labelOr.Text = "or";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(63, 36);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(134, 20);
            this.textBoxISBN.TabIndex = 1;
            this.textBoxISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxISBN_KeyPress);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(30, 39);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 0;
            this.labelISBN.Text = "ISBN";
            // 
            // labelMessageForUser
            // 
            this.labelMessageForUser.AutoSize = true;
            this.labelMessageForUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageForUser.ForeColor = System.Drawing.Color.Black;
            this.labelMessageForUser.Location = new System.Drawing.Point(14, 310);
            this.labelMessageForUser.Name = "labelMessageForUser";
            this.labelMessageForUser.Size = new System.Drawing.Size(0, 16);
            this.labelMessageForUser.TabIndex = 4;
            // 
            // BookSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.labelMessageForUser);
            this.Controls.Add(this.groupBoxSearchBooks);
            this.Controls.Add(this.dataGridViewListBooks);
            this.Name = "BookSearchForm";
            this.Text = "Book";
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.dataGridViewListBooks, 0);
            this.Controls.SetChildIndex(this.groupBoxSearchBooks, 0);
            this.Controls.SetChildIndex(this.labelMessageForUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBooks)).EndInit();
            this.groupBoxSearchBooks.ResumeLayout(false);
            this.groupBoxSearchBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListBooks;
        private System.Windows.Forms.Button buttonListAllBooks;
        private System.Windows.Forms.GroupBox groupBoxSearchBooks;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelMessageForUser;
    }
}