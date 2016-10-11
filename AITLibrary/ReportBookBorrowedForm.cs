using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Services.Protocols;
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
            try
            {
                labelSystemMessage.Text = Constants.msgLabelDefault;
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                dataGridViewBorrowedBooks.DataSource = null;

                BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
                dataGridViewBorrowedBooks.DataSource = bookWS.GetAllBorrowedBooksWithUser();
                dataGridViewBorrowedBooks.Columns[Constants.fieldBorrowId].Visible = false;
                dataGridViewBorrowedBooks.Columns[Constants.fieldLatefee].Visible = false;
                dataGridViewBorrowedBooks.Columns[Constants.fieldUserId].Visible = false;
            }
            catch (SoapException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorSystemToUser;
            }

        }

    }
}
