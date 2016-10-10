using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using SystemFramework;

namespace AITLibrary
{
    public partial class ReportBookBorrowedForm : LybraryTemplateForm
    {
        public ReportBookBorrowedForm()
        {
            InitializeComponent();
        }

        private void ReportBookBorrowedForm_Load(object sender, EventArgs e)
        {
            labelSystemMessage.Text = Constants.msgLabelDefault;
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            dataGridViewBorrowedBooks.DataSource = null;

            BookLogic bookLogic = new BookLogic();
            dataGridViewBorrowedBooks.DataSource = bookLogic.GetAllBorrowedBooksWithUser();
            dataGridViewBorrowedBooks.Columns[Constants.fieldBorrowId].Visible = false;
            dataGridViewBorrowedBooks.Columns[Constants.fieldLatefee].Visible = false;
            dataGridViewBorrowedBooks.Columns[Constants.fieldUserId].Visible = false;
        }

    }
}
