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
    public partial class BookSearchForm : LybraryTemplateForm
    {
        public BookSearchForm()
        {
            InitializeComponent();
        }

        private void buttonListBooks_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = Constants.msgLabelDefault;
                textBoxISBN.Text = null;
                textBoxBookName.Text = null;
                textBoxAuthor.Text = null;
                dataGridViewListBooks.DataSource = null;
                BookLogic bookLogic = new BookLogic();
                dataGridViewListBooks.DataSource = bookLogic.GetAllBooksView();
            }
            catch (BusinessLogicException ex)
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxISBN.Text.Length == 0 && textBoxBookName.Text.Length == 0 && textBoxAuthor.Text.Length == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgNoSearchCriteria;
                }
                else
                {
                    labelMessageForUser.Text = null;
                    BookLogic bookLogic = new BookLogic();
                    dataGridViewListBooks.DataSource = bookLogic.BookSearch(textBoxISBN.Text, textBoxBookName.Text, textBoxAuthor.Text);

                    if (dataGridViewListBooks.RowCount == 0)
                    {
                        labelMessageForUser.ForeColor = System.Drawing.Color.Red;
                        labelMessageForUser.Text = "No matches found.";
                    }
                }
            }
            catch (BusinessLogicException ex)
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

        private void textBoxBookName_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxISBN.Text = null;
        }

        private void textBoxAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxISBN.Text = null;
        }


    }
}
