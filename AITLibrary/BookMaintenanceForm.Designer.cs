namespace AITLibrary
{
    partial class BookMaintenanceForm
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
            this.groupBoxUserMaintenance = new System.Windows.Forms.GroupBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxISBNMaintenace = new System.Windows.Forms.TextBox();
            this.textBoxNameMaintenance = new System.Windows.Forms.TextBox();
            this.labelNameMaintenance = new System.Windows.Forms.Label();
            this.labelISBNMaintenance = new System.Windows.Forms.Label();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioInsert = new System.Windows.Forms.RadioButton();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.dataGridViewListBooks = new System.Windows.Forms.DataGridView();
            this.groupBoxBookSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.textBoxISBNSearch = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxBookNameSearch = new System.Windows.Forms.TextBox();
            this.labelOrStudentSearch = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelSearchStudentby = new System.Windows.Forms.Label();
            this.groupBoxUserMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBooks)).BeginInit();
            this.groupBoxBookSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUserMaintenance
            // 
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxPublisher);
            this.groupBoxUserMaintenance.Controls.Add(this.labelPublisher);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxPages);
            this.groupBoxUserMaintenance.Controls.Add(this.labelPages);
            this.groupBoxUserMaintenance.Controls.Add(this.comboBoxLanguage);
            this.groupBoxUserMaintenance.Controls.Add(this.labelLanguage);
            this.groupBoxUserMaintenance.Controls.Add(this.comboBoxCategory);
            this.groupBoxUserMaintenance.Controls.Add(this.labelCategory);
            this.groupBoxUserMaintenance.Controls.Add(this.comboBoxAuthor);
            this.groupBoxUserMaintenance.Controls.Add(this.labelAuthor);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxYear);
            this.groupBoxUserMaintenance.Controls.Add(this.labelYear);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxISBNMaintenace);
            this.groupBoxUserMaintenance.Controls.Add(this.textBoxNameMaintenance);
            this.groupBoxUserMaintenance.Controls.Add(this.labelNameMaintenance);
            this.groupBoxUserMaintenance.Controls.Add(this.labelISBNMaintenance);
            this.groupBoxUserMaintenance.Controls.Add(this.radioDelete);
            this.groupBoxUserMaintenance.Controls.Add(this.radioUpdate);
            this.groupBoxUserMaintenance.Controls.Add(this.radioInsert);
            this.groupBoxUserMaintenance.Controls.Add(this.buttonExecute);
            this.groupBoxUserMaintenance.Location = new System.Drawing.Point(195, 315);
            this.groupBoxUserMaintenance.Name = "groupBoxUserMaintenance";
            this.groupBoxUserMaintenance.Size = new System.Drawing.Size(666, 197);
            this.groupBoxUserMaintenance.TabIndex = 19;
            this.groupBoxUserMaintenance.TabStop = false;
            this.groupBoxUserMaintenance.Text = "Book Maintenance ";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(386, 106);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(230, 20);
            this.textBoxPublisher.TabIndex = 26;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(335, 109);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(50, 13);
            this.labelPublisher.TabIndex = 25;
            this.labelPublisher.Text = "Publisher";
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(386, 78);
            this.textBoxPages.MaxLength = 5;
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(41, 20);
            this.textBoxPages.TabIndex = 24;
            this.textBoxPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPages_KeyPress);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(346, 81);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(37, 13);
            this.labelPages.TabIndex = 23;
            this.labelPages.Text = "Pages";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Administrator",
            "Supervisor",
            "User"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(105, 105);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguage.TabIndex = 22;
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(51, 108);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(55, 13);
            this.labelLanguage.TabIndex = 21;
            this.labelLanguage.Text = "Language";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Administrator",
            "Supervisor",
            "User"});
            this.comboBoxCategory.Location = new System.Drawing.Point(105, 78);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 20;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(55, 81);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 19;
            this.labelCategory.Text = "Category";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Items.AddRange(new object[] {
            "Administrator",
            "Supervisor",
            "User"});
            this.comboBoxAuthor.Location = new System.Drawing.Point(105, 51);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAuthor.TabIndex = 18;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(65, 54);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 17;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(386, 52);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(41, 20);
            this.textBoxYear.TabIndex = 16;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(351, 55);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 15;
            this.labelYear.Text = "Year";
            // 
            // textBoxISBNMaintenace
            // 
            this.textBoxISBNMaintenace.Location = new System.Drawing.Point(103, 25);
            this.textBoxISBNMaintenace.Name = "textBoxISBNMaintenace";
            this.textBoxISBNMaintenace.Size = new System.Drawing.Size(136, 20);
            this.textBoxISBNMaintenace.TabIndex = 14;
            this.textBoxISBNMaintenace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxISBNMaintenace_KeyPress);
            // 
            // textBoxNameMaintenance
            // 
            this.textBoxNameMaintenance.Location = new System.Drawing.Point(386, 25);
            this.textBoxNameMaintenance.Name = "textBoxNameMaintenance";
            this.textBoxNameMaintenance.Size = new System.Drawing.Size(230, 20);
            this.textBoxNameMaintenance.TabIndex = 9;
            // 
            // labelNameMaintenance
            // 
            this.labelNameMaintenance.AutoSize = true;
            this.labelNameMaintenance.Location = new System.Drawing.Point(345, 28);
            this.labelNameMaintenance.Name = "labelNameMaintenance";
            this.labelNameMaintenance.Size = new System.Drawing.Size(35, 13);
            this.labelNameMaintenance.TabIndex = 8;
            this.labelNameMaintenance.Text = "Name";
            // 
            // labelISBNMaintenance
            // 
            this.labelISBNMaintenance.AutoSize = true;
            this.labelISBNMaintenance.Location = new System.Drawing.Point(65, 28);
            this.labelISBNMaintenance.Name = "labelISBNMaintenance";
            this.labelISBNMaintenance.Size = new System.Drawing.Size(32, 13);
            this.labelISBNMaintenance.TabIndex = 13;
            this.labelISBNMaintenance.Text = "ISBN";
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.Location = new System.Drawing.Point(291, 168);
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
            this.radioUpdate.Location = new System.Drawing.Point(206, 168);
            this.radioUpdate.Name = "radioUpdate";
            this.radioUpdate.Size = new System.Drawing.Size(60, 17);
            this.radioUpdate.TabIndex = 11;
            this.radioUpdate.TabStop = true;
            this.radioUpdate.Text = "Update";
            this.radioUpdate.UseVisualStyleBackColor = true;
            this.radioUpdate.CheckedChanged += new System.EventHandler(this.radioUpdate_CheckedChanged);
            this.radioUpdate.Click += new System.EventHandler(this.radioUpdate_Click);
            // 
            // radioInsert
            // 
            this.radioInsert.AutoSize = true;
            this.radioInsert.Location = new System.Drawing.Point(117, 168);
            this.radioInsert.Name = "radioInsert";
            this.radioInsert.Size = new System.Drawing.Size(51, 17);
            this.radioInsert.TabIndex = 10;
            this.radioInsert.TabStop = true;
            this.radioInsert.Text = "Insert";
            this.radioInsert.UseVisualStyleBackColor = true;
            this.radioInsert.CheckedChanged += new System.EventHandler(this.radioInsert_CheckedChanged);
            this.radioInsert.Click += new System.EventHandler(this.radioInsert_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(367, 168);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 7;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // dataGridViewListBooks
            // 
            this.dataGridViewListBooks.AllowUserToAddRows = false;
            this.dataGridViewListBooks.AllowUserToDeleteRows = false;
            this.dataGridViewListBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListBooks.Location = new System.Drawing.Point(194, 36);
            this.dataGridViewListBooks.MultiSelect = false;
            this.dataGridViewListBooks.Name = "dataGridViewListBooks";
            this.dataGridViewListBooks.ReadOnly = true;
            this.dataGridViewListBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListBooks.Size = new System.Drawing.Size(878, 273);
            this.dataGridViewListBooks.TabIndex = 18;
            this.dataGridViewListBooks.Click += new System.EventHandler(this.dataGridViewListBooks_Click);
            // 
            // groupBoxBookSearch
            // 
            this.groupBoxBookSearch.Controls.Add(this.buttonSearchBook);
            this.groupBoxBookSearch.Controls.Add(this.textBoxISBNSearch);
            this.groupBoxBookSearch.Controls.Add(this.labelISBN);
            this.groupBoxBookSearch.Controls.Add(this.textBoxBookNameSearch);
            this.groupBoxBookSearch.Controls.Add(this.labelOrStudentSearch);
            this.groupBoxBookSearch.Controls.Add(this.labelBookName);
            this.groupBoxBookSearch.Controls.Add(this.labelSearchStudentby);
            this.groupBoxBookSearch.Location = new System.Drawing.Point(18, 36);
            this.groupBoxBookSearch.Name = "groupBoxBookSearch";
            this.groupBoxBookSearch.Size = new System.Drawing.Size(170, 134);
            this.groupBoxBookSearch.TabIndex = 17;
            this.groupBoxBookSearch.TabStop = false;
            this.groupBoxBookSearch.Text = "Book Search";
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Location = new System.Drawing.Point(58, 103);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(102, 23);
            this.buttonSearchBook.TabIndex = 14;
            this.buttonSearchBook.Text = "Search";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // textBoxISBNSearch
            // 
            this.textBoxISBNSearch.Location = new System.Drawing.Point(40, 36);
            this.textBoxISBNSearch.Name = "textBoxISBNSearch";
            this.textBoxISBNSearch.Size = new System.Drawing.Size(121, 20);
            this.textBoxISBNSearch.TabIndex = 8;
            this.textBoxISBNSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxISBNSearch_KeyPress);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(5, 39);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 13;
            this.labelISBN.Text = "ISBN";
            // 
            // textBoxBookNameSearch
            // 
            this.textBoxBookNameSearch.Location = new System.Drawing.Point(38, 77);
            this.textBoxBookNameSearch.Name = "textBoxBookNameSearch";
            this.textBoxBookNameSearch.Size = new System.Drawing.Size(123, 20);
            this.textBoxBookNameSearch.TabIndex = 12;
            this.textBoxBookNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBookNameSearch_KeyDown);
            // 
            // labelOrStudentSearch
            // 
            this.labelOrStudentSearch.AutoSize = true;
            this.labelOrStudentSearch.Location = new System.Drawing.Point(37, 59);
            this.labelOrStudentSearch.Name = "labelOrStudentSearch";
            this.labelOrStudentSearch.Size = new System.Drawing.Size(16, 13);
            this.labelOrStudentSearch.TabIndex = 11;
            this.labelOrStudentSearch.Text = "or";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(1, 80);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(35, 13);
            this.labelBookName.TabIndex = 9;
            this.labelBookName.Text = "Name";
            // 
            // labelSearchStudentby
            // 
            this.labelSearchStudentby.AutoSize = true;
            this.labelSearchStudentby.Location = new System.Drawing.Point(6, 16);
            this.labelSearchStudentby.Name = "labelSearchStudentby";
            this.labelSearchStudentby.Size = new System.Drawing.Size(86, 13);
            this.labelSearchStudentby.TabIndex = 8;
            this.labelSearchStudentby.Text = "Search Book by:";
            // 
            // BookMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBoxUserMaintenance);
            this.Controls.Add(this.dataGridViewListBooks);
            this.Controls.Add(this.groupBoxBookSearch);
            this.Name = "BookMaintenanceForm";
            this.Text = "BookMaintenanceForm";
            this.Load += new System.EventHandler(this.BookMaintenanceForm_Load);
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.groupBoxBookSearch, 0);
            this.Controls.SetChildIndex(this.dataGridViewListBooks, 0);
            this.Controls.SetChildIndex(this.groupBoxUserMaintenance, 0);
            this.groupBoxUserMaintenance.ResumeLayout(false);
            this.groupBoxUserMaintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBooks)).EndInit();
            this.groupBoxBookSearch.ResumeLayout(false);
            this.groupBoxBookSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserMaintenance;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxISBNMaintenace;
        private System.Windows.Forms.Label labelISBNMaintenance;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioInsert;
        private System.Windows.Forms.TextBox textBoxNameMaintenance;
        private System.Windows.Forms.Label labelNameMaintenance;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.DataGridView dataGridViewListBooks;
        private System.Windows.Forms.GroupBox groupBoxBookSearch;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.TextBox textBoxISBNSearch;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textBoxBookNameSearch;
        private System.Windows.Forms.Label labelOrStudentSearch;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelSearchStudentby;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.Label labelPages;
    }
}