using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemFramework;
using System.Web.Services.Protocols;

namespace AITLibrary
{
    public partial class BookReserveForm : LybraryTemplateForm
    {
        public BookReserveForm()
        {
            InitializeComponent();
        }

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = null;
            textBoxISBN.Text = null;
            textBoxBookName.Text = null;
            textBoxAuthor.Text = null;

            BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
            dataGridViewListBooks.DataSource = bookWS.GetAllBooksView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = null;

            if (textBoxISBN.Text.Length == 0 && textBoxBookName.Text.Length == 0 && textBoxAuthor.Text.Length == 0)
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgNoSearchCriteria;
            }
            else
            {
                BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
                dataGridViewListBooks.DataSource = bookWS.BookSearch(textBoxISBN.Text, textBoxBookName.Text, textBoxAuthor.Text);

                if (dataGridViewListBooks.RowCount == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgNoMatchesFound;
                }
            }
        }

        private void textBoxBookName_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxISBN.Text = null;
        }

        private void textBoxAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxISBN.Text = null;
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = null;

                if (dataGridViewListBooks.DataSource != null && dataGridViewListBooks.SelectedRows.Count > 0)
                {
                    String isbn = dataGridViewListBooks.SelectedRows[0].Cells[(int)AppEnum.ViewBookModel.Isbn].Value.ToString();
                    labelSystemMessage.Text = isbn;

                    BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
                    int resultOperation = bookWS.insertBookReserved(staticUserID, isbn, DateTime.Today.ToString());
                    if (resultOperation == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                    }
                    else
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                        labelSystemMessage.Text = Constants.msgOperationCompleted;
                        dataGridViewListBooks.DataSource = null;
                    }
                }
                else
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgSelectRecord;
                }
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

        private void textBoxISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;

            if (!Char.IsDigit(character) && character != 8)
            {
                e.Handled = true;
            }
            textBoxBookName.Text = null;
            textBoxAuthor.Text = null;
        }
    }
}
