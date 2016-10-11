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
    public partial class BorrowBookForm : LybraryTemplateForm
    {
        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private void buttonSearchBooks_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = null;
                BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
                dataGridViewListBooks.DataSource = bookWS.GetAllBooksAvailableByBookNameAndAuthor(textBoxBookName.Text, textBoxAuthor.Text);

                if (dataGridViewListBooks.RowCount == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgNoMatchesFound;
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

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = null;
                textBoxBookName.Text = null;
                textBoxAuthor.Text = null;
                dataGridViewListBooks.DataSource = null;
                BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
                dataGridViewListBooks.DataSource = bookWS.GetAllAvailableBooks();
            }
            catch (SoapException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewListBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewListBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorSystemToUser;
            }
        }

        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {
            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
            labelSystemMessage.Text = Constants.msgLabelDefault;

            try
            {
                if ((dataGridViewListBooks.DataSource != null && dataGridViewListBooks.SelectedRows.Count > 0) &&
                    (dataGridViewUser.DataSource != null && dataGridViewUser.SelectedRows.Count > 0))
                {

                    String isbn = dataGridViewListBooks.SelectedRows[0].Cells[(int)AppEnum.ViewBookModel.Isbn].Value.ToString();
                    int userId = (int) dataGridViewUser.SelectedRows[0].Cells[(int)AppEnum.TabUserModel.ID].Value;

                    BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
                    int resultOperation = bookWS.InsertBorrowBook(userId, isbn);

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
                        dataGridViewUser.DataSource = null;
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

        private void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = null;

                if (textBoxUserName.Text == "")
                {
                    labelSystemMessage.Text = Constants.msgUserNameBlank;
                }
                else
                {
                    UserWSIntegration.UserWS userWS = new UserWSIntegration.UserWS();

                    dataGridViewUser.DataSource = userWS.GetUsersByName(textBoxUserName.Text);
                    dataGridViewUser.Columns[Constants.fieldID].Visible = false;
                    dataGridViewUser.Columns[Constants.fieldLevelCode].Visible = false;
                    dataGridViewUser.Columns[Constants.fieldLevelDescription].Visible = false;

                    if (dataGridViewUser.RowCount == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgNoMatchesFound;
                    }

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
    }
}
