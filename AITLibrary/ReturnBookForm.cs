﻿using System;
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
    public partial class ReturnBookForm : LybraryTemplateForm
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void buttonSearchByCriteria_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = null;

                if (textBoxBookName.Text.Length == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgNoSearchCriteria;
                }
                else
                {
                    BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
                    dataGridViewBooksBorrowed.DataSource = bookWS.GetBooksBorrowedViewByName(textBoxBookName.Text);
                    dataGridViewBooksBorrowed.Columns[Constants.fieldUserId].Visible = false;
                    dataGridViewBooksBorrowed.Columns[Constants.fieldBorrowId].Visible = false;
                    dataGridViewBooksBorrowed.Columns[Constants.fieldLatefee].Visible = false; 

                    if (dataGridViewBooksBorrowed.RowCount == 0)
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

        private void buttonListAllBorrowedBooks_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxBookName.Text = null;
                labelSystemMessage.Text = null;
                BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
                dataGridViewBooksBorrowed.DataSource = bookWS.GetAllBooksBorrowedWithUserView();
                dataGridViewBooksBorrowed.Columns[Constants.fieldUserId].Visible = false;
                dataGridViewBooksBorrowed.Columns[Constants.fieldBorrowId].Visible = false;
                dataGridViewBooksBorrowed.Columns[Constants.fieldLatefee].Visible = false; 

                if (dataGridViewBooksBorrowed.RowCount == 0)
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

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = null;

                if (dataGridViewBooksBorrowed.DataSource != null && dataGridViewBooksBorrowed.SelectedRows.Count > 0)
                {
                    int bidColumnIndex = (int)AppEnum.ViewBookBorrowedWithUserModel.BorrowId;
                    int returnDateColumnIndex = (int)AppEnum.ViewBookBorrowedWithUserModel.Return;

                    int bid = (int)dataGridViewBooksBorrowed.SelectedRows[0].Cells[bidColumnIndex].Value;
                    String returnDate = dataGridViewBooksBorrowed.SelectedRows[0].Cells[returnDateColumnIndex].Value.ToString();

                    BookWSIntegration.BookWS bookWS = new BookWSIntegration.BookWS();
                    int resultOperation = bookWS.ReturnBorrowBook(bid, returnDate);

                    if (resultOperation == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                    }
                    else
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                        labelSystemMessage.Text = Constants.msgOperationCompleted;
                        dataGridViewBooksBorrowed.DataSource = null;
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
    }
}
